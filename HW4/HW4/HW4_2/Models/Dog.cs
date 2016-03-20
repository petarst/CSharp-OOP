
namespace HW4_2.Models
{
    using System;

    public class Dog: Animal
    {
        public Dog(string name, int age, bool isMale)
            : base (name, age, isMale)
        {

        }

        public string Fetch()
        {
            return string.Format("{0} is fetching a bone", this.Name);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
