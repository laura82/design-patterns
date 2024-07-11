namespace SOLID.DependencyInversionPrinciple.BadCode
{
    // We are calculating salaries here - this violates the Dependency Inversion Principle because the StaffRecord class directly depends on the SalaryCalculator class
    public class SalaryCalculator
    {
        public double CalculateSalary(int hoursWorked, double hourlyWage) => hoursWorked * hourlyWage;
    }

    public class StaffRecord
    {
        public int HoursWorked { get; set; }
        public double HourlyWage { get; set; }
        public double GetSalary()
        {
            var salaryCalculator = new SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyWage);
        }
    }
}
