using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class System
    {
        static void Menu()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Hello, to our employee management app\n");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Dpartment");
            Console.WriteLine("2. Staff");
            Console.WriteLine("3. Project");
            Console.WriteLine("0. Exit");
        }

        static void DepartmentChoices()
        {
            Console.WriteLine("1. Add new Department");
            Console.WriteLine("2. Print all department");
        }

        static void StaffChoices()
        {
            Console.WriteLine("1. Add new members");
            Console.WriteLine("2. Print all members");
            Console.WriteLine("3. Calculate payroll");
            Console.WriteLine("4. Delete member");
        }

        static void ProjectChoices()
        {
            Console.WriteLine("1. Add new project");
            Console.WriteLine("2. Print all projects");
            Console.WriteLine("3. Add budget to existing project");
            Console.WriteLine("4. Increase budget to existing project");
        }

        static void Close()
        {
            Environment.Exit(1);
        }

        static Dictionary<int, Action> section = new Dictionary<int, Action>
        {
            {0, Close},
            {1, DepartmentChoices},
            {2, StaffChoices},
            {3, ProjectChoices}
        };

        static Dictionary<int, Action> DepartmentOptions = new Dictionary<int, Action>
        {
            {1, DepartmentList.AddDepartment},
            {2, DepartmentList.Print }
        };

        static Dictionary<int, Action> StaffOptions = new Dictionary<int, Action>
        {
            {1, Staff.AddMemeber },
            {2, Staff.ShowAll },
            {3, Staff.calcPayroll },
            {4, Staff.DeleteMember}
        };

        static Dictionary<int, Action> ProjectOptions = new Dictionary<int, Action>
        {
            {0, ProjectsList.AddNewProject },
            {1, ProjectsList.PrintAllProjects },
            {2, ProjectsList.AddBudegtToExixtingProject },
            {3, ProjectsList.IncreaseBudgetToExisitingProject}
        };

        static Dictionary<int, Dictionary<int, Action>> pairs = new Dictionary<int, Dictionary<int, Action>>
        {
            {1,DepartmentOptions},
            {2, StaffOptions},
            {3,ProjectOptions}  
        };
        public static void Run()
        {
            Menu();
            int choice = -1;
            while(choice != 0)
            { 
                bool ok;
                ok = int.TryParse(Console.ReadLine(), out choice);
                if (ok)
                    section[choice]();

                int option;
                ok = int.TryParse(Console.ReadLine(), out option);

                pairs[choice][option]();
                Console.WriteLine("Great Job!, Enter another choice");
            }
        }
    }
}
