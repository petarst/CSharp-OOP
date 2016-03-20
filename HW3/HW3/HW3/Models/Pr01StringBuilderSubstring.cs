
namespace HW3
{
    using System;
    using System.Text;
    using HW3.Models;

    // Problem 1. StringBuilder.Substring
    // Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
    // and has the same functionality as Substring in the class String.
    public class Pr01StringBuilderSubstring
    {
        public static void Main()
        {
            string test = "Hello, anybody here?";

            var sb = new StringBuilder(test);

            Console.WriteLine(sb.SubstringBuilder(9));

            Console.WriteLine(sb.StringBuilder1(3,5));
        }
    }
}
