 using Microsoft.EntityFrameworkCore;
using System;

namespace Forms.Models
{
	public class LocadoraContext : DbContext
	{
		public DbSet<Teste> Teste { get; set; }

		public DbSet<Abastecimentos> Abastecimentos { get; set; }
		public DbSet<Cliente> Cliente { get; set; }
		public DbSet<Cnh> Cnh { get; set; }
		public DbSet<Contratos> Contratos { get; set; }
		public DbSet<Cor> Cor { get; set; }
		public DbSet<Endereco> Endereco { get; set; }
		public DbSet<Funcionarios> Funcionarios { get; set; }
		public DbSet<Manutencao> Manutencao { get; set; }
		public DbSet<Multas> Multas { get; set; }
		public DbSet<Obrigacoes> Obrigacoes { get; set; }
		public DbSet<Pecas> Pecas { get; set; }
		public DbSet<Sinistros> Sinistros { get; set; }
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Veiculos> Veiculos { get; set; }




		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LUIZAGUIARA508;Initial Catalog=Locadora;Integrated Security=True");
		}
	}
}