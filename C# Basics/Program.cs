class Logical_And_Operator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Conditional Logical AND operator - &&");
        Console.WriteLine("Operand1 = true, Operand2 = true, Result={0}", true && true);
        Console.WriteLine("Operand1 = true, Operand2 = false, Result={0}", true && false);
        Console.WriteLine("Operand1 = false, Operand2 = true, Result={0}", false && true);
        Console.WriteLine("Operand1 = false, Operand2 = false, Result={0}", false && false);

        Console.WriteLine("\nLogical AND operator - &");
        Console.WriteLine("Operand1 = true, Operand2 = true, Result={0}", true && true);
        Console.WriteLine("Operand1 = true, Operand2 = false, Result={0}", true && false);
        Console.WriteLine("Operand1 = false, Operand2 = true, Result={0}", false && true);
        Console.WriteLine("Operand1 = false, Operand2 = false, Result={0}", false && false);


        Console.ReadLine();
    }
}   