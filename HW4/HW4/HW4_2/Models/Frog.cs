using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4_2.Models
{
    public class Frog: Animal
    {
        public Frog(string name, int age, bool isMale)
            : base (name, age, isMale)
        {

        }

        public string JumpArround()
        {
            return string.Format("{0} is jumping arround", this.Name);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kwak, Kvak");
        }
    }
}
