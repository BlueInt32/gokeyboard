using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using GoKeyboard.DTO;
using WordListManager;

namespace GoKeyboard.Business
{
    public class LessonPageFactory
    {
        const int WordAmount = 15;
        const int Minwordsize = 3;
        const int MaxWordSize = 6;
	    private const int MaxLineSize = 30;
	    readonly Random _randomizer = new Random();

	    private List<string> _realWordsList = new List<string>();

        public Lesson BuildPages(Lesson lesson)
        {
            lesson.LessonPages = new List<LessonPage>();


            // Premiere page avec seulement les caractères à travailler
            lesson.LessonPages.Add(CreateAMixedPage(lesson.WorkedChars.GkToString(), 1, 0));

			string knownCharSet = string.Concat(lesson.WorkedChars.GkToString(), lesson.KnownChars.GkToString());

	        BuildWordsListIfNeeded(knownCharSet);
	        if (_realWordsList.Count < 6) // s'il n'y a pas beaucoup de vrais mots possibles, créer des pages de faux mots.
	        {
                lesson.LessonPages.Add(CreateAMixedPage(lesson.WorkedChars.GkToString(), 1, 0));
                lesson.LessonPages.Add(CreateAMixedPage(lesson.WorkedChars.GkToString(), 1, 0));
	        }
	        else
	        {
				lesson.LessonPages.Add(CreateAMixedPage(knownCharSet, 2, 1));
				lesson.LessonPages.Add(CreateAMixedPage(knownCharSet, 1, 4));
	        }
	        
            return lesson;
        }

	    

		private LessonPage CreateAMixedPage(string charSet, int falseWordsAmount, int realWordsAmount)
	    {
		    LessonPage returnPage = new LessonPage();
		    int probaTotal = falseWordsAmount + realWordsAmount;
		    StringBuilder sb = new StringBuilder();
			int lineLength = 0;

			for (int i = 0; i < WordAmount; i++)
			{
				int proba = _randomizer.Next(probaTotal);
				string nextWord = proba >= falseWordsAmount ? GetARealWord(charSet) : GetAFalseWord(charSet);
				if (lineLength + nextWord.Length +1> MaxLineSize)
				{
					sb = new StringBuilder(sb.ToString().Substring(0, sb.Length - 1));
					sb.AppendFormat("#");
					lineLength = 0;
				}
				sb.AppendFormat("{0} ", nextWord);
				lineLength += nextWord.Length + 1;
			}

		    returnPage.Text = sb.ToString().TrimEnd(' ');
			return returnPage;
	    }

		private string GetARealWord(string charSet)
	    {
			int choice;

			int howManyWords = _realWordsList.Count;
			choice = _randomizer.Next(0, howManyWords - 1);
			string word = _realWordsList[choice];
			return word;
	    }

	    private string GetAFalseWord(string charSet)
	    {

			List<char> chars = charSet.ToCharArray().ToList();
			StringBuilder sb = new StringBuilder();
			int wordSize = _randomizer.Next(Minwordsize, MaxWordSize);
			int nbLetters = 0;
			while (nbLetters < wordSize)
			{
				int charIndex = _randomizer.Next(0, chars.Count);
				char nextChar = chars[charIndex];
				sb.Append(nextChar);
				nbLetters++;
			}
		    return sb.ToString();
	    }
    }
}
