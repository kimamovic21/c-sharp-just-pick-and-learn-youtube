namespace ReadAndDisplayMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to read and display matrix \n");

            // Step 1: Propmpt user for number of rows and columns
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Step 2: Create the matrix
            int[,] matrix = new int[rows, cols];

            // Step 3: Read values into the matrix
            Console.WriteLine("Enter the values for the matrix: ");

            for (int i = 0; i < rows; i++) // rows
            {
                for (int j = 0; j < cols; j++) // columns
                {
                    Console.Write("Enter values for [{0}, {1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Step 4: Display the matrix
            for (int i = 0; i < rows; i++) // rows
            {
                for (int j = 0; j < cols; j++) // columns
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}