// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;


public class Program
{
    public static void Main()
    {

        //this code is for displaying the string in the console
        Console.WriteLine("This is a String Assignment\n");


        //this line of code is i declarre a string variable and assign a value to it

        string firstName = "Christopher";
        string middleName = "Valdez";
        string lastName = "Lopez";

        //this line of code is for concatenating the string variables and displaying the full name in the console
       
        
        string fullname = "My fullname is "+firstName + " " + middleName + " " + lastName;
        Console.WriteLine(fullname+"\n\n");
      

        //thuis line ofcode is to display a string with uppercase letters in the console

        string FullnameUpper=fullname.ToUpper();


        Console.WriteLine("This is a uppercase Fullname "+FullnameUpper+"\n");
    

        //this a stringbuilder

        StringBuilder sample = new StringBuilder();
        sample.Append("This is a StringBuilder example");
        sample.Append("\nToday is a new day have a nice day "+firstName+"\n");
        sample.Append("This day is my special day");
        Console.WriteLine(sample.ToString());
        Console.ReadLine();
    }


}