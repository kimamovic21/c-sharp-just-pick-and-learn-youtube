namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to check if a string is palindrome  \n");

            // Step 1: Take input from user
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            // Step 2: Convert to lowercase to ignore case sensitivity
            input = input.ToLower();

            // Step 3: Compare characters to check if palindrome
            int left = 0;
            int right = input.Length - 1;
            bool isPalindrome = true;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            // Step 4: Print the result
            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }

            Console.ReadKey();
        }
    }
}