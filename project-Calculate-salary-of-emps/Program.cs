namespace project_Calculate_salary_of_emps
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager()
            {
                emp_id = 101,
                emp_name = "John Doe",
                loggedHours = 180,
                wage = 10.0
            };
            Console.WriteLine(m.ToString());
        }
    }
}
