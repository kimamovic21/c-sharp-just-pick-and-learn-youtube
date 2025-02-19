namespace AbstractClassDemo
{
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Credit Card Payment...");
            Console.WriteLine($"Charged ${amount} to Credit Card.");
        }
    }
}