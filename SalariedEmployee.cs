using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class SalariedEmployee:Employee
    {
        public double Salary { get; set; }

        public override double Pay()
        {
            return Salary;
        }
    }
}
