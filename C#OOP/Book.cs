namespace Inheritance
{
    abstract class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        // Constructor
        public Book(string title, string author, double price, string description)
        {
            Title = title;
            Author = author;
            Price = price;
            Description = description;
        }

        // Virtual Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price}");
        }

        // Abstract Method
        public abstract void PrintDescription();
    }
}