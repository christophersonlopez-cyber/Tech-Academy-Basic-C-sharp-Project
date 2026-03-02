// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        //this line of code is to print a console application assignment and then ask the user to enter a number, multiply that number by 50 and print the result.
        Console.WriteLine("Console Application assignment\n");

        Console.WriteLine("Enter a number:");
        long number = Convert.ToInt64(Console.ReadLine());
        long result = number * 50;
        Console.WriteLine($"The result of multiplying {number} by 50 is: {result}\n\n");

        //this line of code is to ask the user to enter a number, add 25 to that number and print the result.
        Console.WriteLine("Enter a number:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result2 = number2 + 25;
        Console.WriteLine($"The result of adding 25 to {number2} is: {result2}\n\n");

        //this line of code is to ask the user to enter a number, divide that number by 12.5 and print the result.

        Console.WriteLine("Enter a number:");
        double number3 = Convert.ToDouble(Console.ReadLine());
        double result3 = number3 / 12.5;
        Console.WriteLine($"The result of dividing {number3} by 12.5 is: {result3}\n\n");

        //this line of code is to ask the user to enter a number, check if that number is greater than 50 and print the result.

        Console.WriteLine("Enter a number:");
        int number4 = Convert.ToInt32(Console.ReadLine());
        bool isGreaterThan50 = number4 > 50;
        Console.WriteLine($"Is {number4} greater than 50? {isGreaterThan50}\n\n");

        //this line of code is to ask the user to enter a number, divide that number by 7 and print the remainder.

        Console.WriteLine("Enter a number:");
        int number5 = Convert.ToInt32(Console.ReadLine());
        int remainder = number5 % 7;
        Console.WriteLine($"The remainder of dividing {number5} by 7 is: {remainder}\n\n");


    }
}