using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationcontroller.Controllers
{
    public class EmployeeController : Controller
    {
       
        public String employeeprofile(int id)
        {
            String profile = "";
            if (id == 1)
            {
                profile = "Zohaib";
            }
            else if (id == 4)
            {
                profile = "Akhter";
            }
            else
            {
                profile = "No record";
            }
            return profile;
        }

        public String address(int id,int? code=null)
        {
            return "id=" + id + "department=" + code;
        }
    }
}