using LambdaAssignment;
using System;



public class Program
{
    public static void Main()
    {
        //this line im created a list of employee and add 10 employees to the list
        List<Employee> employees = new List<Employee>()
        {
            //this line i add 10 employeess to the list
            new Employee() { id = 1, firstName = "Joe", lastName = "Doe" },
            new Employee() { id = 2, firstName = "Joe", lastName = "Smith" },
            new Employee() { id = 3, firstName = "Jane", lastName = "Doe" },
            new Employee() { id = 4, firstName = "zairine", lastName = "fronda" },
            new Employee() { id = 5, firstName = "zander", lastName = "lopez" },
            new Employee() { id = 6, firstName = "rizen", lastName = "frondarina" },
            new Employee() { id = 7, firstName = "rick", lastName = "salazar" },
            new Employee() { id = 8, firstName = "zenaida", lastName = "delos santos" },
            new Employee() { id = 9, firstName = "christopher", lastName = "garbiel" },
            new Employee() { id = 10, firstName = "maryjane", lastName = "lucas" }
        };
        //this line i created again a new list of employee to hold  the employee with the firstnme joe
        List<Employee> JoeEmployee = new List<Employee>();
        //then  used a foreach loop to find the employee firstname joe
        foreach (Employee employee in employees)
        {
            //then this line i used  an if statement to check if the empployee firstname is equal to joe then display 
            if (employee.firstName == "Joe")
            {
                JoeEmployee.Add(employee);
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
        }
        //this line i search more online to understand more the concept of lambda 
        //then i understand what is lambda and how to use this .. it help you to a lot 
        //if yopu hava a 20 line of code its posible to do it in one line code using lamda
        JoeEmployee = employees.Where(e => e.firstName == "Joe").ToList();
   

        //this ine i used a foreach loop again to display the employee  with the firstname joe
        foreach (Employee employee in JoeEmployee)
        {
            Console.WriteLine(employee.firstName + " " + employee.lastName);

        }

        //this line of code i used  lambda to fing the employee with the id is grearter than 5
        JoeEmployee = employees.Where(e => e.id > 5).ToList();
        //then this line same as the previous one i used a foreach loop
        //this time in i dislay the id and the firstname and lastname of the  employee
        foreach (Employee employee in JoeEmployee)
        {
            Console.WriteLine(employee.id +" "+ employee.firstName + " " + employee.lastName);
        }
    }
}