using ClassMethodAssignement2;
using System;
using System.Diagnostics.CodeAnalysis;


public class Program {
    public static void Main(string[] args)
    {
        //this line i use a void method so  i call the class DivideData and declare a new object
        DivideData divideData = new DivideData();
        Console.WriteLine("Input a number");
        int input=Convert.ToInt32(Console.ReadLine());

        
      
        divideData.MathOperation(input);
        //this line i used a static so that why i call direct the class method
        double result;
        DivideData.MathOperation(input,out result);
        Console.WriteLine($"The input {input} divided by 3 is "+result);

    }



}