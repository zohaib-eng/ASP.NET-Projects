using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routing.Models
{
    public class Student
    {
        public int id { get; set; }

        public String Name { get; set; }

        public String Class { get; set; }

        public Address Address { get; set; }
    }
}