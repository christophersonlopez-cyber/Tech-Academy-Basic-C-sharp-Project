// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;


public class Program
{
    public static void Main()
    {

        //this is a simple while loop that prints the numbers from 1 to 5
        Console.WriteLine("This is a while loop that prints the numbers from 1 to 5:\n");
        int num = 1;

        while (num <= 5)
        {
            Console.WriteLine(num);
            num++;
        }
        Console.WriteLine("\n\n");
        //this is a simple do-while loop that prints the numbers from 1 to 10

        Console.WriteLine("This is a do-while loop that prints the numbers from 1 to 10:\n");
        int num2 = 1;

        do
        {
            Console.WriteLine(num2);
            num2++;
        }
        while (num2<=10);
    }
}