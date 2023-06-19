using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Answers
    {
		private int id;
		private string text ;

		#region proprties
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Text
		{
			get { return text;  }
			set { text = value; }
		}
		#endregion


		public override string ToString()
		{
			return $"{id}.{text} .";
		}
	}
}
