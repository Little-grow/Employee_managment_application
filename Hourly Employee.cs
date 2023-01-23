using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Hourly_Employee: Employee
    {
        public double HoursWorked { get; set; }
        public double Rate { get; set; }

        public void AddHours(int moreHours)
        {
            HoursWorked += moreHours;
        }

        public override double Pay()
        {
            return Rate * HoursWorked;
        }
    }
}
