using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class GkKey
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Print { get; set; }
        public int Index { get; set; }

        public int LineIndex { get; set; }
        public int LinePosition { get; set; }
        public bool Shifted { get; set; }
        public bool AltGred { get; set; }
        public ICollection<GkFinger> Fingers { get; set; }

        [InverseProperty("WorkedChars")]
        public ICollection<GkLesson> LessonsFocus { get; set; }

        [InverseProperty("KnownChars")]
        public ICollection<GkLesson> LessonsWith { get; set; }



    }
}
