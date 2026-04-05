using AbstractClassAssignment;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        //this line i create a new object of emnployee class
      Employee employees = new Employee();
        Iquitabble employee = new Employee();

        //this line i assign a value to the propertty of employee class
        employees.FirstName = "Sample";
        employees.LastName = "Student";
        //yhis line i call the method from employee class
        employees.sayname();
        //this line i call the quit method from employee class
        employee.Quit();
       
    }
}