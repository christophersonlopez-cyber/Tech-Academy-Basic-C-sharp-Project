using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi can you input a number?");
            int input=Convert.ToInt32(Console.ReadLine());
            string logtext = "The user input is : " + input;
            File.WriteAllText(@"C:\Users\frond\OneDrive\Documents\GitHub\Tech-Academy-Basic-C-sharp-Project\logs.txt", logtext.ToString());
            Console.WriteLine("The number you entered is saving into a log file: \n\n");
            string filetext = File.ReadAllText(@"C:\Users\frond\OneDrive\Documents\GitHub\Tech-Academy-Basic-C-sharp-Project\logs.txt");
            Console.WriteLine(filetext);    



        }
    }
}