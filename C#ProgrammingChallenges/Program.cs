namespace FindStringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to find length of a string \n");

            // Step 1 - Take the input from a user
            Console.WriteLine("Enter a string");
            string inputString = Console.ReadLine();

            // Step 2 - Determine the length using Length property of a string
            int length = inputString.Length;

            // Step 3 - Print the length on the console window
            Console.WriteLine($"The length of the string is: {length}");
                
            Console.ReadKey();
        }
    }
}