namespace project_Calculate_salary_of_emps
{
    public class  Developer : EMP
    {
        public bool TaskCompleted { get; set; }

        public const double Bonus = 0.03;

        
        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            if (TaskCompleted)
            {
                return baseSalary + (Bonus * baseSalary);
            }
            return baseSalary;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nBonus: ${(TaskCompleted ? Math.Round(Bonus * base.CalculateSalary(), 2) : 0):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateSalary(), 2):N0}";
        }

    }


}
