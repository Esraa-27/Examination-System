using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{
    abstract class Exam
    {
		private int time;
        private int noOfQuestions;
        public Questions[] listOfQuestions;
        #region proprties
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int NoOfQuestions
        {
            get { return noOfQuestions; }
            set { noOfQuestions = value; }
        }

        #endregion

        #region constructors
        public Exam():this(0,0) { }
        public Exam(int _time , int _noOfQuestions)
        {
            time = _time;
            noOfQuestions = _noOfQuestions;
            //Questions[] listOfQuestions = new Questions[noOfQuestions];
        }
        #endregion

        public override string ToString()
        {
            return $"Exame with : {time} minutes , and no Of Questions ={noOfQuestions} ";
        }

        // abstruct function 
        //c.Show Exam Functionality that its implementations will be different for each exam based on its type

        public abstract void createExam();


        public void showExam()
        {
            foreach (var Question in listOfQuestions)
            {
                if (Question is MCQ)
                {
                    Console.WriteLine($"MCQ            Mark={Question.Mark} ");
                }
                else if (Question is TrueOrFalse)
                {
                    Console.WriteLine($"True | False           Mark={Question.Mark} ");
                }

                Console.WriteLine(Question.Header);
                Console.WriteLine(Question.getBody());
                Console.WriteLine("-----------------------------");

                int choice = 0;
                do
                {
                    Console.Write("Enter Number of Answer : ");
                    int.TryParse(Console.ReadLine(), out choice);
                } while (!(choice > 0 && choice <= Question.Body.Length));
                Question.IdOfUserAnswer = choice;


                Console.WriteLine("*********************************************************************");

            }
            Console.Clear();

            //function to show questions with answers and grade
            Console.WriteLine("Your Answers ");
            showResult();
        }

        public abstract void showResult();
       
    }
}
