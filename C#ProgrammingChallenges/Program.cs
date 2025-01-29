namespace StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to search for a specific string \n");

            // Step 1: Ask the user to enter main senctence/string
            Console.Write("Please enter main string/sentence: ");
            string mainString = Console.ReadLine();

            // Step 2: Ask the user to enter search string/term
            Console.Write("Enter the string to search: ");
            string searchString = Console.ReadLine();

            // Step 3: Search for a string
            bool found = mainString.Contains(searchString);

            // Step 4: Print message on console window
            if (found) 
            {
                Console.WriteLine("String found!");
            }
            else
            {
                Console.WriteLine("String not found!");
            }

            Console.ReadKey();
        }
    }
}