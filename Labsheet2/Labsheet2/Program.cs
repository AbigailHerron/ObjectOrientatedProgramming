using System;
using System.IO;

namespace Labsheet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            string[] grades = new string[7];

            File.WriteAllLines(@"C:\temp\Grades.txt", grades) ;

        }
    }
}
