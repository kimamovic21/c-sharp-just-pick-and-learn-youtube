namespace FindDuplicateCharactersUsingLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to find duplicate characters using LINQ \n");

            // Step 1: Ask the user to enter a string
            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine();

            // Step 2: Group the characters and filter the groups with more than one count using ling
            var groups = str.GroupBy(c => c).Where(g => g.Count() > 1);

            // Step 3: Print the characters which occur more than once
            if (groups.Any())
            {
                foreach (var group in groups)
                {
                    Console.WriteLine($"{group.Key} - {group.Count()}");
                }
            }
            else
            {
                Console.WriteLine("There is no duplicate character!");
            }

            Console.ReadKey();
        }
    }
}