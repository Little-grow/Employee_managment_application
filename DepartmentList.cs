namespace Employee_Management_Application
{
    class DepartmentList
    {
        static List<Department> departments = new List<Department>();
        public static void AddDepartment()
        {
            Department department = new Department();
            departments.Add(department);
        }

        public static void Print()
        {
            for (int i = 0; i < departments.Count; i++)
            {
                departments[i].Print();
            }
        }
    }
}
