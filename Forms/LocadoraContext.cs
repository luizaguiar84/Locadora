using Forms.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Forms
{
	public class LocadoraContext : DbContext
	{
		public DbSet<Teste> Teste	 { get; set; }

		public LocadoraContext()
		{
		}
		public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
		{
		}


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			optionsBuilder.UseSqlServer("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=fatcars");
		}

	}
}