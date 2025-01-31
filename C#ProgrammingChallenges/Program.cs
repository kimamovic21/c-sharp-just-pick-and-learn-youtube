using System;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator \n");

            while (true)
            {
                Console.WriteLine("Enter 0 to exit the calculator, 1 to continue to use the calculator: \n");

                bool isValidNumber = int.TryParse(Console.ReadLine(), out int choice);

                if (!isValidNumber || (choice != 0 && choice != 1))
                {
                    Console.WriteLine("Please enter either 0 or 1. \n");
                    continue;
                }

                if (choice == 0) break;

                Console.WriteLine("Please enter your choice in number: \n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division \n");

                bool isValidOption = int.TryParse(Console.ReadLine(), out int option);

                if (isValidOption && option >= 1 && option <= 4)
                {
                    Console.WriteLine("Enter the first number:");
                    bool isValidFirstNumber = decimal.TryParse(Console.ReadLine(), out decimal firstNumber);

                    Console.WriteLine("Enter the second number:");
                    bool isValidSecondNumber = decimal.TryParse(Console.ReadLine(), out decimal secondNumber);

                    if (!isValidFirstNumber || !isValidSecondNumber)
                    {
                        Console.WriteLine("Invalid input! Please enter valid numbers.\n");
                        continue;
                    }

                    decimal result = 0.0M;

                    switch (option)
                    {
                        case 1:
                            result = Addition(firstNumber, secondNumber);
                            break;
                        case 2:
                            result = Subtraction(firstNumber, secondNumber);
                            break;
                        case 3:
                            result = Multiplication(firstNumber, secondNumber);
                            break;
                        case 4:
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed!\n");
                                continue;
                            }
                            result = Division(firstNumber, secondNumber);
                            break;
                    }

                    PrintResult(result);
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.\n");
                }
            }

            Console.WriteLine("Exiting the calculator. Goodbye!");
            Console.ReadKey();
        }

        private static void PrintResult(decimal result) => Console.WriteLine("Result: {0} \n", result);

        private static decimal Addition(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;

        private static decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;

        private static decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;

        private static decimal Division(decimal firstNumber, decimal secondNumber) => firstNumber / secondNumber;
    }
}