using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DTO
{
    public class GkLesson
    {
		public int GkLessonId { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

        public List<GkLessonPage> LessonPages { get; set; }


		public int ChapterId { get; set; }

        [InverseProperty("LessonsFocus")]
        public ICollection<GkKey> WorkedChars { get; set; }

        [InverseProperty("LessonsWith")]
        public ICollection<GkKey> KnownChars { get; set; }
        public virtual GkChapter Chapter { get; set; }
        
        [NotMapped]
        public int CharsAmount
        {
            get
            {
                return LessonPages.Aggregate<GkLessonPage, int>(0, (seed, page) => seed + page.Text.Length);
            }
        }

    }
}
