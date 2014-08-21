using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordListManager;

namespace GoKeyboard.Business.WordsParsers
{
	public class FrenchWordsParser : WordsParser
	{

		public void BuildWordsListIfNeeded(string charSet, string wordListFilePath)
		{
			int currentLineLength = 0;
			string orderedCharsSet = String.Concat(charSet.OrderBy(c => c));
			if (!File.Exists(wordListFilePath))
			{
				string content = File.ReadAllText(WordsFilePath);
				List<string> words = content.Split('\n').ToList();

				List<string> filteredList = ProgramWordManager.FiltersByChars(words, charSet);
				string fileContent = string.Join(",", filteredList.ToArray());
				File.AppendAllText(HttpContext.Current.Server.MapPath(string.Format("~/WordsData/{0}.txt", orderedCharsSet)), fileContent);
			}

			string strWords = File.ReadAllText(HttpContext.Current.Server.MapPath(String.Format("~/WordsData/{0}.txt", orderedCharsSet)));

			strWords = Regex.Replace(strWords, @"\s", "");
			_realWordsList = strWords.Split(',').ToList();
		}

		protected override string WordsFilePath
		{
			get 
			{
				string assemblyPath = AssemblyInfo.Directory;
				return string.Format("{0}/WordsData/liste_mots_fr_Bigger.txt", assemblyPath);
			}
		}
	}
}
