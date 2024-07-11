using System;

namespace SOLID.OpenClosedPrinciple.BadCode
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Type { get; set; }

        // This violates the open closed principle because if we add another discount (e.g. manager) we will need to modify this class to accomodate the new type.
        public double CalculateDiscountedBill(double billAmount)
        {
            if (this.Type == "Student")
            {
                return billAmount * 0.9;
            }
            if (this.Type == "Staff")
            {
                return billAmount * 0.95;
            }
            return billAmount;
        }

    }
}
