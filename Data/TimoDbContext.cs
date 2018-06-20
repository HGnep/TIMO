using Microsoft.EntityFrameworkCore;
using TIMO.Entities;

namespace TIMO.data 
{
	public class TimoDbContext : DbContext 
	{
		public TimoDbContext()
		{

		}

		public TimoDbContext(DbContextOptions<TimoDbContext> options) : base(options)
		{
			
		}
		public DbSet<Relatie> Relaties {get; set;}
		public DbSet<Uur> Uren {get; set;}

		protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) 
		{
			optionsBuilder.UseSqlite("Filename = ./TIMO.db");
		}
	}
}