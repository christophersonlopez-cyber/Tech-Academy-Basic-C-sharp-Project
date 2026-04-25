using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Firstname: ");
            string name= Console.ReadLine();
            Console.WriteLine("Enter Your Middlename: ");
            string middlename = Console.ReadLine();
            Console.WriteLine("Enter Your Lastname: ");
            string lastname = Console.ReadLine();


            Console.WriteLine("Please Input a Grades\n\n");

            Console.WriteLine("Enter Your Math Grade: ");
            int mth=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Math Grade: ");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Math Grade: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Math Grade: ");
            int computer = Convert.ToInt32(Console.ReadLine());



            double avg;
            avg = (mth + eng + physics + computer) / 4;

            Console.WriteLine("Your Average is : " + avg);
            using (var context = new StudentContext())
            {
                var student = new Students
                {

                    Firstname = name,
                     Middlename = middlename,
                      Lastname = lastname
                };
                var grade = new Grades
                {

                   math=mth,
                   English=eng,
                   Physics=physics,
                   ComputerScience=computer,
                   Average=avg
                };
                context.grades.Add(grade);
                context.students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Save Data");

                Console.ReadLine();




            }
        }
    }

 
}
