﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationmodels.Models;

namespace WebApplicationmodels.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }

        private Employee GetEmployee()
        {
            return new Employee
            {
                id = 1,
                Name = "Zohaib",
                Address = "Bahawalpur"
            };
        }
    }
            
}