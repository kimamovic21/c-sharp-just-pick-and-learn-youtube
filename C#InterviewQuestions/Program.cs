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
            using StreamReader reader = File.OpenText(@"C:\MyFiles\test-file.txt");
            
            string fileContent = reader.ReadToEnd();

            Console.WriteLine("File content:\n" + fileContent);
            Console.ReadLine();
        }
    }
}