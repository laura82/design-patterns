namespace SOLID.SingleResponsibilityPrinciple.BadCode
{
    // This violates the Single Responsibility Principle because it has multiple responsibilities.
    // The GenerateReceipt method doesn't need to know about the PrintReceipt method and vice versa.
    class ReceiptService
    {
        public void GenerateReceipt()
        {
            // Generate the customer's receipt
        }

        public void PrintReceipt()
        {
            // Print the customer's receipt
        }
    }
}
