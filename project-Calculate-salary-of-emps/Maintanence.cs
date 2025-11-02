namespace project_Calculate_salary_of_emps
{
    public class  Maintanence : EMP
    {
        public const double HardShip = 100.00;
        public override double CalculateSalary()
        {
            return (loggedHours * wage) + HardShip;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nHardship: ${Math.Round(HardShip, 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
