using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;
using BlueInt32.Core.Logs;
using System.Data.Entity;

namespace GoKeyboard.DAL
{
	internal sealed class Configuration : DbMigrationsConfiguration<GoKeyboardDbContext>
	{
		
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(GoKeyboardDbContext context)
		{
			SeedLogic seedLogic = new SeedLogic();
			seedLogic.CreateChapters();
			seedLogic.CreateFingers();
			seedLogic.CreateKeys();
			seedLogic.CreateLessons();

			context.Chapters.AddOrUpdate(c => c.Name, seedLogic.Chapters[0]);
			context.Keys.AddOrUpdate(c => c.Id, seedLogic.Keys.ToArray());
			context.Lessons.AddOrUpdate(c => c.Name, seedLogic.Lessons.ToArray());

			context.SaveChanges();
		}
	}
}
