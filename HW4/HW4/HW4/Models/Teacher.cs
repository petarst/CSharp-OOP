namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : People
    {
        private List<Disciplines> teachersDisciplines;

        public Teacher(string firstName, string lastName, params Disciplines [] teachersDisciplines)
            : base (firstName,lastName)
        {
            this.teachersDisciplines = new List<Disciplines>();
            this.TeachersDisciplines.AddRange(teachersDisciplines);
        }

        public List<Disciplines> TeachersDisciplines 
        {
            get { return new List<Disciplines>(this.teachersDisciplines); }
           
        }

        public void AddDiscipline(Disciplines disc)
        {
            this.TeachersDisciplines.Add(disc);
        }

        public void RemoveDiscipline(Disciplines disc)
        {
            this.TeachersDisciplines.Remove(disc);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Teacher name: " + base.FirstName + " " + base.LastName);
            sb.AppendLine("Teachers disciplines: ");
            sb.AppendLine(string.Join(", ", TeachersDisciplines));

            return sb.ToString();
        }
    }
}
