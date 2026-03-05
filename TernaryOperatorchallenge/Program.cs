// See https://aka.ms/new-console-template for more information
using System;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("This is ternary operator\n");
        int num1 = 20;
        int num2 = 10;
        string result = num1 < num2 ? $"The {num1} is greather than {num2}" : $"The {num1} is greater than {num2}";
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
