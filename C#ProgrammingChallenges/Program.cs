namespace ArrayCombine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to combine two arrays without duplicate values \n");

            int[] numbers1 = { 10,20,30,40,50 };
            int[] numbers2 = { 40,50,60,70,80 };

            // Combine two arrays
            int[] numbers = numbers1.Union(numbers2).ToArray();

            Console.WriteLine("Array1:");
            PrintArray(numbers1);

            Console.WriteLine("\nArray2:");
            PrintArray(numbers2);

            Console.WriteLine("\nMerged array:");
            PrintArray(numbers);

            Console.ReadLine();
        }

        private static void PrintArray(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + ",");
            }
        }
    }
}