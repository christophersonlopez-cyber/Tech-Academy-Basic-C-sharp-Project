using ParameterAssignment;
using System;


public class Program
{
    public static void Main()
    {
        Employee<string> employee = new Employee<string>();
        employee.things = new List<string>() { "Christopher", "Zander", "Zairine", "Rizen" };
        Employee<int> age = new Employee<int>();
        age.things = new List<int>() { 30, 10, 28, 17 };
        for (int i = 0; i < employee.things.Count; i++)
        {
            Console.WriteLine("My Name is : " + employee.things[i]);
           
        }
        for (int i = 0; i < age.things.Count; i++)
        {
            Console.WriteLine("My Age is : " + age.things[i]);
        }

        for (int i = 0; i < employee.things.Count; i++)
        {
            Console.WriteLine("My Name is : " + employee.things[i] + " and My Age is : " + age.things[i]);
        }
    }
}