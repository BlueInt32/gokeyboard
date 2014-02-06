using GoKeyboard.Business;
using GoKeyboard.DAL;
using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoKeyboardRest.Api.Models
{
    public class KeyboardHelperViewModel
    {
        public GkLesson Lesson { get; set; }

        //public const string allkeys = "&é\"'(-è_çà)=azertyuiopqsdfghjklmwxcvbn ";
        //public SortedList<int, string> rows = new SortedList<int, string> { { 1, "&é\"'(-è_çà)=" }, { 2, "azertyuiop" }, { 3, "qsdfghjklm" }, { 4, "wxcvbn" }, { 5, " " } };

        public List<KeyboardHelperKeyViewModel> KeyModels { get; set; }

        public KeyboardHelperViewModel(GkLesson lesson)
        {
            GkKeysDal kdal = new GkKeysDal();
            IEqualityComparer<GkKey> comparer = new GkKeyEqualityComparer();
            KeyModels = kdal
                .GetKeys()
                .Where(k => !k.Shifted && !k.AltGred)
                .ToList()
                .ConvertAll(k => new KeyboardHelperKeyViewModel
                                {
                                    Key = k,
                                    Enabled = lesson.KnownChars.Contains(k, comparer) || lesson.WorkedChars.Contains(k, comparer) || k.Print.ToString() == " ",
                                    RowClass = GetRowClass(k)
                                }
                           );
        }

        private string GetRowClass(GkKey key)
        {
            return string.Format("row{0}", key.LineIndex);
        }
        //private string GetRowClass(string c)
        //{
        //    return string.Format("row{0}", rows.FirstOrDefault(rowKeys => rowKeys.Value.Contains(c)).Key);
        //}
    }
}