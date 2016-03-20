/*Problem 4. Person class

Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() 
to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.

*/
namespace Problem_4.Person_class
{
    using System;

    public class Test
    {
        static void Main()
        {
            var person = new Person("Kiro Ivanov", 43);
            Console.WriteLine(person);

            var otherPerson = new Person("Ivan Bikov");

            Console.WriteLine(otherPerson);
        }
    }
}
