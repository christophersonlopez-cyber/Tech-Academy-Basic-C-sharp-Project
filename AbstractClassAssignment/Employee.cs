using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //this class is inheriting from the abstract class person
    public class Employee:Person,IQuitable
    {
        public int Id { get; set; }
        //this one is to give a value to the sayname method in the abstract class
        public override void sayname()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName+"\n\n");
        }
        public void Quit()
        {
            Console.WriteLine("The employee has quit.\n");
            Console.WriteLine("Press Enter to quit.");
            Console.ReadLine();
       
        }

    }
}
