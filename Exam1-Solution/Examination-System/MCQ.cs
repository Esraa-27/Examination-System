using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    /***********Finished */
    internal class MCQ : Questions
    {
       // private int size;
        public MCQ(int _size)
        {
            //size = _size;
            Body = new Answers[_size];
        }
        public override void createQuestion() 
        {
            Console.Clear();
            Console.WriteLine(" MCQ Question ");
            string text="";
            do
            {
                Console.WriteLine("Please Enter Body of Question : ");
                text = Console.ReadLine();
            }while(text == ""|| text == " ");
            Header = text;
            
            int choice = 0;
            do
            {
                Console.Write("Please Enter Mark of Question : ");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice <1);
            Mark=choice;

            for (int i = 0; i < Body?.Length; i++)
            {
                Body[i] = new Answers();
                Body[i].Id = i + 1;

                do
                {
                    Console.Write($"Please Enter choise {i + 1} : ");
                    Body[i].Text = Console.ReadLine();
                } while (Body[i].Text == "" || Body[i].Text == " ");
            }

            int idRight = 0;
            do
            {
                Console.Write("Please Enter id of Right Answer : ");
                int.TryParse(Console.ReadLine(), out idRight);
            } while (!(idRight > 0 && idRight <= Body?.Length));
            IdOfRightAnswer= idRight;

            Console.Clear();
        }

    }
}
