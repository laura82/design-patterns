namespace SOLID.InterfaceSegregationPrinciple.BadCode
{
    // We have an interface that includes the duties of a staff member.
    // This violates the Interface Segregation Principle because only a manager handles the complaints.
    // To resolve this we separate into two separate interfaces.
    public interface IStaff
    {
        void ServeFood();
        void CleanTable();
        void WashUp();
        void HandleComplaint();
    }
}
