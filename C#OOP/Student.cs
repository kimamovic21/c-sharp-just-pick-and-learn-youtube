namespace Parameterized_Constructor
{
    class Student
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // Default Constructor
        public Student()
        {

        }

        // Parameterized Constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}