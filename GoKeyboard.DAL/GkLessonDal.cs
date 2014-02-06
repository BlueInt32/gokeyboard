using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoKeyboard.DTO;
using Tools;
using Tools.Orm;

namespace GoKeyboard.DAL
{
    public class GkLessonDal : Crud<GkLesson,int>
    {
        public OperationResult<GkLesson> Create(GkLesson inputObject)
        {
            throw new NotImplementedException();
        }

        public OperationResult<GkLesson> Retrieve(int id)
        {
            using (DataContext context = new DataContext())
            {
                GkLesson lessonFromDb = context.GkLessons.Include(c => c.WorkedChars).Include(c => c.KnownChars).FirstOrDefault(u => u.GkLessonId == id);
                if (lessonFromDb == null)
                    return OperationResult<GkLesson>.BadResult("GkLesson introuvable");
                return OperationResult<GkLesson>.OkResultInstance(lessonFromDb);
            }
        }

        public OperationResult<GkLesson> Update(GkLesson inputObject)
        {
            throw new NotImplementedException();
        }

        public OperationResult<GkLesson> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GkChapter> GetChapters()
        {
            using (DataContext context = new DataContext())
            {
                Log.Info("GkLessonDal", context.ObjectContext.Connection.ConnectionString);
                return context.GkChapters.ToList();
            }
        }

        public List<GkLesson> GetLessons(int chapterId)
        {
            using (DataContext context = new DataContext())
            {
                return context.GkLessons/*.Include("Chapter")*/.Where(l => l.Chapter.Id == chapterId).ToList();
            }

        }
    }
}
