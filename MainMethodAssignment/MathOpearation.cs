using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class MathOpearation
    {
        public  int addtion(int num) {
            return num +10;
        }
        public int multiply(decimal num)
        {
            int num2 = Convert.ToInt32(num);
            return num2 * 5;
        }
        public int Subtract(string num)
        {
            int num2 = Convert.ToInt32(num);
            return num2 - 5;
        }
    }
}
