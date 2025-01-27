namespace Copy_Constructor
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // Parameterless constructor
        public Student()
        {

        }

        // Parameterized constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Copy constructor
        public Student(Student student)
        {
            Name = student.Name;
            Age = student.Age;
            Grade = student.Grade;
        }
    }
}