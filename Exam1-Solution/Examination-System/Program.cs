using System;
using System.Diagnostics;
using System.Timers;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Subject subject = new Subject(1 , "java");
            do
            {
                subject.createSubjectExam();
                Console.Clear();

                Console.Write("Do You Want To Start Exam ( y | n ) : ");

                if ((char.Parse(Console.ReadLine())).ToString().ToLower() == "y")
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    subject.Exam.showExam();


                    Console.WriteLine($"\nThe Elapsed Time = {sw.Elapsed}");

                }
                else
                    Console.WriteLine("Thank You :) . ");

                Console.WriteLine("Do you want to retake the exam ? ( y | n ) ");
                if ((char.Parse(Console.ReadLine())).ToString().ToLower() == "y")
                {
                    flag=true;
                }
                else
                    flag = false;
                Console.WriteLine("Thank You :) . ");

            } while (flag);



        }
    }
}
