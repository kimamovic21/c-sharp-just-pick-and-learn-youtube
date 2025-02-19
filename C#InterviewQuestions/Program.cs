namespace SampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = num1;

            num1 = 200;

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            Person person1 = new Person();
            person1.Name = "John";

            Person person2 = person1;
            person1.Name = "Kerim";

            Console.WriteLine("person1.Name: " + person1.Name);
            Console.WriteLine("person2.Name: " + person2.Name);

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name;
    }
}