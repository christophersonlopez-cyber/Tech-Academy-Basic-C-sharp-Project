using OperatorAssignment;
using System;   



public class Program
{
    public static void Main(string[] args)
    {
        //thias line i defined two employee objects with the same ID but different first names and last names
        Employee emp1 = new Employee { ID = 1, Firstname = "Christopheer", Lastname = "Lopez" };
        Employee emp2 = new Employee { ID = 1, Firstname = "Jane", Lastname = "Lopez" };
        //then this line io declare a boolean data type variable to compare the Id of the employee true or false
        bool areEqual=emp1==emp2;
        //this l;ine i print the information of the two employee objects and the result of the comparison of their IDs
        Console.WriteLine($"Employee 1 Information\n\nID: {emp1.ID}\nFirstname: {emp1.Firstname}\nLastname: {emp1.Lastname}");
        Console.WriteLine($"\nEmployee 2 Information\n\nID: {emp2.ID}\nFirstname: {emp2.Firstname}\nLastname: {emp2.Lastname}");
       
        
        Console.WriteLine($"Are Employee 1 Id  and Employee 2 ID are equal? {areEqual}");

        //this line i declare a boolean data type variable to compare the Id of the employee not equal true or false
        bool areNotEqual =emp1!=emp2;

        Console.WriteLine($"Are Employee 1 Id  and Employee 2 ID are not equal? {areNotEqual}");
    }
}