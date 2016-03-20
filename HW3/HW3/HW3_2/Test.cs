
namespace HW3_2
{
    // Problem 2. IEnumerable extensions
    // Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    using System;
    using System.Text;
    using System.Collections;
    using HW3_2.Models;
    using System.Collections.Generic;


    public class Test
    {
        public static void Main()
        {
            IEnumerable<double> numbers = new double[] { 2.0, 3.5, 4.2, 5.1 };

            Console.Write("Collection: ");

            foreach (var item in numbers)
            {
                Console.Write("{0:F2} ", item);
            }
            Console.WriteLine();

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average());
        }

    }
}
