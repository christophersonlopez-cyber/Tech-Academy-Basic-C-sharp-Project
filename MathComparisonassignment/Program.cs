// See https://aka.ms/new-console-template for more information
using System;



//this code will print a “Anonymous Income Comparison Program” in the console


Console.WriteLine("Anonymous Income Comparison Program\n");
//this code will ask the user to input the hourly rate and hours worked per week for person 1 and person 2

Console.WriteLine("Person 1");
Console.WriteLine("Hourly Rate?");
string rate1 = Console.ReadLine();
Console.WriteLine("Hours worked per week?");
string workinghour = Console.ReadLine();

//this code will ask the user to input the hourly rate and hours worked per week for person 1 and person 2
Console.WriteLine("\nPerson 2");
Console.WriteLine("Hourly Rate?");
string rate2 = Console.ReadLine();
Console.WriteLine("Hours worked per week?");
string workinghour2 = Console.ReadLine();

//this code is for person one to compute the total annual income
double totalrate = Convert.ToDouble(rate1);
double totalhours = Convert.ToDouble(workinghour);

double total= totalrate * totalhours *4.33;
double finaltotal = total * 12;


Console.WriteLine("\nAnnual salary of Person 1:");
Console.WriteLine(finaltotal);
//this line of code is for person 2 that compute the total annual income


double totalrate2 = Convert.ToDouble(rate2);
double totalhours2 = Convert.ToDouble(workinghour2);

double finaltotal2 = totalrate2 * totalhours2 * 4.33;
double final=finaltotal2 * 12;

Console.WriteLine("\n Annual salary of Person 2:\"");
Console.WriteLine(final+"\n");


//this code will compare the annual salary of person 1 and person 2 and print the result in the console
Console.WriteLine("Person 1 makes more money than Person 2?");
bool comparison = finaltotal > final;

Console.WriteLine(comparison);
