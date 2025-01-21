// See https://aka.ms/new-console-template for more information
using System;

class Boolean_and_character_demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boolean and character data types");

        // Syntax
        bool boolVar;

        // Example 1: Verify TrueString and FalseString
        Console.WriteLine("Value of TrueString: {0}", bool.TrueString);
        Console.WriteLine("Value of FalseString: {0}", bool.FalseString);

        // Example 2: isNumber method
        char charVar = '3';
        bool result = char.IsNumber(charVar);
        Console.WriteLine("Is it a number? : {0}", result);
    }
}
