using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace looselybinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="please enter your first name")]
        public String Firstname { get; set; }
        [Required(ErrorMessage = "please enter your last name")]
        public String Lastname { get; set; }
        [Required(ErrorMessage = "please enter your valid email")]
        [EmailAddress]
        public String Email { get; set; }
        [Required(ErrorMessage = "please enter your age")]
        [Range(0,100)]
        public int Age { get; set; }
    }
}