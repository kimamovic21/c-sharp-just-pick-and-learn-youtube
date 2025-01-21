// See https://aka.ms/new-console-template for more information
using System;

class Object_data_type_demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Object data type");

        // Declare
        object obj;

        int a = 20;
        Console.WriteLine(a.GetType());

        string str = "Hello...";
        obj = str;
        Console.WriteLine(obj);

        // Boxing - Converting value type to object type
        obj = a;

        // Unboxing - Converting object type to value type 
        a = (int)obj;
    }
}
