namespace Properties
{
    internal class Student
    {
        // Fields
        private string _name;
        private int _age;
        private double _grade;

        // Constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Property for student's name
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be null or empty.");
                }
            }
        }

        // Property for student's age
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
        }

        // Property for student's grade
        public double Grade
        {
            get { return _grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade = value;
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
        }
    }
}