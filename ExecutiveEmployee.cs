using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class ExecutiveEmployee:SalariedEmployee
    {
        public double Bouns { get; set; }

        public void AddBouns(double moreBouns)
        {
            Bouns += moreBouns;
        }

        public override double Pay()
        {
            return Salary + Bouns;
        }
    }
}
