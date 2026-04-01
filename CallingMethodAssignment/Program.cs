using CallingMethodAssignment;
using System;


public class Program
{
    public static void Main(string[]args)
    {
        //this part  my class sample the name is "sample" class
        Class1 sample=new Class1();

        //this part i ask the user to input a number to add to nummber
        Console.WriteLine("Input  a  number:  ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input  another  number:  ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        //in this part i call the method  i created in the class and i pass
        //the number that i want to add to the method and i print the result
        int result = sample.AddNUmber(num3,num4);
        //this code is to print the output of the addition of two numbers
        Console.WriteLine($"This is for addition {num3}+{num4}: " + result);


        Console.WriteLine("\n\n");

        //this part same as the addition part but this time i call
        //the method muiltiply number
  
        Console.WriteLine("Input  a  number:  ");
        int num5=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input  another  number:  ");
        int num6=Convert.ToInt32(Console.ReadLine());

        //this part i call the method  i created in the class 
        //the  i create a variable result to hold the reult of the multiplication
        int result2 =sample.multiplyNumber(num5,num6);

        Console.WriteLine($"This is for multiplication {num5}*{num6}: " + result2);



        Console.WriteLine("\n\n");
        //this part is for the subtraction of two numbers

        Console.WriteLine("Input  a  number:  ");
        int num7=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input  another  number:  ");
        int num8=Convert.ToInt32(Console.ReadLine());

        //this part i call the methos subtract number and 
        //i create a variable result to hold the result of the subtraction\
        
        int result3 = sample.subtractNumber(num7,num8);
        Console.WriteLine($"This is for subtraction {num7}-{num8}: " + result3);

    }
}