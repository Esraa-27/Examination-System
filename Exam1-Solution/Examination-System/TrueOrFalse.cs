using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
  
    internal class TrueOrFalse: Questions
    {
        public TrueOrFalse()
        {
            Body = new Answers[2]
            {
                new Answers(){Id=1 , Text="True "},
                new Answers(){Id=2 , Text="False "},
            };
                           
        }

        public override void createQuestion()
        {

            Console.WriteLine(" True || False ");

            do
            {
                Console.WriteLine("Please Enter Body of Question : ");
                Header = Console.ReadLine();
            } while (Header == "" || Header == " ");

            int choice = 0;
            do
            {
                Console.Write("Please Enter Mark of Question : ");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice < 1);
            Mark = choice;

            int idRight = 0;
            do
            {
                Console.Write("Please Enter id of Right Answer : ");
                int.TryParse(Console.ReadLine(), out idRight);
            } while (idRight<1 || idRight > 2);
            IdOfRightAnswer = idRight;

            Console.Clear();
        }
    }
}
