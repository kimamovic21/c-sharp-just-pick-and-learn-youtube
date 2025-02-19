namespace StaticClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static class - demo");

            string testString = " Hello,          World! ";

            Console.WriteLine($"Original string: {testString}");

            // 1. Reverse a string
            Console.WriteLine($"Reversed: {StringUtility.Reverse(testString)}");

            // 2. Count numbers of words in a string
            Console.WriteLine($"Number of words: {StringUtility.WordCount(testString)}");

            // 3. To check if a string is Numeric
            Console.WriteLine($"Is \"12345\" Numeric? {StringUtility.IsNumeric("12345")}");

            Console.ReadKey();
        }
    }
}