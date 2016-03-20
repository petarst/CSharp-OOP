namespace HW3_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using HW3_3.Models;

    // Problem 3. First before last
    // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    // Use LINQ query operators.

    public class Program
    {

        public static void Main()
        {
            Students[] group1 = new Students[]
             {
             new Students("Ivan", "Ivanov", 23),
             new Students("Anastasi", "Bukov", 21),
             new Students("Pehlivan", "Meckarov", 29),
             new Students("Marko", "Kralev", 38),
             new Students("Vasil", "Krupkov", 58),
             new Students("Boiran", "Djidjilov", 25),
             new Students("Ceka", "Urvenska", 18),
             new Students("Jivka", "Svirchevska", 22),
             new Students("Dashna", "Neotkazna", 23),
             new Students("Ivan", "Petrov", 23),
             new Students("Radka", "Kufleva", 27)

       };

            foreach (var item in group1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Students whose first name is before their last name");

            Print(SortByFirstName(group1));
            Console.WriteLine();
            Print(SortByAge(group1));
            Console.WriteLine();
            Print(SortNamesByDescending(group1));

}
        
         
         
           //Problem 3
      public static IEnumerable<Students> SortByFirstName(IEnumerable<Students> studentCollection)
      {
              var sorted1 =
              from st in studentCollection
              where st.FirstName.CompareTo(st.LastName) == -1
              orderby st.FirstName
              select st;
              return sorted1;
      }

        // Problem 4
      public static IEnumerable<Students> SortByAge(IEnumerable<Students> studentCollection)
   {
        //var sortedAge = studentCollection.Where(st => st.Age >= 18 && st.Age <= 25);
     
       var sortedAge1 =
           from st in studentCollection
           where st.Age >= 18 && st.Age <= 25
           orderby st.Age
           select st;
       return sortedAge1;
     }

        //Problem 5

      public static IEnumerable<Students> SortNamesByDescending(IEnumerable<Students> studentCollection)
 {
     //var descentingSort = studentCollection.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
 
     var descentingSort1 =
         from st in studentCollection
         orderby st.FirstName descending, st.LastName descending
         select st;
     return descentingSort1;
 
     
 }
  public static void Print(IEnumerable<Students> students)
  {
      foreach (var item in students)
      {
          Console.WriteLine(item);
      } 
  }  
 }
}

