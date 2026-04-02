using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObject
{
    public class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public void Sayname() {
            string fullname = firstname + " " + lastname;
            Console.WriteLine($"My Fullname is {fullname}");        
        }
    }
}
