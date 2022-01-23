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
        private Repository repository; //instance variable

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
            if (!ModelState.IsValid) { return View(); }

            return RedirectToAction("Spin", player);
        }

        /***
         * Spin Action
         **/  
               
        public IActionResult Spin(Player player)
        {
            //Create a new Spin and add it to the repository
            Spin spin = new Spin { Player = player };
            repository.AddSpin(spin);

            return View("Spin", spin);
        }

        /***
         * ListSpins Action
         **/
        [HttpGet]
        public IActionResult LuckList()
        {
                return View(repository.PlayerSpins);
        }

    }
}

