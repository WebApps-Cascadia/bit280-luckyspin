using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        private Repository repository;

        /***
         * Controller Constructor
         */
        public SpinnerController(Repository r)
        {
            repository = r;
        }

        /***
         * Entry Page Action
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            if(ModelState.IsValid)
                return RedirectToAction("Spin", player);
            else
                return View();
        }

        /***
         * Spin Action
         **/  
               
         public IActionResult Spin(Player player)
        {
            return View("Spin", new Spin { Player = player });
        }

        /***
         * ListSpins Action
         **/

         public IActionResult LuckList()
        {
                return View(repository.PlayerSpins);
        }

    }
}

