using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class Lesson
    {
		public int LessonId { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

        public List<LessonPage> LessonPages { get; set; }


		public int ChapterId { get; set; }

        [InverseProperty("LessonsFocus")]
        public ICollection<Key> WorkedChars { get; set; }

        [InverseProperty("LessonsWith")]
        public ICollection<Key> KnownChars { get; set; }
        public virtual Chapter Chapter { get; set; }
        
        [NotMapped]
        public int CharsAmount
        {
            get
            {
                return LessonPages.Aggregate<LessonPage, int>(0, (seed, page) => seed + page.Text.Length);
            }
        }

    }
}
