using System;

// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        //this part i declare a array named animals and assign 6 values to it
        string[] Animals = { "Dog", "Cat", "Elephant", "Lion", "Cow", "Pig" };

        Console.WriteLine("Input a number 0 to 5");
        int input = Convert.ToInt32(Console.ReadLine());
        bool isValid = false;
        //this line is to test the input if it is valid or not, if it is valid it will print the animal name,
        //if it is not valid it will catch the exception and ask the user to input again until the input is valid
        while (!isValid)
        {
            try
            {
                //if the input is valid it will print the animal name and set isValid to true to exit the loop
                Console.WriteLine("Your Favorite Animals is : " + Animals[input]);
                isValid = true;
            }
            //i use catch block to catch the exception if the input is not valid, and ask the user to input again until the input is valid
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 5.");
                input = Convert.ToInt32(Console.ReadLine());
            }
        }
        //this part for a integer array named numbers and assign 9 values to it
        int[] numbers = { 11, 22, 13, 42, 56, 23, 56, 78, 98 };
        Console.WriteLine("Input a number 0 to 8");
        int inputNUmber = Convert.ToInt32(Console.ReadLine());
        bool isValidNumber = false;
        //this line is to test the input if it is valid or not,
        //if it is valid it will print the number,
        while (!isValidNumber)
        {
            //this part if the user input a valid number it will print the number and set
            //isValidNumber to true to exit the loop
            try
            {
                Console.WriteLine("Your Favorite Number is : " + numbers[inputNUmber]);
                isValidNumber = true;
            }
            //thpart if the user input a invalid number it will catch the exception and
            //ask the user to input again until the input is valid
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 8.");
                inputNUmber = Convert.ToInt32(Console.ReadLine());
            }
        }
        //this part is for a list of string named colors and assign 8 values to it
        List<string> colors = new List<string>() {
        "green",
        "red",
        "blue",
        "pink",
        "yellow",
        "black",
        "white",
        "purple",
        };
        //this p[art is to input a number 0to 7
        Console.WriteLine("Input a number 0 to 7");
        int inputnumbers = Convert.ToInt32(Console.ReadLine());
        bool isValidColors = false;
        //this part is to test agaibn if the user input a valid nunvber or not
        while (!isValidColors)
        {
            //this part is same case in the code below if the user is input a valid numvber
            //it will print the color

            try
            {
                Console.WriteLine("Your Favorite Color is : " + colors[inputnumbers]);
                isValidColors = true;
            }
            //this part is for the error
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 7.");
                inputnumbers = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}