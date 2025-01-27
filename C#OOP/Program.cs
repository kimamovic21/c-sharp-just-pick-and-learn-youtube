namespace Static_Constructor 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher();
            Console.WriteLine("Teacher1 - created");

            Teacher teacher2 = new Teacher();
            Console.WriteLine("Teacher2 - created");

            Console.ReadKey();
        }
    }
}