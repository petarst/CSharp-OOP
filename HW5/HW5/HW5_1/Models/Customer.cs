using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5_1.Models
{
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; } 
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }
    }
}
