
/*
Problem 1. School classes

We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of disciplines. 
 * Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. 
 * Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. 
 * Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
 * define the class hierarchy and create a class diagram with Visual Studio.
    */
    namespace HW4
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using HW4.Models;

    class Program
    {
        static void Main()
        {
            Student looser = new Student("Ivan", "Petrov", 5);

            Console.WriteLine("Student name is {0}, class number {1}", looser.ToString(), looser.ClassNumber);

            Teacher firstTeacher = new Teacher ("Hloran", "Aminiakov", new Disciplines("Math", 20, 10), new Disciplines ("Phisics", 12, 14));

            Console.WriteLine(firstTeacher.ToString());

            Teacher secondTeacher = new Teacher ("Sutien", "Prashkov", new Disciplines ("Geography", 34, 12), new Disciplines("History", 23,34));

           //School newSchool = new School(
           //    new Class ("12A", firstTeacher),
           //    new Class ("3B", secondTeacher));

        }
    }
}
