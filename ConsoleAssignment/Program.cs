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

        //this part i made a infinite loop and try to fix it

        // int number = 0;
        //because this code is the is is always gretaher than to number so that why always
        //print the value of i and it will be always 0 and it will be infinete loop
        // for (int i = 0; i >=number; i++)
        // {
        // Console.WriteLine(i);
        //  }

        //this code is to fix the infinete loop
        //this code is to display 1-10 number
        int number = 10;
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }



    }
}