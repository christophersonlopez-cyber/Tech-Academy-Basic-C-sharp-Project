using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeAssignment
{
    public class Students
    {

        [Key]
        public int StudID { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public string Lastname { get; set; }

        public virtual ICollection<Grades> Grades { get; set; }
    }

    
}
