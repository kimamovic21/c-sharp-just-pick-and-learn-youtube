namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction in C#");

            // Using abstraction to wrk with different types of students
            Student undergraduateStudent = new UndergraduateStudent()
            {
                Name = "Kerim",
                Age = 28,
                Major = "Computer Science"
            };

            Student graduateStudent = new GraduateStudent()
            {
                Name = "John",
                Age = 30,
                ResearchArea = "Artificial Intelligence"
            };

            // Common interface for displaying student information
            undergraduateStudent.WelcomeMessage();

            Console.WriteLine("\n-------------------");

            undergraduateStudent.DisplayInformation();
            graduateStudent.DisplayInformation();

            Console.ReadKey();
        }
    }
}