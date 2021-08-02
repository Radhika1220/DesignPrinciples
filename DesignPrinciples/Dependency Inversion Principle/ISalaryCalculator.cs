using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public interface ISalaryCalculator
    {
        double CalculateSalary(int hoursWorked, double hourlyRate);
    }
}
