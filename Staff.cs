using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Staff
    {
        readonly static List<StaffMember> staffList = new List<StaffMember>();


        static Employee CreateHourlyEmployee()
        {
            Hourly_Employee hourly_Employee = new Hourly_Employee();
            return hourly_Employee;
        }

        static Employee CreateSalaryEmployee()
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee();
            return salariedEmployee;
        }

        static Employee CreateComissionEmployee()
        {
            CommissionEmployee commissionEmployee = new CommissionEmployee();
            return commissionEmployee;
        }

        static Employee CreateExecutiveEmployee()
        {
            ExecutiveEmployee executiveEmployee = new ExecutiveEmployee();
            return executiveEmployee;
        }
        // I have a problem with the 3 pre functions 

        public static void calcPayroll()
        {
            double totalPay = 0.0;
            for (int i = 0; i < staffList.Count; i++)
            {
                totalPay += staffList[i].Pay();
            }
            Console.WriteLine("Total pay is ", totalPay); 
        }

        static Dictionary<int, Func<Employee>> employeeType = new Dictionary<int, Func<Employee>>
        {
            {2, CreateHourlyEmployee },
            {3, CreateSalaryEmployee },
            {4, CreateComissionEmployee},
            {5, CreateExecutiveEmployee}
        };

        public static void EnterVolunteerDetails()
        {
            Volunteer volunteer = new Volunteer();
            Console.WriteLine("Enter your name");
            volunteer.Name = Console.ReadLine();
            Console.WriteLine("Enter ID");
            volunteer.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone");
            volunteer.Phone = Console.ReadLine();
            Console.WriteLine("Enter Email");
            volunteer.Email = Console.ReadLine();
            Console.WriteLine("Done!");
            staffList.Add(volunteer);
        }

        public static void AddMemeber()
        {
            Console.WriteLine("you should enter member details");
            Console.WriteLine("What is member type?");
            Console.WriteLine("1. volunteer 2. Hourly  3. Salaried  4. commission 5. Eecutive");
            int type;
            bool ok = int.TryParse(Console.ReadLine(),out type);
            if (type == 1)
            {
                EnterVolunteerDetails();
                return;
            }
            if (ok && type != 1)
            {
                Employee emp = employeeType[type]();
                Console.WriteLine("Enter Employee details");
                Console.WriteLine("Enter name");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter phone");
                emp.Phone = Console.ReadLine();
                Console.WriteLine("Enter Id");
                emp.EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter email in right format");
                emp.Email = Console.ReadLine();
                Console.WriteLine("Enter Social Security number");
                emp.SocialSecurityNumber = Console.ReadLine();
                Console.WriteLine("Done!");
                staffList.Add(emp);
            }
       
        }

        public static void DeleteMember()
        {
            Console.WriteLine("Enter your ID");
            int id;
            bool ok = int.TryParse(Console.ReadLine(), out id);
            int idx;
            if (ok && SearchID(id,out idx))
            {
                staffList.RemoveAt(idx);
                Console.WriteLine("Done!");
            }
            Console.WriteLine("Try Again!");
        }

        static bool SearchID(int id, out int index)
        {
            for (int i = 0; i < staffList.Count; i++)
            {
                if (staffList[i].EmployeeId == id)
                {
                    index = i;
                    return true;
                }
            }
            index = int.MaxValue;
            return false;
        }

        public static void ShowAll()
        {
            for (int i = 0; i < staffList.Count; i++)
            {
                staffList[i].Print();
            }
        }
    }
}
