using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignement2
{
    internal class DivideData
    {
        //thuis l;ine i used a void so that why i created a object in main program
        public void MathOperation(int num1) {
            int result = num1 / 2;
            Console.WriteLine($"The Input is {num1} divided by 2 is "+result+"\n\n");
        
        }
        //this line i used static to call the class and method directly
        public static void MathOperation(double input1, out double result) { 
            //this line i use a output parameter out to hold and return the value {
            result = input1 / 3;
        
        }
    }
}
