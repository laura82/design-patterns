namespace SOLID.OpenClosedPrinciple
{
    // Here we create an abstract base class which contains the CalculateDiscountedBill method which will be overridden in the classes that inherit from it.
    public abstract class CustomerBase
    {
        public abstract double CalculateDiscountedBill(double billAmount);
    }

    public class StandardCustomer : CustomerBase
    {
        public double DiscountMultiplier { get; set; } = 1;

        public override double CalculateDiscountedBill(double billAmount)
        {
            return billAmount * DiscountMultiplier;
        }
    }

    public class StaffCustomer : CustomerBase
    {
        public double DiscountMultiplier { get; set; } = 0.05;

        public override double CalculateDiscountedBill(double billAmount)
        {
            var discount = billAmount * DiscountMultiplier;
            return billAmount - discount;
        }
    }

    public class StudentCustomer : CustomerBase
    {
        public double DiscountMultiplier { get; set; } = 0.1;

        public override double CalculateDiscountedBill(double billAmount)
        {
            var discount = billAmount * DiscountMultiplier;
            return billAmount - discount;
        }
    }
}
