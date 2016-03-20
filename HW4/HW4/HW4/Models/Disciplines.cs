namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HW4.Interface;

    public class Disciplines : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercise;

        public Disciplines(string name, int numberOfLectures, int numberOfExercise)
        {
            this.Name= name;
            this.NumberOfLectures= numberOfLectures;
            this.NumberOfExercise= numberOfExercise;

        }

        public string Name 
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Insert valid name");
                }

                this.name = value;
            } 
        }

        public int NumberOfLectures 
        {
            get { return this.numberOfLectures; } 
           private set
            {
                if (value <1)
                {
                    throw new ArgumentException("Insert valid number of lecture");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercise 
        {
            get { return this.numberOfExercise;}
            set
            {
                if (value <1)
                {
                    throw new ArgumentException("Insert valid number of exercise");
                }
                this.numberOfExercise = value;
            }
        }

        public List<string> Comment { get; private set; }
        
        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public override string ToString()
        {
            return ("Discipline:" + this.Name);
        }
    }
}
