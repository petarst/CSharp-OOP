
namespace HW3_9.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ExtenssionMetod
    {
        public static IEnumerable<Student> ExtensionSortByGroup(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            return sorted;
        }

        public static IEnumerable<Student> ExtensionSortByAtLeastTwoMarks(IEnumerable<Student> studentsMark)
        {
            var sorted = studentsMark.Where(n => n.Marks.Count == 2);

            return sorted;
        }
    }
}
