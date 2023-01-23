using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string? Location { get; set; }
        int ManagerID;
        public double currentCost { get; set; }
        Budget budget;

        public Project()
        {
            Console.WriteLine("Enter project Id");
            ProjectId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Location");
            Location = Console.ReadLine();
            Console.WriteLine("Enter Manager ID");
            ManagerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter project Pudget");
            budget = new Budget();
        }

        public void AddBudget(double value)
        {
            budget.value = value;
        }

        public void IncreaseBudget()
        {
            if (budget is not null)
                budget.IncreaseBudget();
            else
                Console.WriteLine("Try again!");
        }
        public override string ToString()
        {
            string info = "";
            info += $"Project Id: {ProjectId}";
            info += $"Project location: {Location}";
            info += $"Manager ID: {ManagerID}";
            info += $"Current Cost: {currentCost}";
            info += $"Buget List: {budget}";
            return info;
        }

        public void Print()
        {
            Console.WriteLine(ToString()+'\n');
        }
    }
}

