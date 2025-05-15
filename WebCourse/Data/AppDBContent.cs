using Microsoft.EntityFrameworkCore;
using WebCourse.Data.models;
namespace WebCourse.Data
{
	public class AppDBContent : DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { 
		
		}

		public DbSet<Info> Info { get; set; }
		public DbSet<Category> Category { get; set; }
	}
}
