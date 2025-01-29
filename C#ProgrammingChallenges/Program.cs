namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to find element \n");

            string[] fruits = { "Orange", "Apple", "Mango", "Watermelon", "Avocado" };
            string searchTerm = "Watermelon";
            //string searchTerm = "Banana";

            // Searching for an element
            string fruit = Array.Find(fruits, element => element.Equals(searchTerm));

            if (!String.IsNullOrEmpty(fruit))
            {
                Console.WriteLine($"Search successful: {fruit}");
            } else
            {
                Console.WriteLine("Fruit not found!");
            }
            
            Console.ReadKey();
        }
    }
}