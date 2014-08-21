using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoKeyboard.DTO;
using BlueInt32.Core.Logs;

namespace GoKeyboard.DAL
{
    public class LessonsDal
    {
		public Lesson Retrieve(int id)
        {
            using (GoKeyboardDbContext context = new GoKeyboardDbContext())
            {
                Lesson lessonFromDb = context.Lessons.Include(c => c.WorkedChars).Include(c => c.KnownChars).FirstOrDefault(u => u.LessonId == id);
				return lessonFromDb;
            }
        }

        public List<Chapter> GetChapters()
        {
            using (GoKeyboardDbContext context = new GoKeyboardDbContext())
            {
                Log.Info("LessonDal", context.ObjectContext.Connection.ConnectionString);
                return context.Chapters.ToList();
            }
        }

        public List<Lesson> GetLessons(int chapterId)
        {
            using (GoKeyboardDbContext context = new GoKeyboardDbContext())
            {
                return context.Lessons/*.Include("Chapter")*/.Where(l => l.Chapter.Id == chapterId).ToList();
            }
        }
    }
}
