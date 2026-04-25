using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeAssignment
{
    public class Grades
    {
        [Key]
        public int GradeID { get; set; }
        public int math { get; set; }
        public int English { get; set; }
        public int Physics { get; set; }
        public int ComputerScience { get; set; }

        public double Average { get; set; }
        public int StudID { get; set; }
        public virtual Students Students { get; set; }
    }
}
