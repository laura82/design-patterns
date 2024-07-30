using System.Collections.Generic;
using System.Linq;

namespace BackToBasics.DRY
{
    public class BadCode
    {
        public double CalculateBill(List<double> prices)
        {
            var totalPrice = prices.Sum();
            var tax = totalPrice * 0.2;
            return totalPrice + tax;
        }

        public double CalculateWages(double hourlyRate, int hoursWorked)
        {
            var totalWage = hourlyRate * hoursWorked;
            var tax = totalWage * 0.2;
            return totalWage - tax;
        }
    }
}
