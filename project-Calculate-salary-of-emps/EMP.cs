using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project_Calculate_salary_of_emps
{
    public class EMP
    {
        // Data members

        public const int MinimumLoggedHours = 176;
        public const double Overtimerate = 1.25;
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public double loggedHours { get; set; }

        public double wage { get; set; }
        // Member functions

        protected virtual double Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }


        private double CalculateBaseSalary()
        {
           double regularHours = Math.Min(loggedHours, MinimumLoggedHours);

            return regularHours * wage;
        }
        private double CalculateOverTime()
        {
            var additionalHours = ((loggedHours - MinimumLoggedHours) > 0 ? loggedHours - MinimumLoggedHours : 0);

            return additionalHours * wage * Overtimerate;
        }

        public virtual double CalculateSalary()
        {
            var additionalHours = loggedHours - MinimumLoggedHours;
            return (wage * MinimumLoggedHours) + ( additionalHours * wage * Overtimerate);
        }

        public override string ToString()
        {
            var type = GetType().ToString().Replace("CAInheritance.", "");
            return $"{type}" +
                   $"\nId: {emp_id}" +
                   $"\nName: {emp_name}" +
                   $"\nLogged Hours: {loggedHours} hrs" +
                   $"\nWage: {wage} $/hr" +
                   $"\nBase Salary: ${Math.Round(CalculateBaseSalary(), 2):N0}" +
                   $"\nOvertime: ${Math.Round(CalculateOverTime(), 2):N0}";
        }

    }

}
