using System;
namespace TryCatchAssignment { 
    public class Program {
        public static void Main(string[] args) {
            //this calculate the birth year
            //this line im using a try catch block to handle the exception if the user input is invalid
            try
            {
                Console.WriteLine("Enter your Age:");
                int age=Convert.ToInt32(Console.ReadLine());
                //this line is calculating the current year and the birth year
                int currentYear =DateTime.Now.Year;
                int birthYear=currentYear-age;
                //if the age is less than or equal to 0, it will throw an exception

                if (age <= 0) {
                    //this line is throwing an exception if the age is less than or equal to 0
                    throw new ArgumentException("Age cannot be negative.");
                }
                else {
                    //this line is printing the birth year if the age is valid
                    Console.WriteLine("Your Birth Year is: " + birthYear);
                }
                //this line is catching the exception if the user input is invalid and printing the error message
            }
            catch (ArgumentException ex) {
                Console.WriteLine("Invalid input: " + ex.Message);
            } catch (Exception ex) {
                //this line is catching any other exceptions that may occur and printing the error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }



}