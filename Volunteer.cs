using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Volunteer: StaffMember
    {
        public double AmountOfMoney { get; set; }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"Amount of money: {AmountOfMoney}";
            return info;
        }

        public override double Pay()
        {
            return AmountOfMoney;
        }
    }
}
