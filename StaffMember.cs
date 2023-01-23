using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class StaffMember 
    {
        private string? email;
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }

        public string? Email { get; set; }

        public override string ToString()
        {
            string info = "";
            info += $"Emplpoyee: {Name}";
            info += $"Phone: {Phone}";
            info += $"Email: {email}";
            info += $"Id: {EmployeeId}";
            return info;
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        // I don't know if this is clean code
        public virtual double Pay()
        {
            double salary = 0.0;
            return salary;
        }
    }
}
