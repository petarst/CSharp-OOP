using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4_2.Models
{
    public abstract class Animal: ISound
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public bool IsMale
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }
        

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public static double AverageAge(Animal[] arr)

        {
            return arr.Average(x => x.Age);
        }

        public string Hunt()
        {
            return string.Format("{0} is hunting", this.Name);
        }

        public abstract void MakeSound();
    }
}
