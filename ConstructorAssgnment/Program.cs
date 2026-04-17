
using System;


namespace ConstructorAssignment
    {
    class Program
    {
        static void Main(string[] args)
        {
            //this line i used a constant datatype to assign values to the name and age
            //constant datatype is used to assign values that cannot be changed later in the program
            const string name = "Christopher";
            const int age = 30;
            //this line i used the constructor to create an instance
            //of the Person class and pass the name and age values to it
            var person = new Person(name, age);
            //this line i called the display method to print the name and age of the person
            person.display();



        }

        //this line i created a class called Person that has two properties: Name and Age
        public class Person
        {
            //this line i create a property called Name of type string and a property called Age of type int
            public string Name { get; set; }
             public int Age { get; set; }

            //this line i created a constructor that takes two parameters: name and age, and assigns them to the Name and Age properties
            public Person(string name,int age)
            {
                Name = name;
                Age = age;
            }
            //this line i created a method to called display print the name abnd the age

            public void display()
            {
                Console.WriteLine(@"Name: {0} and my Age {1}" , Name, Age);
          
            }
        }
    }
   
}