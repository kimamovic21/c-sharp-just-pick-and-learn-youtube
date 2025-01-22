// See https://aka.ms/new-console-template for more information
using System;

class Arithmetic_Operators
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arithmetic Operators \n");


        // Increment and decrement operators
        int x = 0;

        // Prefix increment operator
        //int y = ++x;
        //int y = --x;

        // Postfix increment operator
        //int y = x++;
        int y = x--;

        Console.WriteLine("Unary increment and decrement operator demo");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        int c = -10;
        Console.WriteLine($"c = {c}");

        float operand1 = 100;
        float operand2 = 10;
        float result;

        Console.WriteLine("Operand 1: " + operand1);
        Console.WriteLine("Operand 2: " + operand2);

        // Addition
        result = operand1 + operand2;
        Console.WriteLine($"Addition: {result}");

        // Subtraction
        result = operand1 - operand2;
        Console.WriteLine($"Subtraction: {result}");

        // Multiplication
        result = operand1 * operand2;
        Console.WriteLine($"Multiplication: {result}");

        // Division
        result = operand1 / operand2;
        Console.WriteLine($"Division: {result}");

        // Remainder
        result = operand1 % operand2;
        Console.WriteLine($"Remainder: {result}");

        Console.ReadLine();
    }
}
