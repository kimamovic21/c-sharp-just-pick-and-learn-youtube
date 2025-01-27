namespace Inheritance
{
    class FictionBook: Book
    {
        public string Genre { get; set; }

        public FictionBook(
            string title, 
            string author, 
            double price, 
            string genre, 
            string description
        ): base(title, author, price, description)
        {
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}");
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Fiction Book Description: {Description}");
        }
    }
}