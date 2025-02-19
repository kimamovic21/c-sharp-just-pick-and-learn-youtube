namespace AbstractClassDemo
{
    public class UpiPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing UPI Card Payment...");
            Console.WriteLine($"Transferred ${amount} via GPay.");
        }
    }
}