namespace project_Calculate_salary_of_emps
{
    public class Manager : EMP
    {
        
        public const double Allowns = 0.05;
        public override double CalculateSalary()
        {
            return base.CalculateSalary() + Allowns * base.CalculateSalary();
        }

        private double CalculateAllowance()
        {
            return Allowns * base.CalculateSalary();
        }

        protected override double Calculate()
        {
            return base.CalculateSalary() + CalculateAllowance();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nAllowance: ${Math.Round(CalculateAllowance(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }

    }



}
