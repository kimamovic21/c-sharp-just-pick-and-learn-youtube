// See https://aka.ms/new-console-template for more information
using System;

class String_data_type_demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("String data type \n");

        // Instantiate a string
        
        string name = "C# tutorial";
        Console.WriteLine("String created by assigning a string literal: {0} \n", name);


        char[] charArray = { 'C', '#', ' ', 't', 'u', 't', 'o', 'r', 'i', 'a', 'l'};
        string stringFromChar = new string(charArray);
        Console.WriteLine("String created by calling a String class constructor: {0} \n", stringFromChar);

        string string1 = "C#";
        string string2 = " tutorial";
        string string3 = string1 + string2;
        Console.WriteLine("String created by using the string concatenation operator: {0} \n", string3);

        string newName = name.Replace("C#", ".NET");
        Console.WriteLine("String created by calling a method that returns a string");
        Console.WriteLine("old value: {0}", name);
        Console.WriteLine("new value: {0}", newName);

        Console.WriteLine("\nString created by calling a formatting that returns a string");
        string formattedString = string.Format("old value: {0}, new value {1}", name, newName);
        Console.WriteLine(formattedString);

        // Operations
        string originalString = "I am original string...";
        string modifiedString = originalString.Insert(originalString.Length, " and I am inserted string");
        Console.WriteLine(originalString);
        Console.WriteLine(modifiedString);

        string removedString = modifiedString.Remove(originalString.Length);
        Console.WriteLine(removedString);

        Console.ReadLine();
    }
}
