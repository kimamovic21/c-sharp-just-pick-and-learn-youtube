namespace Parameterized_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parameterized Constructor in C# ");

            // Creating object of Student class
            Student student = new Student("Kerim", 28, 90.0);

            // Create a Student object using the default constructor
            Student student2 = new Student();

            // Display student informations
            Console.WriteLine("\nStudent informations:");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");

            // Display student2 informations
            Console.WriteLine("\nStudent2 informations:");
            Console.WriteLine($"Name: {student2.Name}");
            Console.WriteLine($"Age: {student2.Age}");
            Console.WriteLine($"Grade: {student2.Grade}");

            Console.ReadKey();
        }
    }
}