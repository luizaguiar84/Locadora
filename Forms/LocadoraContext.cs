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
		public DbSet<Veiculo> Veiculos { get; set; }
		public DbSet<Modelos> Modelos { get; set; }
		public DbSet<Montadora> Montadoras { get; set; }
		public DbSet<ControlePatio> ControlePatio { get; set; }
		public DbSet<TipoDespesa> TipoDespesa { get; set; }
		public DbSet<Despesas> Despesas { get; set; }
		public DbSet<Estoque> Estoque { get; set; }
		public DbSet<Pneus> Pneus { get; set; }




		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("Data Source=LUIZAGUIARA508;Initial Catalog=Locadora;Integrated Security=True");
			optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Locadora; Integrated Security = True;");
		}
		
	}
}
