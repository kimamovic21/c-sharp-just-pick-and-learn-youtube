namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to sort an Array \n");

            int[] intArray = { 5, 4, 2, 1, 3 };
            string[] stringArray = { "Orange", "Apple", "Mango", "Watermelon" };

            Console.WriteLine("Integer Array before sorting:");
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nString Array before sorting:");
            foreach (var str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Sorting an array in ascending order
            Array.Sort(intArray);
            Console.WriteLine("\nInteger Array after ascending sorting:");
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }

            Array.Sort(stringArray);
            Console.WriteLine("\nString Array after ascending sorting:");
            foreach (var str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Sorting an array in descending order
            Array.Reverse(intArray);
            Console.WriteLine("\nInteger Array after descending sorting:");
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }

            Array.Reverse(stringArray);
            Console.WriteLine("\nString Array after descending sorting:");
            foreach (var str in stringArray)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}