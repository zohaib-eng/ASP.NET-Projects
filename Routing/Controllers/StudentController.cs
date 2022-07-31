using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudents()
        {
            var Students = new Student();
            return View(Students);
        }

        public ActionResult GetSingleStudent(int id)
        {
            var Student = new Student().id;
            return View(Student);
        }

        public ActionResult GetStudentAddress(int id)
        {
            var Studentaddress = new Student().Address;
            return View(Studentaddress);
        }

        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    id=1,
                    Name="Zohaib",
                    Class="First",
                    Address=new Address()
                    {
                        Address1="Student 1 Adress",
                        City="Student1 City",
                        Homenumber="Student 1",
                    }
                },

                new Student()
                {
                    id=2,
                    Name="Shoaib",
                    Class="Second",
                    Address=new Address()
                    {
                        Address1="Student 2 Adress",
                        City="Student2 City",
                        Homenumber="Student 2",
                    }
                },

                new Student()
                {
                    id=3,
                    Name="Tayab",
                    Class="Third",
                    Address=new Address()
                    {
                        Address1="Student 3 Adress",
                        City="Student3 City",
                        Homenumber="Student 3",
                    }
                },
            };
        }
    }
}