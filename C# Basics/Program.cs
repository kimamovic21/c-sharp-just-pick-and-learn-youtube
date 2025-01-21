// See https://aka.ms/new-console-template for more information
using System;

class Floating_Point_Demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# floating point data type");

        float f1 = 1.2f;
        float f2 = 1.3f;

        // Range of float data type
        Console.WriteLine("Range of float data type: {0} to {1}", float.MinValue, float.MaxValue);

        // Verify the equality using equals method
        if (f1.Equals(f2))
        {
            Console.WriteLine("Variables f1 and f2 are equals");
        } else
        {
            Console.WriteLine("Variables f1 and f2 are not equals");
        }
    }
}
