namespace PrimeNumbers
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Print the prime numbers \n");

            // Step 1: Ask the user to enter the limit
            Console.WriteLine("Please enter the limit:");
            int limit = int.Parse(Console.ReadLine());

            // Step 2: Loop through all the numbers within the limit and check if a number is prime 
            for (int i = 2; i < limit; i++)
            {
                bool isPrimeNumber = true;

                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                // Step 3: Print if it is a prime number
                if (isPrimeNumber)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.ReadKey();
        }
    }
}