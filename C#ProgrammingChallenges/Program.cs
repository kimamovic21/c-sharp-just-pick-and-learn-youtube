namespace FindCurrentDateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to get current date and time \n");

            DateTime currentDateTime = DateTime.Now; 
            // Returns an object whose values is the current local date and time

            Console.WriteLine(currentDateTime);

            Console.ReadKey();
        }
    }
}