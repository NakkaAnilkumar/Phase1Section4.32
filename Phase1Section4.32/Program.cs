using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentData = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\Phase1Section4.32\\Phase1Section4.32\\studentData.txt").ToList();

            // Sort by student name
            studentData.Sort();

            Console.WriteLine("Sorted Student Data:");
            foreach (string student in studentData)
            {
                Console.WriteLine(student);
            }

            Console.Write("Enter a student name to search: ");
            string searchName = Console.ReadLine();

            // Search by name
            string foundStudent = studentData.FirstOrDefault(s => s.Contains(searchName));
            if (foundStudent != null)
            {
                Console.WriteLine("Found Student: " + foundStudent);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            Console.ReadLine();

        }
        
    }
 }

