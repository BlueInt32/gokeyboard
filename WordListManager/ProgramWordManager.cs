using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace WordListManager
{
    public class ProgramWordManager
    {
        static void Main(string[] args)
        {
            string wordsFile = args[0];
            string strChars = args[1];
            string content = FileHelper.ReadFile(System.IO.Path.GetFullPath(wordsFile));
            List<string> wordsFreq = content.Split('\n').ToList();
            List<string> words = wordsFreq.Select(w => w.Split('\t')[0]).ToList();

            List<string> filteredList = FiltersByChars(words, strChars);
            string fileContent = string.Join(",", filteredList.ToArray());
            FileHelper.TextAppendToFile(System.IO.Path.GetFullPath(string.Format("{0}.txt", strChars)), fileContent);

        }

        public static List<string> FiltersByChars(List<string> words, string charsAccepted)
        {
            List<int> validIndexes = new List<int>();
            for (int i = 0; i < words.Count; i++)
            {
                validIndexes.Add(i);
            }
            for (int j = 0; j < words.Count; j++)
            {
                if (words[j].Any(c => !charsAccepted.Contains(c)))
                {
                    validIndexes.Remove(j);
                }
            }

            List<string> filteredList = validIndexes.Select(index => words[index]).ToList();
            filteredList = filteredList.Where(w => w.Length > 1).ToList();

            return filteredList;
        }
    }


}
