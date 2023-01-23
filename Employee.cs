using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Employee: StaffMember
    {
        public string? SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"Social security number: {SocialSecurityNumber}";
            return info;
        }

        public override double Pay()
        {
            return base.Pay();
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
