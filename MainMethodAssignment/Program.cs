using MainMethodAssignment;
using System;


public class Program
{
    public static void Main(string[] args)
    {
      MathOpearation mathOpearation = new MathOpearation();

        Console.WriteLine("I added two number using class method\n\n");
        //this line i declare a int variable name number1  and  assigned a  value of 10
        Console.WriteLine("This is a sample additionn");
        int number1 = 10;
        //this line i tried to create a variable to hold the result of adding two number
        int result=mathOpearation.addtion(number1);
        //this line is the result of adding  two number using class method

        Console.WriteLine($"The result of adding 10 to {number1} is: {result}\n\n");

        //this part is a second using a decimal parameter
        Console.WriteLine("This is a second using a decimal parameter");
        //this line im using a decimal datatype toi declare a variable name number2
        decimal number2 = 20.5m;
        //but this line im not using a variable to hold the reult of multuplying 
        Console.WriteLine($"The result of multiplying 5 to {number2} is: {mathOpearation.multiply((int)number2)}");

        //this is a third using a string parameter
        Console.WriteLine("\n\nThis is a third using a string parameter");
        //this l;ine i declare a variable name number3 and assingned a string value
        string number3 = "30";
        //this line is to print the result of subtracting
        Console.WriteLine($"The result of subtracting 5 from {number3} is: {mathOpearation.Subtract(number3)}");
    }
}