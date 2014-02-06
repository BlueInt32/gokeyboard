using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoKeyboardRest.Api.Models
{
    public class KeyboardHelperKeyViewModel
    {
        public GkKey Key { get; set; }
        //public string ReadableKey
        //{
        //    get
        //    {
        //        switch (Key)
        //        {
        //            case "é": return "eacute";
        //            case "\"": return "quot";
        //            case "'": return "apos";
        //            case "(": return "lpar";
        //            case "-": return "minus";
        //            case "è": return "eagrave";
        //            case "_": return "underscore";
        //            case "ç": return "ccedil";
        //            case "à": return "agrave";
        //            case ")": return "rpar";
        //            case "=": return "equals";
        //            case " ": return "spacebar";
        //            default: return Key;
        //        }
        //    }
        //}
        public bool Enabled { get; set; }

        private string BaseKeyClass { get { return string.Format("key_{0}", Key.Token); } }
        public string RowClass {get;set;}
        public string CssClass
        {
            get
            {
                string stateClass;
                if (Enabled)
                    stateClass = "enabled";
                else
                    stateClass = "disabled";
                return string.Format("{0} {1} {2}", BaseKeyClass, stateClass, RowClass);
            }
        }
    }
}