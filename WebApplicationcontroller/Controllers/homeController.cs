using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationcontroller.Controllers
{
    public class homeController : Controller
    {
        public String Index()
        {
            return "Hello Mr Zohaib";
        }

        public String Name()
        {
            return "My Name is Zohaib";
        }
    }
}