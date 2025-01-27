namespace Copy_Constructor
{
    class Teacher
    {
        // Static field
        private static int totalTeachers;

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Static Constructor
        static Teacher()
        {
            Console.WriteLine("Static constructor called for Teacher"); 
            totalTeachers = 0;
            //Name;
        }

        // Instance constructor
        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;

            // Increment the total number of teachers when a new teacher is created
            totalTeachers++;
        }
    }
}