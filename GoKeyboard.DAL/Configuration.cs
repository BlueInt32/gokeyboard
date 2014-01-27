using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;
using Tools;

namespace GoKeyboard.DAL
{
	//internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
	//{
	//	readonly List<string> _lessonsShort = new List<string> { "fj", "ei", "dk", "sl", "qm", "ru", "zo", "ap", "gh", "ty", "vn", "b,", "c;", "x:", "w!" };
	//	public Configuration()
	//	{
	//		AutomaticMigrationsEnabled = true;
	//	}

	//	protected override void Seed(DataContext context)
	//	{
	//		log4net.Config.XmlConfigurator.Configure();
	//		Log.InfoFormat("Global.asax", "Application_Start");


	//		#region Keys & Fingers
	//		//Base 
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "id",
	//			Name = "Index droit",
	//			Keys = "ujnyh,è-UJNYH?76"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "md",
	//			Name = "Majeur droit",
	//			Keys = "ik;_IK.8"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "ad",
	//			Name = "Annulaire droit",
	//			Keys = "ol:çOL/9"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "od",
	//			Name = "Auriculaire droit",
	//			Keys = "pm!à)=PM§0°+" + "RFVTGB54EDC3ZSX2AQW1"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "pd",
	//			Name = "Pouce droit",
	//			Keys = " "
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "ig",
	//			Name = "Index gauche",
	//			Keys = "rfvtgb('RFVTGB54"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "mg",
	//			Name = "Majeur gauche",
	//			Keys = "edc\",EDC3"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "ag",
	//			Name = "Annulaire gauche",
	//			Keys = "zsxéZSX2"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "og",
	//			Name = "Auriculaire gauche",
	//			Keys = "aqw&AQW1UJNYH?76IK.8OL/9PM§0°+"
	//		});
	//		context.GkFingers.AddOrUpdate(new GkFinger
	//		{
	//			Code = "pg",
	//			Name = "Pouce gauche",
	//		});

	//		#endregion

	//		#region Lessons

	//		GkChapter chapter1 = new GkChapter
	//		{
	//			Name = "Les touches de base",
	//			Description = "On entame naturellement avec les touches de base : les lettres de l'alphabet et quelques ponctuations !"
	//		};
	//		context.GkChapters.AddOrUpdate(c => c.Name, chapter1);
	//		//Log.Info("Seed", GetKnownChars(context));


	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[0]), WorkedChars = _lessonsShort[0] });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[1]), WorkedChars = _lessonsShort[1], KnownChars = GetKnownChars(1) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[2]), WorkedChars = _lessonsShort[2], KnownChars = GetKnownChars(2) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[3]), WorkedChars = _lessonsShort[3], KnownChars = GetKnownChars(3) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[4]), WorkedChars = _lessonsShort[4], KnownChars = GetKnownChars(4) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[5]), WorkedChars = _lessonsShort[5], KnownChars = GetKnownChars(5) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[6]), WorkedChars = _lessonsShort[6], KnownChars = GetKnownChars(6) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[7]), WorkedChars = _lessonsShort[7], KnownChars = GetKnownChars(7) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[8]), WorkedChars = _lessonsShort[8], KnownChars = GetKnownChars(8) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[9]), WorkedChars = _lessonsShort[9], KnownChars = GetKnownChars(9) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[10]), WorkedChars = _lessonsShort[10], KnownChars = GetKnownChars(10) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[11]), WorkedChars = _lessonsShort[11], KnownChars = GetKnownChars(11) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[12]), WorkedChars = _lessonsShort[12], KnownChars = GetKnownChars(12) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[13]), WorkedChars = _lessonsShort[13], KnownChars = GetKnownChars(13) });
	//		context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[14]), WorkedChars = _lessonsShort[14], KnownChars = GetKnownChars(14) });

	//		#endregion

	//		//context.

	//		//context.GkLessonPages.AddOrUpdate(new GkLessonPage
	//		//{
	//		//    Lesson
	//		//});


	//		context.SaveChanges();
	//	}

	//	private string GetKnownChars(int take)
	//	{
	//		return _lessonsShort.Take(take).Aggregate(string.Empty, string.Concat);
	//	}

	//	private string DoTitle(string twoChars)
	//	{
	//		return string.Format("{0} et {1}", twoChars[0], twoChars[1]);
	//	}

	//}
}
