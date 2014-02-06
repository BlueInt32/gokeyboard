using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoKeyboardRest.Api.Models
{
    public class LessonItemCharViewModel
    {
        /// <summary>
        /// Unique value of the char to type in the lesson. 
        /// Lets us prevent multiple errors on the same char.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Value of the character user has to type
        /// </summary>
        public char Char { get; set; }
    }
}