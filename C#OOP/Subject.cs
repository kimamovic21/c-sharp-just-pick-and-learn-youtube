namespace Private_Constructor
{
    class Subject
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        private Subject(string name)
        {
            Name = name;
            Description = name;
        }

        public static Subject CreateStudent(string name)
        {
            return new Subject(name);
        }

        // Override ToString() to return the Name
        public override string ToString()
        {
            return Name;
        }
    }
}