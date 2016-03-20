//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace HW3_17
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Test
    {
        public static string FindLongestString(IEnumerable<string> arr)
        {
            return arr.OrderByDescending(x => x.Length).First();
        }

        static void Main()
        {
            string[] stringArray = new string[]
            {
            "This string is short.",
            "I think, that is my mine.",
            "Please, think againe, are you shure?",
            "This is the logest string, because it have at most words."
            };

            var result = FindLongestString(stringArray);

            Console.WriteLine(result);
        }
    }
}
