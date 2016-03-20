namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW4.Interface;

    public abstract class People : IComment
    {
        private string firstName;
        private string lastName;

        public People(string firstName, string lastName)
        {
        this.FirstName = firstName;
        this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Insert your first name");
                }
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get { return this.lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Insert your last name");
                }
                this.lastName = value;
            } 
        }

        public List<string> Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
