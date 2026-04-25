using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstCodeAssignment
{
    public class StudentContext:DbContext
    {
        public DbSet<Students> students { get; set; }
        public DbSet<Grades> grades { get; set; }
    }
}
