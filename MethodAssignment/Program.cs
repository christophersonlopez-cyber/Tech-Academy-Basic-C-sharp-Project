using MethodAssignment;
using System;



public class Program
{
    public static void Main()
    {
        mathop1 Addmath=new mathop1();
        Console.WriteLine("Input first Number");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second Number or press Enter");


		try
		{
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Addmath.Add(num, num2);
            Console.WriteLine($"The sum of {num} and {num2} is {result}");
        }
		catch (Exception)
		{

			Console.WriteLine("The sum is: " + (num));
        }

    }
}