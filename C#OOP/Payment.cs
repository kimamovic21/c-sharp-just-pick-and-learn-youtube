namespace AbstractClassDemo
{
    public abstract class Payment
    {
        // Abstract method
        public abstract void ProcessPayment(double amount);

        // Concrete method
        public void PrintDetails(double amount)
        {
            Console.WriteLine($"Transaction Amount: ${amount}");
            Console.WriteLine($"Transaction Date: {DateTime.Now}");
        }
    }
}