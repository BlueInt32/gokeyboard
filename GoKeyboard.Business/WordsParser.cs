using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.Business
{
	public abstract class WordsParser
	{
		protected abstract string WordsFilePath { get; }

		void abstract BuildWordsListIfNeeded(string charSet, string wordListFilePath);

	}
}
