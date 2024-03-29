﻿using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        [Required(ErrorMessage ="Please enter your Name")]
        public string FirstName { get; set; }

        [Range(1,9, ErrorMessage = "Choose a number")]
        public int Luck { get; set; }
    }
}