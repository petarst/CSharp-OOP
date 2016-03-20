﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4_1.Models
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        

    }
}
