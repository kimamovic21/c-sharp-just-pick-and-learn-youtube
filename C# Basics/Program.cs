Console.WriteLine("Arrays in C#");

// Declaration
int[] intArray; // int array
string[] strArray; // string array

// Initialization
intArray = new int[5]; // int array with 5 elements
strArray = new string[3]; // string array with 3 elements

// Store the values
intArray[0] = 1;
intArray[1] = 2;
intArray[2] = 3;
intArray[3] = 4;
intArray[4] = 5;

// Array declaration, creation and storing the values in a single statement

// Option 1
int[] intArray2 = new int[] { 1, 2, 3, 4, 5 };

// Option 2
int[] intArray3 = { 1, 2, 3, 4, 5 };

// Retrieving the values
Console.WriteLine("1st element in array: " + intArray[0]);

// Printing all the elements in the array
Console.WriteLine("\nFor each loop");
foreach (var item in intArray)
{
    Console.WriteLine(item);
};

// Multi-dimensional arrays
// 2D array
// 2D array with 2 rows and 3 columns
int[,] twoDimensionalArray = new int[2, 3]
{
    { 1, 2, 3},
    { 4, 5, 6}
};
// Acces item in array
Console.WriteLine(twoDimensionalArray);
Console.WriteLine(twoDimensionalArray[0, 1]);

// 3-Dimensional Array
int[,,] threeDimensionalArray = new int[2, 1, 2]
{
 { {1, 2} },
 { {3, 4} }
};
Console.WriteLine(threeDimensionalArray);
Console.WriteLine(threeDimensionalArray[0, 0, 1]);

// Jagged array
int[][] jaggedArray = new int[3][];
Console.WriteLine(jaggedArray);

Console.ReadLine();