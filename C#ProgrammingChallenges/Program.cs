namespace WriteTextToFile
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Write text to a file \n");

            const string path = @"C:\MyFiles\testFile.txt";

            Console.WriteLine("Please enter the text: \n");
            string text = Console.ReadLine();

            Console.WriteLine("Choose the option:");
            Console.WriteLine("1. Overwrite the file");
            Console.WriteLine("2. Append to the file");

            bool isValidNumber = int.TryParse(Console.ReadLine(), out int selection);

            if (!isValidNumber || selection < 1 || selection > 2)
            {
                Console.WriteLine("\nYou have entered an invalid option. Try again.");
            }
            else
            {
                switch (selection)
                {
                    case 1:
                        await WriteTextAsync(path, text, false);
                        Console.WriteLine("Text has been overwritten.");
                        break;
                    case 2:
                        await WriteTextAsync(path, text, true);
                        Console.WriteLine("Text has been appended.");
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"File location: {path}");
            }

            Console.ReadKey();
        }

        public static async Task WriteTextAsync(string path, string text, bool append)
        {
            using StreamWriter file = new StreamWriter(path, append);
            await file.WriteLineAsync(text);
        }
    }
}