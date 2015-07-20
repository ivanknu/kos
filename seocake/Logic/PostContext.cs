using seocake.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace seocake.Logic
{
	public class PostContext : DbContext
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Posts>().ToTable("Posts");
		}
		public PostContext()
			: base("seocakeEntities")
		{
		}

		public DbSet<Posts> PostSet { get; set; }
	}
}