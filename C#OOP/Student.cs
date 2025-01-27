namespace Polymorphism
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void DisplayInformation(string message)
        {
            Console.WriteLine($"{message} - Name: {Name}, Age: {Age}");
        }

        public void DisplayInformation(string message, int grade)
        {
            Console.WriteLine($"{message} - Name: {Name}, Age: {Age}, Grade: {grade}");
        }
    }
}