namespace SOLID.LiskovSubstitutionPrinciple.BadCode
{
    // Here we expand on the previous example but we want to give the manager double the discount of the other staff.
    // This will violate the Liskov Substitution Principle because to do this we will need to modify the CustomerBase to include something to identify a manager (e.g. job title).
    // The StandardCustomer and Student classes will therefore not be able to inherit from CustomerBase.
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
            // Need to find out if staff is a manager or not
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
