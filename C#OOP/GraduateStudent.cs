namespace Abstraction
{
    abstract class GraduateStudent: Student
    {
        public string ResearchArea { get; set; }

        public override void DisplayInformation()
        {
            Console.Write("Graduate Student Information\n");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Research Area: {0}", ResearchArea);
        }
    }
}