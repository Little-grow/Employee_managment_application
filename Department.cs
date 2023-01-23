using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Department
    {
        public int DeparId { get; set; }
        public string? DepartName { get; set; }

        public Department()
        {
            Console.WriteLine("Enter Depart details");
            Console.WriteLine("Enter ID");
            DeparId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            DepartName = Console.ReadLine();
        }
       
        public override string ToString()
        {
            string info = "";
            info += $"Deaprtment Id: {DeparId}";
            info += $"Department Name: {DepartName}";
            return info;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }

    }
}
