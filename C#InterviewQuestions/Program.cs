using System;
using System.IO;
using System.Text;
using System.Linq;

namespace SampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;

            StringBuilder stringBuilder = new StringBuilder();

            string message = "Hello ";
            string name1 = "John";
            string greeting = message + name1;
            Console.WriteLine(greeting);

            greeting = greeting.Replace("John", "Jane");

            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.Append("Hi ");
            stringBuilder1.Append("Jane");
            Console.WriteLine(stringBuilder1.ToString());

            Console.ReadLine();
        }
    }
}