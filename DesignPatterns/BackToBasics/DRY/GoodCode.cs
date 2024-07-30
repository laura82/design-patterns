using System.Collections.Generic;
using System.Linq;

namespace BackToBasics.DRY
{
    public class BillService
    {
        TaxHelper _taxHelper = new TaxHelper();
        public double CalculateBill(List<double> prices)
        {
            var totalPrice = prices.Sum();
            var tax = _taxHelper.CalculateTax(totalPrice);
            return totalPrice + tax;
        }
    }

    public class WageService
    {
        TaxHelper _taxHelper = new TaxHelper();
        public double CalculateWages(double hourlyRate, int hoursWorked)
        {
            var totalWage = hourlyRate * hoursWorked;
            var tax = _taxHelper.CalculateTax(totalWage);
            return totalWage - tax;
        }
    }

    public class TaxHelper
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.2;
        }
    }
}
