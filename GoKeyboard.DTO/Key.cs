using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class Key
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Print { get; set; }
        public int Index { get; set; }

        public int LineIndex { get; set; }
        public int LinePosition { get; set; }
        public bool Shifted { get; set; }
        public bool AltGred { get; set; }
        public ICollection<Finger> Fingers { get; set; }

        [InverseProperty("WorkedChars")]
        public ICollection<Lesson> LessonsFocus { get; set; }

        [InverseProperty("KnownChars")]
        public ICollection<Lesson> LessonsWith { get; set; }



    }
}
