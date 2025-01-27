namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance in C#");

            // Creating an instance of the derived class (FictionBook)
            FictionBook fictionBook = new FictionBook(
                "Introduction to C#", 
                "John Doe", 
                100, 
                "Science",
                "lorem ipsum dolor sit amet"
            );
            fictionBook.DisplayInfo();
            fictionBook.PrintDescription();

            Console.ReadKey();
        }
    }
}