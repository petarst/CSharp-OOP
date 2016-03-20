using System;


namespace test
{
    class Test
    {
        static void Main(string[] args)
        {
            Person firstViliger = new Person();
            firstViliger.Name = "Ivan";

            Console.WriteLine(firstViliger.Name);

            Person secondViliger = new Person();

            secondViliger.Name = "Kiro";

            Console.WriteLine(secondViliger.Name);
        }
    }
}
