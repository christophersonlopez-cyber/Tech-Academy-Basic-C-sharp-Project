
using System;


public class Program
{
    public static void Main()
    {
        //this part i used a list in a declare a variab;e numbers and assigned it a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        //i declared a variable valid and set it to false. This variable will be used to control the while loop that keeps asking
        //the user for input until they provide a valid number.
        bool valid = false;
        //this part i used a while loop to keep asking the user for input until they provide a
        //valid number. 
        while (!valid)
        {
            try
            {
                //this line asks the user to enter a number and reads the input from the console.
                //It then attempts to parse the input into a float.

                Console.WriteLine("Enter a number ");
                float userInput = float.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    //this part if the user input is zero, it will print a message to the console indicating that the input must be higher than zero.
                    //This is because dividing by zero is undefined and would cause an error.
                    Console.WriteLine("Input must be a higher than zero.");
                }
                else
                {
                    //this part if the user input is valid (not zero), it will set the valid variable to true, which will exit the while loop. Then, it will iterate through each number in the numbers list,
                    //divide it by the user input, and print the result to the console.
                    valid = true;
                    foreach (int number in numbers)
                    {
                        float result = number / userInput;
                        Console.WriteLine($"{number} divided by {userInput} is {result}");
                    }
                }

            }
            //this part i f the user input a string value instead of a number, it will catch the exception and print a message to the console
            //indicating that the user should input a number, not a string value. It also includes the exception message for more details.
            catch (Exception ex)
            {
                Console.WriteLine("Please input a number not a string value " + ex.Message);
            }
        }
    }
}
