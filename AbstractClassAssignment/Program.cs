using AbstractClassAssignment;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        //this line i create a new object of emnployee class
        Employee employee = new Employee();
        //this line i assign a value to the propertty of employee class
        employee.FirstName = "Sample";
        employee.LastName = "Student";
        //yhis line i call the method from employee class
        employee.sayname();
    }
}