using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueStudent;
            ArrayList students = new ArrayList();

            do
            {
                Console.WriteLine("Enter student name:");
                students.Add(Console.ReadLine());

                Console.WriteLine("Would you like to enter another student name? (Y/N)");
                continueStudent = Console.ReadLine().ToUpper();

            } while (continueStudent != "N");

            int studentCount = students.Count;

            if (studentCount % 2 == 0)
            {
                Console.WriteLine(student1);
            }


        }
    }
}
