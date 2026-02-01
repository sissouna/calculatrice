using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testscore = 76;
            char grade;
            Boolean work = true;
            if (testscore >= 90 && work)
            {
                grade = 'A';
            }
            else if (testscore >= 80)
            {
                grade = 'B';
            }
            else if (testscore >= 70)
            {
                grade = 'C';
            }
            else if (testscore >= 60)
            {
                grade = 'D';
            }


        }else{
    grade = 'F';
    }

    Console.WriteLine("Grade" = +grade)




}
   
