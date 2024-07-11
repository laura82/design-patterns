using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    // Here we use an ISalaryCalculator interface to allow decoupling between the SalaryCalculator and StaffRecord classes.
    // The staff record class no longer directly depends on the salary calculator.
    public interface ISalaryCalculator
    {
        double CalculateSalary(int hoursWorked, double hourlyWage);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(int hoursWorked, double hourlyWage) => hoursWorked * hourlyWage;
    }

    public class StaffRecord
    {
        private readonly ISalaryCalculator _salaryCalculator;

        public int HoursWorked { get; set; }
        public double HourlyWage { get; set; }

        // Using Dependency Injection in the constructor of the class.
        public StaffRecord(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public double GetSalary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyWage);
        }
    }
}
