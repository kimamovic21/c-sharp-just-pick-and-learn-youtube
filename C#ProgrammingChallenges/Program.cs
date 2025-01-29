namespace CountWordsInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to count number of words in a sentence \n");

            // Step 1: Ask the user to enter a sentence
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Step 2: Split the sentence into words using space as a separator
            string[] words = sentence.Split(' ');

            // Step 3: count the number of words
            int wordsCount = words.Length;

            // Step 4: Print the number of words
            Console.WriteLine("The number of words in the sentence is: " + wordsCount);

            Console.ReadKey();
        }
    }
}