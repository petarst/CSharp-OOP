using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4_1.Models
{
    class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int worksHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorksHoursPerDay = worksHoursPerDay;
        }


        public decimal WeekSalary { get; private set; }

        public int WorksHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {

            return this.WeekSalary / this.WorksHoursPerDay;
        
        }
    }
}
