namespace Encapsulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Example");

            // Create an object of Employee
            Employee employee1 = new Employee("John Doe", 1, 1000);

            // Display the employee information
            employee1.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}