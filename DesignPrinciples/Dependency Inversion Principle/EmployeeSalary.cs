using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class SalaryCalculatorModified : ISalaryCalculator
    {        
        public double CalculateSalary(int hoursWorked, double hourlyRate) => hoursWorked * hourlyRate;
    }

    public class EmployeeDetailsModified
    {
        private readonly ISalaryCalculator salaryCalculator;
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }
        public double GetSalary()
        {
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
