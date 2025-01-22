// See https://aka.ms/new-console-template for more information
using System;

class Comparison_Operators
{
    static void Main(string[] args)
    {
        Console.WriteLine("Comparison Operators \n");

        int operand = 100;
        //int operand = 200;
        int operand2 = 200;
        bool result;

        Console.WriteLine("operand: " + operand);
        Console.WriteLine("operand2: " + operand2);

        Console.WriteLine("Less than Operator");
        result = operand < operand2;
        Console.WriteLine(result);

        Console.WriteLine("Greater than Operator");
        result = operand > operand2;
        Console.WriteLine(result);

        Console.WriteLine("Less than or equal Operator");
        result = operand <= operand2;
        Console.WriteLine(result);

        Console.WriteLine("Greater than or equal Operator");
        result = operand >= operand2;
        Console.WriteLine(result);

        Console.ReadLine();
    }
}
