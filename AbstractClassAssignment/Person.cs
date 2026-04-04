using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //this line is to give the properties of
        //first name and last name to the employee class
        //that is inheriting from this abstract class
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //this line is i create a method that is abstract and i will used it in the emplloyee
        //class and give it a value there
        public abstract void sayname();
           
     
    }
}
