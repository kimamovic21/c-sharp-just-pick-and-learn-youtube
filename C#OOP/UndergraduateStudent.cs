namespace Abstraction
{
    abstract class UndergraduateStudent : Student
    {
        public string Major { get; set; }

        public override void DisplayInformation()
        {
            Console.Write("Undergraduate Student Information\n");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Major: {0}", Major);
        }
    }
}