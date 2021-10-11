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

            ArrayList groups = new ArrayList();

            for (int i = 0; i < students.Count; i++)
			{
                if (students.Count % 2 == 0)
	                {
                        
	                }
                Console.WriteLine(students[i]);
			}

            Console.ReadKey();
        }
    }
}
