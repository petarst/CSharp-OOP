using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3_9.Models
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fNumber;
        private string phoneNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student()
        {

        }
        public Student(string firstName, string lastName, string fNumber, string phoneNumber, string email, List<int> marks, int groupNumber)
            :this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FNumber = fNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set {
                if (value == null || value<=0)
                {
                    throw new ArgumentException(" Students group number cannot be null or zero or less than zero.");
                }
                
                this.groupNumber = value; 
            }
        }
        

        public List<int> Marks
        {
            get { return this.marks; }
            private set 
            {   
                this.marks = value; 
            }
        }
        

        public string Email
        {
            get { return this.email; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student must be have an email.");
                }
                this.email = value; 
            }
        }
        

        public string PhoneNumber
        {
            get { return phoneNumber; }
           private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student must be have a phone number.");
                }
                phoneNumber = value; 
            }
        }
        
        public string FNumber
        {
            get { return fNumber; }
           private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student must be have a F number.");
                }
                fNumber = value; 
            }
        }
        

        public string LastName
        {
            get { return lastName; }
           private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student must be have a last name.");
                }  
                lastName = value; 
            }
        }
        

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every student must be have a first name.");
                }
                firstName = value; 
            }  
        }

        public Group Group { get; private set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        
    }
}
