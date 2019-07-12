using Microsoft.EntityFrameworkCore;
using System;

namespace Forms.Models
{
	public class LocadoraContext : DbContext
	{
		public DbSet<Teste> Teste { get; set; }
		public DbSet<Cliente> Cliente { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LUIZAGUIARA508;Initial Catalog=Locadora;Integrated Security=True");
		}
	}
}