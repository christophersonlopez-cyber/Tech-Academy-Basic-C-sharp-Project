// See https://aka.ms/new-console-template for more information
using System;



public class DailyReport
{
    public static void Main()
    {

        //this line of code will print the following text to the console: "Academy of learning career College
        //"
        Console.WriteLine("Academy of Learning Career College\n");

        //this code is print a student daily report
        Console.WriteLine("Student Daily Report\n");

        //this code will ask the name of the student  then i used a string variable to store the name of the student and print it to the console     
        string name = Console.ReadLine();
        Console.WriteLine("My Name is "+name+"\n");


        //this code will ask the student what course they are on then i used a string variable to store the name of the course and print it to the console
        Console.WriteLine("What course are you on?");
        string courser=Console.ReadLine();
        Console.WriteLine("I am on the "+courser+" course\n");


        //in this line of code i used a integer variablea asked the student what page number they are on and print it to the console
        Console.WriteLine("What page number?");
        int pageNumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("I am on page "+pageNumber+"\n");


        //in this line of code i used a boolean variable to ask the student if they need help with anything and print it to the console
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
       Boolean help=Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("I need help: "+help+"\n");

        //this line of code will ask the student if they have any positive experiences 
        Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
        string additionalFeedback = Console.ReadLine();
        Console.WriteLine("\n");

        //this l;ine of code will ask the student how many hours they studied today then i used a double variable to store the number of hours and print it to the console

        Console.WriteLine("How many hours did you study today?");
        double hoursStudied = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("I studied for "+hoursStudied+" hours today\n");

        //this line of code will print a thank you message to the console
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        
    }
}