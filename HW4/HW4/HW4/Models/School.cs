
namespace HW4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.Classes = new List<Class>();
            this.Classes.AddRange(classes);
        }

        public List<Class> Classes 
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }

        public void AddClass(Class newClass)

        {
            this.Classes.Add(newClass);
        }

        public void RemoveClass(Class oldClass)
        {
            this.Classes.Remove(oldClass);
        }
    }
}
