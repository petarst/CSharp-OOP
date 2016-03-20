/*
 * Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
 * mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

*/
namespace HW6
{
    using System;
    using HW6.Models;

    public class StudentClass
    {
        static void Main()
        {
            var student = new Student
                (
                "Ivan", "Kirov", "Petrov", "124365", "12 Porova livada", "0888321122", "opb@acx.fd", 
                "Software eng.", Enum.Speciality.Mathematics, Enum.University.SoftUni, Enum.Faculty.SF
                );
            Console.WriteLine(student.ToString());

            var otherStudent = student.Clone();

            Console.WriteLine();

            Console.WriteLine(otherStudent);
        }
    }
}
