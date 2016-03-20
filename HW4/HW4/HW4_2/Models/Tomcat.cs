using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4_2.Models
{
    public class Tomcat:Cat
    {
        public Tomcat(string name, int age)
            : base (name, age, true)
        {
           
        }
    }
}
