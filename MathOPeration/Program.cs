// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;


public class MathOperations
{
    public static void Main()
    {
        //this part is to display the welcome message and the purpose of the program
        Console.WriteLine("Welcome to the Math Operations Program! \n");
      
        Console.WriteLine("This part will perform addition of two numbers.\n");

        //this line of coide for addition of two number
        Console.WriteLine("Input a first NUmber");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second NUmber");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int total = num1 + num2;
        Console.WriteLine("The total sum of two number is " + total+"\n");

        //this line of coide for substraction of two number
        Console.WriteLine("This part will perform substraction of two numbers.\n");
        Console.WriteLine("Input a first NUmber");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second NUmber");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int total1 = num3 - num4;
        Console.WriteLine("The total substraction of two number is " + total1+"\n");


        //this line of coide for multiplication of two number
        Console.WriteLine("This part will perform multiplication of two numbers.\n");

        Console.WriteLine("Input a first NUmber");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second NUmber");
        int num6 = Convert.ToInt32(Console.ReadLine());
        int total2 = num5 * num6;
        Console.WriteLine("The total multiplication of two number is " + total2+"\n");

        //this line of coide for division of two number

        Console.WriteLine("This part will perform division of two numbers.\n");

        Console.WriteLine("Input a first NUmber");
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second NUmber");
        int num8 = Convert.ToInt32(Console.ReadLine());
        //then this line of code is to convert the result of division to double to avoid loss of decimal value
        double total3 = (Double)num7 / num8;
        Console.WriteLine("The total division of two number is " + total3+"\n");




        //this part is a math string challenge\

        Console.WriteLine("This part will perform a math string challenge.\n");

        Console.WriteLine("Input number ");
        int num9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a name");
        string name = Console.ReadLine();

        string total4 = num9 + name;

        Console.WriteLine("The total of math string challenge is " + total4);


    }
}
