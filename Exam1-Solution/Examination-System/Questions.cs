using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{

    abstract class Questions
    {
        private string header;
        private  Answers [] body;
        private int mark;
        private int idOfRightAnswer;
        private int idOfUserAnswer;

        #region constructors
        public Questions() : this("" , new Answers[0] , 0 ,0, 0) { }

        public Questions(string _header, Answers[] _body, int _mark, int _idOfRightAnswer , int _idOfUserAnswer)
        {
            header = _header;
            body = _body;
            mark = _mark;
            idOfRightAnswer = _idOfRightAnswer;
            idOfUserAnswer = _idOfUserAnswer;
            
        }
        #endregion

        #region proprties

        public string Header 
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        public Answers[] Body 
        {
            get 
            {
                return body;
            }
            set
            {
                body = value;
            }
        }

        public int Mark 
        {
            get
            {
                return mark;
            }
            set
            {
                if(value>0)
                {
                    mark = value;
                }
            }
        }
        public int IdOfRightAnswer
        {
            get
            {
                return idOfRightAnswer;
            }
            set
            {
                if (value > 0)
                {
                    idOfRightAnswer = value;
                }
            }
        }
        public int IdOfUserAnswer
        {
            get
            {
                return idOfUserAnswer;
            }
            set
            {
                if (value > 0)
                {
                    idOfUserAnswer = value;
                }
            }
        }
        #endregion

        public string getBody()
        {
            string bodyOfQuestion="";
            for (int i = 0; i < body.Length; i++)
            {
                bodyOfQuestion+=body[i].ToString() +"      " ;
            }
            return bodyOfQuestion;
        }


        public abstract void createQuestion();

        public override string ToString()
        {
            return $"header ={header} ? \nbody={getBody()} , mark ={mark} \nidOfUserAnswer={idOfUserAnswer} \nidOfRightAnswer={idOfRightAnswer}";
        }



    }
}
