using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{
    internal class PracticalExam: Exam
    {
        public override void createExam()
        {
            listOfQuestions = new MCQ[this.NoOfQuestions];

            for (int i = 0; i < listOfQuestions.Length; i++)
            {
                int choice = 0;
                do
                {
                    Console.Write("Please Enter number of MCQ Choise : ");
                    int.TryParse(Console.ReadLine(), out choice);
                } while (choice < 1);
                int size = choice;
                listOfQuestions[i] = new MCQ(size);
                listOfQuestions[i].createQuestion();
                Console.Clear();
            }
                

            
        }

        public override void showResult()
        {
            int YourMark = 0;
            int TotalMark = 0;

            for (int i = 0; i < listOfQuestions.Length; i++)
            {
                
                Console.WriteLine($"Q{i + 1}) {listOfQuestions[i].Header}?" +
                    $"\n    Right Answer is => {listOfQuestions[i].Body[listOfQuestions[i].IdOfRightAnswer - 1]}" +
                    $"\n    Your Answer is => {listOfQuestions[i].Body[listOfQuestions[i].IdOfUserAnswer - 1]}");

                TotalMark += listOfQuestions[i].Mark;

                if(listOfQuestions[i].IdOfRightAnswer == listOfQuestions[i].IdOfUserAnswer)
                {
                    YourMark += listOfQuestions[i].Mark;
                }


            }
            Console.WriteLine($"Your Mark = {YourMark}/{TotalMark}");
          
        }
    }
}
