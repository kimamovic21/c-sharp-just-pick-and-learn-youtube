namespace ConcatenateTwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to join two strings \n");

            // Step 1: Take the input
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine();

            // Step 2: Concatenate the strings
            string str3 = string.Concat(str1, str2);

            // Step 3: Print the output
            Console.WriteLine($"Your concatenated string: {str3}");

            Console.ReadKey();
        }
    }
}