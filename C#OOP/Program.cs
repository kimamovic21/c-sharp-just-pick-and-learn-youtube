namespace Copy_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy constructor in C#");

            // Create a Student object using the parameterized constructor
            Student student1 = new Student("John", 18, 90.5);
            Student student2 = new Student(student1);

            // Display student information
            Console.WriteLine("Student 1 informations: ");
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"Age: {student1.Age}");
            Console.WriteLine($"Grade: {student1.Grade}");

            // Display student information
            Console.WriteLine("\nStudent 2 informations: ");
            Console.WriteLine($"Name: {student2.Name}");
            Console.WriteLine($"Age: {student2.Age}");
            Console.WriteLine($"Grade: {student2.Grade}");

            Console.ReadKey();
        }
    }
}