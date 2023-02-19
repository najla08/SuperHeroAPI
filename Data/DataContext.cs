using System;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
	public class DataContext: DbContext
	{
		public DataContext(DbContextOptions<DataContext>options): base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=superherodb;User ID='sa';Password='Najla009';Encrypt=false;MultipleActiveResultSets=true");
		}

		public DbSet<SuperHero> SuperHeroes { get; set; }
	}
}

