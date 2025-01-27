namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism in C#");

            Student student1 = new Student()
            {
                Name = "Kerim",
                Age = 28
            };

            // Call the overloaded methods
            student1.DisplayInformation();
            // Calls the first method

            student1.DisplayInformation("Student Information");
            // Calls the second method

            student1.DisplayInformation("Student Information", 90);
            // Calls the third method

            Console.ReadKey();
        }
    }
}