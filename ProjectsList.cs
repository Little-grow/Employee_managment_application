namespace Employee_Management_Application
{
    class ProjectsList
    {
        static List<Project> projects = new List<Project>();

       public static void AddNewProject()
        {
            Project project = new Project();
            projects.Add(project);
        }
        
       public static void PrintAllProjects()
        {
            for (int i = 0; i < projects.Count; i++)
            {
                projects[i].Print();
            }
        }

        public static Project? SearchId(int id)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].ProjectId == id)
                {
                    return projects[i];
                }
            }
            return null;
        }
        public static void AddBudegtToExixtingProject()
        {
            Console.WriteLine("Enter project Id");
            int id = int.Parse(Console.ReadLine());
            if (SearchId(id) is not null)
            {
                Console.WriteLine("Enter budget");
                double value = double.Parse(Console.ReadLine());
                SearchId(id).AddBudget(value);
            }
            else
                Console.WriteLine("Project Id Not found!");
        }

        public static void IncreaseBudgetToExisitingProject()
        {
            Console.WriteLine("Enter project Id");
            int id = int.Parse(Console.ReadLine());
            if (SearchId(id) is not null)
            {
                Console.WriteLine("Enter value added");
                double value = double.Parse(Console.ReadLine());
                SearchId(id).AddBudget(value);
            }

        }
    }
}

