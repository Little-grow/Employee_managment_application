using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class CommissionEmployee:Employee
    {
        public double Target { get; set; }

        public override double Pay()
        {
            return 0.05 * Target;
        }
    }
}
