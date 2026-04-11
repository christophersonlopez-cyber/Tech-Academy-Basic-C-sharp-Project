using System;
using System.Security.Cryptography.X509Certificates;
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}


public class Program
{
    public static void Main(string[] args)
    {
        bool continueInput = true;
        while (continueInput)
        {
            try
            {
                Console.WriteLine("Input a day of the week:");
                string inputuser = Console.ReadLine();
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), inputuser, true);
                Console.WriteLine($"Today is: {day}");
                continueInput = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Please enter an actual day of the week.");

            }

        }
    }
}