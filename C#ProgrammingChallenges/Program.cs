namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to reverse a string \n");

            // Step 1: Take the input from the user
            Console.WriteLine("Please enter the string: ");
            string inputStr = Console.ReadLine();

            // Step 2: Logic to reverse a string
            // Find the index of last character
            int index = inputStr.Length - 1;
            string revStr = "";

            // Loop through the string in reverse order
            while (index >= 0)
            {
                revStr = revStr + inputStr[index];
                index--;
            }

            // Step 2: Print the output
            Console.WriteLine($"Original string: {inputStr}");
            Console.WriteLine($"Reversed string: {revStr}");

            Console.ReadKey();
        }
    }
}