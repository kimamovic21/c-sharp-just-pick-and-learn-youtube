namespace Copy_Constructor
{
    class Subject
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Subject()
        {

        }

        private Subject(string name)
        {
            Name = name;
            Description = name;
        }

        public static Subject CreateStudent(string name)
        {
            return new Subject(name);
        }
    }
}