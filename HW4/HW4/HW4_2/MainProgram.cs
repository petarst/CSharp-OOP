/*

 * Problem 3. Animal hierarchy
 * 
Create a hierarchy Dog , Frog , Cat , Kitten , Tomcat and define useful constructors and methods. Dogs, frogs and
cats are Animals . All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All
animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal
produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method
(you may use LINQ).
*/
namespace HW4_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW4_2.Models;

    class MainProgram
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
            new Dog ("Reks",3, true),
            new Dog ("Barni", 5, true),
            new Dog ("Suzi", 8, false),
            new Dog ("Lasi", 2, false)
            };

            Frog[] frogs = new Frog[]
            {
            new Frog ("Kermit",1,true),
            new Frog ("Gonzo",3,true),
            new Frog ("Kirka",2,false),
            new Frog ("Gicka",5,false),
            };

            Cat[] cats = new Cat[]

            {
                new Cat ("Macka", 2, false),
                new Cat ("Kotio", 1, true),
                new Cat ("Purdita", 5, false),
                new Cat ("Macho", 4, true),
            };

            Kitten[] kittens = new Kitten[] 
            { 
            new Kitten("Puhi",2),
            new Kitten("Juji",1),
            new Kitten("Murka",1),
            };

            Tomcat[] tomcats = new Tomcat[] 
            { 
            new Tomcat ("Alfa", 6),
            new Tomcat ("Lider", 10),
            new Tomcat ("Atlet", 7)
            };

            double dogsAverage = Animal.AverageAge(dogs);
            double catsAverage = Animal.AverageAge(cats);
            double frogsAverage = Animal.AverageAge(frogs);
            double kittensAverage = Animal.AverageAge(kittens);
            double tomcatsAverage = Animal.AverageAge(tomcats);

            Console.WriteLine("Average ages of dogs {0:F2}", dogsAverage);
            Console.WriteLine("Average ages of cats {0:F2}", catsAverage);
            Console.WriteLine("Average ages of frogs {0:F2}", frogsAverage);
            Console.WriteLine("Average ages of kitten {0:F2}", kittensAverage);
            Console.WriteLine("Average ages of tomcats {0:F2}", tomcatsAverage);

            Console.WriteLine(new string('-',10));

            Console.WriteLine("Actions:");

            Console.WriteLine(tomcats[0].Hunt());
            Console.WriteLine(cats[1].BeGracious());
            Console.WriteLine(frogs[1].JumpArround());
            Console.WriteLine(dogs[2].Fetch());

            Console.WriteLine(new string ('-', 10));

            Console.WriteLine("Animal sounds:");

            cats[3].MakeSound();
            dogs[1].MakeSound();
            frogs[2].MakeSound();

        }
    }
}
