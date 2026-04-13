using System;

struct Number { 
    public decimal amount;  

}
public class Program
{
    public static void Main()
    {
        Number num1 = new Number {amount= 100.50m };

        Console.WriteLine(num1.amount);
    }
}