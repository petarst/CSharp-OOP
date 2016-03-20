namespace HW3_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Students
    {
        private string firstName;
        private string lastName;
        private int age;

        public Students(string firstName, string lastName, int age)
            
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName 
        
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                this.firstName= value;
            }
        }
        public string LastName 
        {
            get { return this.lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }
                this.lastName = value;
            }
        }

        public int Age 
        {
            get { return this.age; }
            set 
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2} years old", this.firstName, this.lastName, this.age);
        }

        
    }
}
