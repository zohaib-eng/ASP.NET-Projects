using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datafromviewtocontroller.Models;

namespace Datafromviewtocontroller.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public String Postusingparameters(String firstname,String lastname)
        {
            return "From Parameters - " + firstname + "," + lastname;
        }

        [HttpPost]
        public String Postusingruqest(String firstname, String lastname)
        {
            String firstName = Request["firstname"];
            String lastName = Request["lastname"];
            return "From Ruqest - " + firstname + "," + lastname;
        }

        public String PostusingFormCollection(FormCollection form)
        {
            String firstName = form["firstname"];
            String lastName = form["lastname"];
            return "From Form Collection - " + firstName + "," + lastName;
        }


        public String PostusingBinding(Employee emp)
        {
            
            return "From Form Binding - " + emp.firstName + "," + emp.lastName;
        }
    }
}