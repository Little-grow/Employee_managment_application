namespace Employee_Management_Application
{
    class BudgetsList
    {
        static List<Budget> budgets = new List<Budget>();

        public static void AddBudget()
        {
            Budget budget = new Budget();
            budgets.Add(budget);
        }
        public static Budget? SearchID(int id)
        {
            for (int i = 0; i < budgets.Count; i++)
            {
                if (budgets[i].Id == id)
                {
                    return budgets[i];
                }
            }
            return null;
        }
    }
}
