
namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW4.Interface;

    public class Class : IComment
    {
        private string textIdentifier;

        private List<Teacher> teacherSet;

        public Class(string textIdentifier, List<Teacher> teacherSet)
        {
            this.TextIdentifier = textIdentifier;
            this.TeacherSet = new List<Teacher>();
            this.TeacherSet.AddRange(teacherSet);

        }

        public string TextIdentifier 
        {
            get { return this.textIdentifier; }
            private set { this.TextIdentifier = value; } 
        }

        public List<Teacher> TeacherSet { get; set; }

        public List<string> Comment { get; set; }

        public void AddComment(string comment)

        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return "Class " + this.TextIdentifier;
        }
    }
}
