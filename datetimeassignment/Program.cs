using System;


public class Program
{
    public static void Main(string[] args)
    {
        //this line prints the current date and time in the format "yyyy-MM-dd HH:mm:ss"
        DateTime date = DateTime.Now;
        //this line i used a string format to display the date and time in a specific way, which is "yyyy-MM-dd HH:mm:ss"
        string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
        //this line displays the formatted date and time to the console

        Console.WriteLine(formattedDate);
        //ask the user to input a number
        Console.WriteLine("Input a number:");
        //convert the user input into a integerand store it in a variable called number
        int number = Convert.ToInt32(Console.ReadLine());
        //this line add        Console.WriteLine("In {0} hours, it will be {1}", number, DateTime.Now.AddHours(number));
    }
}