using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;
using Tools;

namespace GoKeyboard.DAL
{
    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        
        List<GkFinger> Fingers { get; set; }
        protected override void Seed(DataContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
            Log.InfoFormat("Global.asax", "Application_Start");

            StaticDataFactory sdFactory = new StaticDataFactory();
            sdFactory.CreateChapters();
            sdFactory.CreateFingers();
            sdFactory.CreateKeys();
            sdFactory.CreateLessons();
            //context.GkKeys.AddOrUpdate(sdFactory.Keys.ToArray());
            
            context.GkChapters.AddOrUpdate(c => c.Name, sdFactory.Chapters[0]);
            context.GkKeys.AddOrUpdate(c => c.Id, sdFactory.Keys.ToArray());
            context.GkLessons.AddOrUpdate(c => c.Name, sdFactory.Lessons.ToArray());
            //Log.Info("Seed", GetKnownChars(context));

            context.SaveChanges();
        }



        private IEnumerable<GkKey> GetListKeysFromStr(string input, DbSet<GkKey> keys)
        {
            foreach (char c in input)
            {
                string strC = c.ToString();
                yield return keys.Where(k => k.Print == strC).FirstOrDefault();
            }

        }

        
    }
}
