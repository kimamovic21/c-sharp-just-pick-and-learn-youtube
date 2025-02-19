namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Payment Method: ");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. Upi Payment");
            Console.WriteLine("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            Payment payment = null;

            Console.Write("Enter payment amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Create appropriate payment object based on user choice
            switch (choice)
            {
                case 1:
                    payment = new CreditCardPayment();
                    break;
                case 2:
                    payment = new UpiPayment();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Process the payment
            payment.ProcessPayment(amount);

            // Show common transaction details
            payment.PrintDetails(amount);

            Console.WriteLine("Payment completed successfully!");

            Console.ReadKey();
        }
    }
}