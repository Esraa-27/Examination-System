using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject 
    {
		private int id;
		private string name;

		private Exam exam;

		#region constructors

        public Subject(int _id , string _name)
		{
			id = _id;	
			name = _name;
			//exam = new Exam();
		}
		public Subject() : this(0, "Subject") { }
		#endregion

		#region propreties

		public int Id{ get; set;}
		public string Name { get; set; }

		public Exam Exam
		{
			get { return exam; }
			//set;// { exam= new Exam(); }
		}


		#endregion


		public void createSubjectExam()
		{
			//implement functionality to create the exam of the subject. 
			// save data of exam subject
			int choice = 0;
			do
			{
				Console.Write("Please Enter Type of Exam you Want To Create (1 for Practical and 2 for Final): ");
				int.TryParse(Console.ReadLine(), out choice);
			} while (choice != 1 && choice != 2);

			// create object from same type of exam (override function) 

			if (choice == 1)
				exam = new PracticalExam(); 
			else if (choice == 2)
				exam = new FinalExam(); 
            

            int t; bool flag;
			do
			{
				Console.Write("Please Enter The Time of Exam in Minutes: ");
				flag = int.TryParse(Console.ReadLine(), out t);
			} while (!flag || !(t>0));
            exam.Time = t;

            int no = 0;
			do
			{
				Console.Write("Please Enter Number of Question you Want To Create : ");
				flag = int.TryParse(Console.ReadLine(), out no);
			} while (!flag || !(no>0));
			exam.NoOfQuestions = no;

			Console.Clear();

            // call function create questions of exam  
            exam.createExam();



        }

        public override string ToString()
		{
			return $"{id} , {name} , { exam}";
		}

		
		
	}
}
