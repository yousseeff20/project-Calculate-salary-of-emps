namespace project_Calculate_salary_of_emps
{
    public class sales : EMP
    {
        public const double commissionRate = 0.1;
        public double salesAmount { get; set; }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + (commissionRate * salesAmount);
        }

        private double CalculateCommission()
        {
            return commissionRate * salesAmount;
        }

        protected override double Calculate()
        {
            return base.CalculateSalary() + CalculateCommission();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nCommission: ${Math.Round(CalculateCommission(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
