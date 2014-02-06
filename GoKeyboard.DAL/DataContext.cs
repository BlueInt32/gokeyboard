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
	public class DataContext : DbContext
	{

        public DataContext() : base("DataContext")
		{
			Database.SetInitializer<DataContext>(new DataContextInitializer());
           // Database.Initialize(true);
		}

        public DbSet<GkKey> GkKeys { get; set; }
        public DbSet<GkUser> GkUsers { get; set; }
        public DbSet<GkChapter> GkChapters { get; set; }
        public DbSet<GkLesson> GkLessons { get; set; }
        public DbSet<GkFinger> GkFingers { get; set; }

		public ObjectContext ObjectContext
		{
			get { return ((IObjectContextAdapter)this).ObjectContext; }
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Ignore<GkLessonPage>();
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
}