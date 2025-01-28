namespace Interfaces_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces in C#");

            ICustomer customer1 = new Customer(
                1, 
                "Kerim", 
                "Imamovic", 
                "kerim.imamovic@example.com", 
                "012-345-6789", 
                new DateTime(1996, 11, 28), 
                "Sarajevska 1"
            );

            Console.WriteLine($"\nCustomer 1 Full Name: {customer1.GetFullName()}\n");

            //customer.PrintCustomerDetails();

            Customer customer2 = new Customer(
                2,
                "John",
                "Doe",
                "john.doe@example.com",
                "987-654-3210",
                new DateTime(1990, 1, 1),
                "Wall Street 1"
            );
            customer2.PrintCustomerDetails();

            Console.ReadKey();
        }
    }
}