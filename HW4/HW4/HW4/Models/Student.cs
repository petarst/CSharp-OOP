
namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : People
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            : base (firstName,lastName)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set {
                if (value <1)
                {
                    throw new ArgumentException("Class nember don't have to be less than 1");
                }
                this.classNumber = value; 
                }
        }
        
    }
}
