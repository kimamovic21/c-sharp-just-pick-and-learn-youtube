namespace Multiple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Inheritance in C#");

            // Create an Employee object
            Employee employee = new Employee("John", "IT");


            // Call methods from both interfaces
            employee.ProcessSalary();
            employee.GenerateReport();

            // Call IPayable's and IReportable's methods
            ((IPayable)employee).Test();
            ((IReportable)employee).Test();

            // Keep console open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}