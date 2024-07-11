namespace SOLID.InterfaceSegregationPrinciple
{
    // We have two separate interfaces that reflect the waiting staff duties and the additional managerial responsibility of handling complaints
    public interface IStaff
    {
        void ServeFood();
        void CleanTable();
        void WashUp();
    }

    public interface IStaffManager
    {
        void HandleComplaint();
    }

    // We now have two services to handle waiting staff logic and the managerial logic.
    // The Waiting Staff Service will only implement the IStaff interface
    public class WaitingStaffService : IStaff
    {
        public void ServeFood()
        {
            // Serve the food
        }

        public void CleanTable()
        {
            // Clean the table
        }

        public void WashUp()
        {
            // Wash the pots
        }
    }

    // The Staff Manager Service implements BOTH interfaces
    public class StaffManagerService : IStaff, IStaffManager
    {
        public void ServeFood()
        {
            // Serve the food
        }

        public void CleanTable()
        {
            // Clean the table
        }

        public void WashUp()
        {
            // Wash the pots
        }

        public void HandleComplaint()
        {
            // Handle the complaint
        }
    }
}
