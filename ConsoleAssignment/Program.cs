using System;


public class Program
{
    public static void Main()
    {
        //this is an array of string
        //i decalre a variable names to hold the value of array of string
        string[] names = { "Hi", "hello", "Yoww" };

        //this part is to get the input from user and store it in a variable called input
        Console.WriteLine("Input a text you want: ");
        string input = Console.ReadLine();

        //this p[art i used a for to loop the array and add the input of the user
        for (int i = 0; i < names.Length; i++) 
        { 
            names[i] = names[i]+input;
         

        }

        //this l;ine is to print the resuklt of the array above
        Console.WriteLine("The result of array");



        //in this p[art i used foreach loop to print the result of the array after adding the input of user
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}