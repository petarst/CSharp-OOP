

namespace HW3_9.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group()
        {

        }
        public Group(int groupNumber, string departmentName)
            :this()
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group name cannot be null or empty.");
                }
                departmentName = value; 
            }
        }
        
        public int GroupNumber
        {
            get { return groupNumber; }
            set 
            {
                if (value==null || value <=0)
                {
                    throw new ArgumentException("Group number cannot be null or empty.");
                }
                groupNumber = value; 
            }
        }
        
    }
}
