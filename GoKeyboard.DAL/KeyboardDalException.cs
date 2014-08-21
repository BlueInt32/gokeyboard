using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DAL
{
	public class KeyboardDalException : Exception
	{
		public KeyboardDalException(string message)
			: base(message)
		{
		}
	}
}
