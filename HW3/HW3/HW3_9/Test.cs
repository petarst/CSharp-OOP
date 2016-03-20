
//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.

//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.

//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.

//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.

//Problem 14. Extract students with two marks
//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

//Problem 15. Extract marks
//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

//Problem 16.* Groups
//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.

namespace HW3_9
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using HW3_9.Models;

    public class Test
    {
                    //Problem 16- method
        public static void SortByMathematicsDepartment(IEnumerable<Student> studentsGroup, IEnumerable<Group> groups)
        {
            var sorted =
                from st in studentsGroup
                join gr in groups on st.GroupNumber equals gr.GroupNumber
                where gr.GroupNumber == 10
                select st;

            Console.WriteLine("Students from Mathematical Department:");
            PrintStudent(sorted);
        }
                // Problem 15
        public static void SortBySigningIn2006(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.FNumber.EndsWith("06")
                select st;

            Console.WriteLine("Marks of students enrolled in 2006");

            foreach (Student student in sorted)
            {
                Console.WriteLine(student.ToString()+"["+string.Join(", ", student.Marks)+"]");
            }
            Console.WriteLine();
        }
                    //Problem 14
        public static void SortByAtleastTwoMarks(IEnumerable<Student> studentsGroup)
        {
            var sorted = ExtenssionMetod.ExtensionSortByAtLeastTwoMarks(studentsGroup);

            Console.WriteLine("Student with atleast two marks");

            foreach (var student in sorted)
            {
                Console.WriteLine(student.ToString()+"["+string.Join(", ", student.Marks)+ "]");
            }
            Console.WriteLine(); 
        }
                    //problem 13
        public static void SortByExcelentMark(IEnumerable<Student> studentsGroup)

        {
            var sorted =
                from st in studentsGroup
                where st.Marks.Contains(6)
                select st;

            Console.WriteLine("Student sorted by one 6 mark:");

            foreach (var item in sorted)
            {
                Console.WriteLine(item.FirstName+" "+ item.LastName + "["+string.Join(", ", item.Marks)+"]");
            }
            Console.WriteLine();
        }
                    //Problem 12
        public static void SortByPhoneInSofia(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.PhoneNumber.StartsWith("02")
                select st;

            Console.WriteLine("Students with phone numbers in Sofia:");

            PrintStudent(sorted);
        }
                    //Problem 11
        public static void SortByEmail(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Email.Contains("abv.bg")
                select st;

            Console.WriteLine("Students with e-mail adress in abv.bg");

            PrintStudent(sorted);
        }
                    //Problem 9
        public static void SortByGroup(IEnumerable<Student> studentsGroup)

        {
            var sorted =
                from st in studentsGroup
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            var sorted1 = ExtenssionMetod.ExtensionSortByGroup(studentsGroup); // problem 10

            Console.WriteLine("Student from group 2 ordered by first name");

            PrintStudent(sorted);
            PrintStudent(sorted1);
        }

        public static void PrintStudent(IEnumerable<Student> studentsGroup)

        {
            foreach (Student student in studentsGroup)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            List<Student> groupOfStudents = new List<Student>()
            {
                new Student("Ivan", "Petrov", "012345", "021234566", "dzadziki@abv.bg", new List<int>{3,5}, 2),
                new Student("Damian", "Kirov", "012356","023345456", "idim@abv.bg", new List<int>{2,6}, 10),
                new Student("Petkan", "Ivanov", "012545", "023214566", "aziki@abv.bg", new List<int>{4,4}, 10),
                new Student("Gica", "Mahmudova", "012098", "069874566", "dreziki@abv.bg", new List<int>{3,3}, 10),
                new Student("Eva", "Raih", "012876", "024564566", "fiki@abv.bg", new List<int>{5,5}, 2),
                new Student("Maria", "Berova", "012123", "010984566", "dzadov@abv.bg", new List<int>{2,5}, 2),
                new Student("Elena", "Rozova", "012850", "021233366", "dzabve@abv.bg", new List<int>{6,6}, 10),
                new Student("Ivanka", "Monahinova", "012123", "031223126", "dzoki@abv.bg", new List<int>{3,4}, 2),
                new Student("Emil", "Bradev", "012843", "021234588", "dridziki@abv.bg", new List<int>{4,5}, 2),
                new Student("Kiro", "Peshev", "012597", "021234514", "cheshmiki@abv.bg", new List<int>{3,6}, 10)
                };

                List<Group> groups = new List <Group>()
                {
                new Group(2,"ComputerSciense"),
                new Group(10, "Mathematics")
                };

                SortByGroup(groupOfStudents);
                SortByEmail(groupOfStudents);
                SortByPhoneInSofia(groupOfStudents);
                SortByExcelentMark(groupOfStudents);
                SortByAtleastTwoMarks(groupOfStudents);
                SortBySigningIn2006(groupOfStudents);
                SortByMathematicsDepartment(groupOfStudents, groups);
        }
    }
}
