using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment
{
    //this line i create a class employee and i use a generic type T to make it flexible
    public class Employee<T>
    {
        //this line i create  a property things which is a list of typet to store a data
        public List<T> things { get; set; }
    }
}
