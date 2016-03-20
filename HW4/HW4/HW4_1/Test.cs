using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW4_1.Models;

namespace HW4_1
{
    class Test
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
            new Student("Ivan","Ivanov",8),
            new Student("Asen","Petrov",10),
            new Student("Borislav","Mihaylov",10),
            new Student("Vaklin","Dimitrov",11),
            new Student("Georgi","Geshev", 8),
            new Student("Dian","Peev",9),
            new Student("Evlogi","Peshev",11),
            new Student("Jivko","Ilarionov",12),
            new Student("Zahari","Ignatov",10),
            new Student("Kuncho","Perukov",11)
            };

            var workers = new List<Worker>()
            {
                new Worker ("Angel", "Georgiev",200.0m,8),
                new Worker ("Boyko", "Damianov",300.0m,5),
                new Worker ("Valeri", "Jorev",500.0m,8),
                new Worker ("Gavril", "Pashov",400.0m,8),
                new Worker ("Dido", "Baykushev",300.0m,3),
                new Worker ("Erdjan", "Mustafa",600.0m,4),
                new Worker ("Joro", "Pipkov",100.0m,1),
                new Worker ("Zahra", "Emfizem",450.0m,6),
                new Worker ("Mimo", "Makariev",300.0m,3),
                new Worker ("Orhan", "ivanov",200.0m,8)
            };

            var sortedByGrade = students.OrderBy(x => x.Grade);

            Console.WriteLine("Students ordered by ascending grades:");
            foreach (var item in sortedByGrade)
            {
                Console.WriteLine("{0, -7}, {1, -8}, {2}", item.FirstName, item.LastName, item.Grade);
            }
            Console.WriteLine();


            var sortBySalary = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Worker ordered by descending money per hour: ");
            foreach (var item in sortBySalary)
            {
                Console.WriteLine("{0,-9},{1,-10},{2:C}", item.FirstName, item.LastName, item.MoneyPerHour());
            }
            Console.WriteLine();

            var concatGroup = sortedByGrade.Concat<Human>(sortBySalary).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine("Both groups concatenated and sorted by names:");
            foreach (var item in concatGroup)
            {
                Console.WriteLine("{0, -9}, {1, -10}", item.FirstName,item.LastName);
            }

        }
    }
}
