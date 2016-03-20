using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3_18.Models
{
    class Student
    {
        private string name;
        private string group;

        public Student(string name, string group)
        {
            this.Name = name;
            this.Group = group;
        }

        public string Group
        {
            get { return this.group; }
            private set { this.group = value; }
        }
        

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public override string ToString()
        {
            return this.Name + ":" + this.Group;
        }
    }
}
