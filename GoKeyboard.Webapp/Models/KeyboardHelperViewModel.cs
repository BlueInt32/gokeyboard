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

        public const string allkeys = "&é\"'(-è_çà)=azertyuiopqsdfghjklmwxcvbn ";
        public SortedList<int, string> rows = new SortedList<int, string> { { 1, "&é\"'(-è_çà)=" }, { 2, "azertyuiop" }, { 3, "qsdfghjklm" }, { 4, "wxcvbn" }, { 5, " " } };

        public List<KeyboardHelperKeyViewModel> KeyModels { get; set; }

        public KeyboardHelperViewModel(GkLesson lesson)
        {
            KeyModels = allkeys
                .ToCharArray()
                .ToList()
                .ConvertAll(c => new KeyboardHelperKeyViewModel
                                {
                                    Key = c.ToString(),
                                    Enabled = lesson.KnownChars.Contains(c) || lesson.WorkedChars.Contains(c) || c.ToString() == " ",
                                    RowClass = GetRowClass(c.ToString())
                                }
                           );
        }

        private string GetRowClass(string c)
        {
            return string.Format("row{0}", rows.FirstOrDefault(rowKeys => rowKeys.Value.Contains(c)).Key);
        }
    }
}