namespace TrimWhiteSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to remove white spaces from a string\n");

            string string1 = "  Hello, World!  \n \n \n";
            string trimmedString = string1.Trim();
            string noSpaceString = trimmedString.Replace(" ", "");

            Console.WriteLine(string1);
            Console.WriteLine(trimmedString);
            Console.WriteLine(noSpaceString);

            Console.ReadKey();
        }
    }
}