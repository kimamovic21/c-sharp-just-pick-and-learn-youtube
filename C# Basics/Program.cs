// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Integer Type");

        int a;

        // Size of the int data type
        Console.WriteLine("Size of the int data type is: {0}", sizeof(int));

        // Range of the int data type
        Console.WriteLine("Range of the int data type is ${0} to {1}", int.MinValue, int.MaxValue);
    }
}
