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

//this line of code will check if the user is eligible for car insurance based on the criteria of being over 15 years old, not having a DUI, and having 3 or fewer speeding tickets
if (age>15&&hasDUI==false&&speedingTickets<=3) {
    //this line of code will print "You are eligible for car insurance." to the console if the user meets the criteria
    Console.WriteLine("You are eligible for car insurance.");
}
else {
    //this line of code will print "You are not eligible for car insurance." to the console if the user does not meet the criteria
    Console.WriteLine("You are not eligible for car insurance.");
}






