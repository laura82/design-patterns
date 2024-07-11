namespace SOLID.LiskovSubstitutionPrinciple
{
    // Here we add a new class called StaffManager and inherit from the Staff class (which in turn inherits from the CustomerBase).
    // The StaffManager has all the properties and functionality of the Staff class but we can now add to it to allow our double discounted rate.
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

    public class Staff : CustomerBase
    {
        public double DiscountMultiplier { get; set; } = 0.05;

        public override double CalculateDiscountedBill(double billAmount)
        {
            var discount = billAmount * DiscountMultiplier;
            return billAmount - discount;
        }
    }

    public class StaffManager : Staff
    {
        public override double CalculateDiscountedBill(double billAmount)
        {
            var discount = billAmount * (DiscountMultiplier * 2);
            return billAmount - discount;
        }
    }

    public class Student : CustomerBase
    {
        public double DiscountMultiplier { get; set; } = 0.1;

        public override double CalculateDiscountedBill(double billAmount)
        {
            return billAmount * DiscountMultiplier;
        }
    }
}
