

namespace _01.MobilePhone
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
           
            Battery myBattery = new Battery("Bosh");

           

            myBattery.HoursIdle = 23;
            myBattery.HoursTalk = 45;

            Console.WriteLine(myBattery.Model);
            Console.WriteLine(myBattery.HoursIdle);
            Console.WriteLine(myBattery.HoursTalk);

            Display myDisplay = new Display();

            myDisplay.Colors = 1244443;

            Console.WriteLine(myDisplay.Colors);

            Model myPhone = new Model();

            myPhone.Models = "NOKIA";

            Console.WriteLine(myPhone.Models);

            Owner newOwner = new Owner("FRODO");

            Console.WriteLine(newOwner.Owner);

            var priceNewMobile = new Price(100.25);

            

            Console.WriteLine(priceNewMobile.Price);
            
        }
    }
}
