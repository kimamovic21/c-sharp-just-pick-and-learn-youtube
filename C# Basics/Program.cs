namespace Constants_Overview
{
    internal class Program
    {
        // Declare constants
        public const double Rate = 2.0;
        //Rate = 3.0;

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest Calculator");

            Console.WriteLine("Enter the principle amount: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principle * time * Rate) / 100;
            Console.WriteLine("Simple Interest: " + simpleInterest);
            Console.ReadLine();
        }
    }
}    