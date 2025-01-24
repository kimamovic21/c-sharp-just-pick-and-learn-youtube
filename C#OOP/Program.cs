namespace Properties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a Student object
            Student student1 = new Student("Kerim", 28, 90.5);

            // Accessing properties
            Console.WriteLine("Student's name: {0}", student1.Name);
            Console.WriteLine("Student's age: {0}", student1.Age);
            Console.WriteLine("Student's grade: {0}", student1.Grade);

            Console.ReadLine();
        }
    }
}
