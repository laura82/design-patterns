namespace SOLID.SingleResponsibilityPrinciple
{
    // Here we separate the two methods into separate classes which handle their own single responsibility
    public class ReceiptGenerator
    {
        public void GenerateReceipt()
        {
            // Generate the receipt
        }
    }

    public class ReceiptPrinter
    {
        public void PrintReceipt()
        {
            // Print the receipt
        }
    }

}
