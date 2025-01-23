class Negation_Operator
{
    public static void Main(string[] args)
    {
        bool isOnTime = true;

        if (!isOnTime)
        {
            Console.WriteLine("The student is marked as absent");
            
        } else
        {
            Console.WriteLine("The student is marked as present");
        }
        Console.ReadLine();
    }
}   