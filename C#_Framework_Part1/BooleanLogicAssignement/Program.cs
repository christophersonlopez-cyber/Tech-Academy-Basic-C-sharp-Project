// See https://aka.ms/new-console-template for more information
using System;


//this is a simple console application that prints "Car Insurance !" to the console


Console.WriteLine("Car Insurance !\n");
//this line o0f code will ask the user for their age
Console.WriteLine("Enter your Age ?");
//this line of code will convert the user's input to an integer and store it in the variable age
int age = Convert.ToInt32(Console.ReadLine());


//this line of code will ask the user if they have ever had a DUI
Console.WriteLine("Have you ever had a DUI?");
//this line of code will convert the user's input to a boolean and store it in the variable hasDUI
bool hasDUI = Convert.ToBoolean(Console.ReadLine());


//this line of code will ask the user how many speeding tickets they have
//then it will convert the user's input to an integer and store it in the variable speedingTickets
Console.WriteLine("How many speeding tickets do you have?");
int speedingTickets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("Qualified for car insurance?");
bool results = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);
Console.WriteLine(results);




