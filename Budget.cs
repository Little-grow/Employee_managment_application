using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Budget
    {
        public int Id { get; set; }
        public double value{ get; set; }

        public Budget()
        {
            Console.WriteLine("the Id of budegt ?");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("the defined amount ?");
            value = double.Parse(Console.ReadLine());
        } 
        public void IncreaseBudget()
        {
            Console.WriteLine("enter the amount");
            double amount = double.Parse(Console.ReadLine());
            value += amount;
            Console.WriteLine("Done!");
        }

    }
}
