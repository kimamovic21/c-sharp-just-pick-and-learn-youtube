namespace ExtractSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to extract a substring from a given string \n");

            // Step 1 - Ask the user to enter a string
            Console.WriteLine("Enter the string: ");
            string inputString = Console.ReadLine();

            // Step 2 - Get the starting index
            Console.WriteLine("Enter the starting index: ");
            int startIndex = int.Parse(Console.ReadLine());

            // Step 3 - Get the length of the substring
            Console.WriteLine("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());

            // Step 4 - Extract the substring using Substring method
            if (startIndex >= 0 && startIndex < inputString.Length && length >= 0)
            {
                string extractedSubstring = inputString.Substring(startIndex, length);
                Console.WriteLine("Extracted substring: " + extractedSubstring);
            } 
            else 
            {
                Console.WriteLine("Invalid input. Please make sure the starting index and length are within the bounds of the input string");
            }

            Console.ReadKey();
        }
    }
}