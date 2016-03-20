
namespace HW3_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW3_6.Models;

    //Problem 6. Divisible by 7 and 3
   //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
   //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
   public class Test
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Result from Lambda expression:");

            PrintResult(Range.LambdaExpressionResult(arr));

            Console.WriteLine();

            Console.WriteLine("Result from using Linq:");

            PrintResult(Range.LinqResult(arr));

        }

        public static void PrintResult(IEnumerable<int> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
    }
}
