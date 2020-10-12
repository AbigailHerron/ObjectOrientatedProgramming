using System;
using System.IO;

namespace Labsheet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            string[] grades = File.ReadAllLines(@"C:\temp\Grades.txt");
            int totalPoints = 0, points = 0, grade = 0;

            // Converting grades to points and finding the total
            for(int i = 0; i < grades.Length; i++)
            {
                grade = int.Parse(grades[i]);

                if(grade > 90)
                {
                    points = 100;
                }
                else if(grade > 80)
                {
                    points = 88;
                }
                else if (grade > 70)
                {
                    points = 77;
                }
                else if (grade > 60)
                {
                    points = 66;
                }
                else if (grade > 50)
                {
                    points = 56;
                }
                else if (grade > 40)
                {
                    points = 46;
                }
                else if (grade > 30)
                {
                    points = 37;
                }
                else
                {
                    points = 0;
                }// end if block
            }// end for block

        }// end Main()
    }// end Program
}// end Namespace
