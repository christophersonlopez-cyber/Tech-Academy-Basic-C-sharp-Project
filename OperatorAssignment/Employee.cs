using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    public class Employee
    {
        //this class has three properties ID, Firstname and Lastname
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //this line i overload the equality operator to compare the ID of two
        //employee objects and return true if they are equal and false if they are not equal
        public static bool operator == (Employee emp1, Employee emp2)
        {
        return emp1.ID == emp2.ID;
        }
        //this line i overload the inequality operator to compare the ID of two employee objects
        //and return true if they are not equal and false if they are equal
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1.ID == emp2.ID);
        }
    }
}
