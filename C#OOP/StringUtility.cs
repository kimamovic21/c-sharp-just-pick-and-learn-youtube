using System;
using System.Linq;

namespace StaticClassDemo
{
    public static class StringUtility
    {
        // Method to reverse a string
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return new string(input.Reverse().ToArray());
        }

        // Method to count the number of words in a string
        public static int WordCount(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            return input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Method to check if a string is numeric
        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
