namespace FindDuplicateCharactersUsingLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to find duplicate characters using loop \n");

            // Step 1: Ask the user to enter a string
            Console.WriteLine("Please enter a string: ");
            string inputString = Console.ReadLine();

            // Step 2: Find duplicate characters
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in inputString)
            {
                int count = 0;
                foreach (var character in inputString)
                {
                    if (item == character)
                    {
                        count++;
                    }
                }
                if (count > 1 && !dict.ContainsKey(item))
                {
                    dict.Add(item, count);
                }
            }

            // Step 3: Print characters that occur more than once
            if (dict.Any())
            {
                foreach (KeyValuePair<char, int> keyValuePair in dict)
                {
                    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
                }
            }
            else
            {
                Console.WriteLine("There is no duplicate character.");
            }

            Console.ReadKey();
        }
    }
}