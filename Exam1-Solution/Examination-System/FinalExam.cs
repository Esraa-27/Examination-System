using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    /********Finished */
    internal class FinalExam: Exam
    {
        public override void createExam()
        {
            listOfQuestions = new Questions[this.NoOfQuestions];

            for (int i=0; i< listOfQuestions.Length; i++)
            {
                int choice = 0;
                do
                {
                    Console.Write("Please Enter Type Of Question (1 for MCQ | 2 for True False ): ");
                    int.TryParse(Console.ReadLine(), out choice);
                } while (choice != 1 && choice != 2);
                Console.Clear();

                if (choice == 1)
                {
                    do
                    {
                        Console.Write("Please Enter number of MCQ Choise : ");
                        int.TryParse(Console.ReadLine(), out choice);
                    } while (choice <1);
                    int size=choice;
                    listOfQuestions[i] = new MCQ(size);
                    listOfQuestions[i].createQuestion();

                }
                else if (choice == 2)
                {
                    listOfQuestions[i] = new TrueOrFalse();
                    listOfQuestions[i].createQuestion();

                }
                
            }
        }

        public override void showResult()
        {
            int grade = 0;
            int sum = 0;
            for (int i = 0; i < listOfQuestions.Length; i++)
            {
                sum += listOfQuestions[i].Mark;
                if (listOfQuestions[i].IdOfRightAnswer == listOfQuestions[i].IdOfUserAnswer)
                {
                    grade += listOfQuestions[i].Mark;
                }
                Console.WriteLine($"Q{i + 1}) {listOfQuestions[i].Header}?" +
                   $"\n    Right Answer is => {listOfQuestions[i].Body[listOfQuestions[i].IdOfRightAnswer - 1]}" +
                   $"\n    Your Answer is => {listOfQuestions[i].Body[listOfQuestions[i].IdOfUserAnswer - 1]}");
            }
            Console.WriteLine($"\nYour Exam Grade = {grade} from {sum} .");
        }
    }
}
