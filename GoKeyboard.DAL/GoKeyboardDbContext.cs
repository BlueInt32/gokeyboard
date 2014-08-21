using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;

namespace GoKeyboard.DAL
{
	public class GoKeyboardDbContext : DbContext
	{

        public GoKeyboardDbContext()
		{
			Database.SetInitializer<GoKeyboardDbContext>(null);
		}

        public DbSet<Key> Keys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Finger> Fingers { get; set; }

		public ObjectContext ObjectContext
		{
			get { return ((IObjectContextAdapter)this).ObjectContext; }
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Ignore<LessonPage>();
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
}