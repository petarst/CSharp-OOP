
//Problem 18. Grouped by GroupNumber
//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.
namespace HW3_18
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW3_18.Models;

   public class Test
    {
        static void Main()
        {
            var students = new List<Student> 
            {
                new Student("Ivan", "Economics"),
                new Student("Raina", "Computer science"),
                new Student ("Gosho", "Computer science"),
                new Student ("Nalum", "Economics")
            
            };

            var orderedStudent =                    // problem 19
                from st in students
                orderby st.Group
                select st;

            

            foreach (var item in orderedStudent)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var orderedStudents1 = students.OrderBy(x => x.Group); // problem 18

            foreach (var item in orderedStudents1)
            {
                Console.WriteLine(item);
            }
            

          
        }
    }
}
