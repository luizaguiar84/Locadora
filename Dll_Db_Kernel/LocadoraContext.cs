using BsFat;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Linq;

namespace DbKernel
{
	public class LocadoraContext : DbContext
	{
		public string connectionString = //ConfigurationManager.ConnectionStrings["BdLocadora"].ConnectionString;
										"Data Source=localhost;Initial Catalog=Locadora;Integrated Security=True";
										//"Data Source=SQL5041.site4now.net;Initial Catalog=DB_A50851_fatcars;User Id=DB_A50851_fatcars_admin;Password=Fatcars0807";


		public DbSet<Abastecimentos> Abastecimentos { get; set; }
		//public DbSet<Motoristas> Motoristas { get; set; }
		public DbSet<ClientesPJ> ClientesPJ { get; set; }
		public DbSet<Cnhs> Cnhs { get; set; }
		public DbSet<Enderecos> Enderecos { get; set; }
		public DbSet<Funcionarios> Funcionarios { get; set; }
		public DbSet<Manutencoes> Manutencoes { get; set; }
		public DbSet<Multas> Multas { get; set; }
		public DbSet<Obrigacoes> Obrigacoes { get; set; }
		public DbSet<Pecas> Pecas { get; set; }
		public DbSet<Sinistros> Sinistros { get; set; }
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Veiculos> Veiculos { get; set; }
		public DbSet<ControlePatio> ControlePatio { get; set; }
		public DbSet<TipoDespesa> TipoDespesa { get; set; }
		public DbSet<Despesas> Despesas { get; set; }
		public DbSet<Estoque> Estoque { get; set; }
		public DbSet<Pneus> Pneus { get; set; }
		public DbSet<Locacoes> Locacoes { get; set; }
		public DbSet<ClienteLocacao> ClienteLocacao { get; set; }
		public DbSet<Cargos> Cargos { get; set; }
		public DbSet<Menu> Menu { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<ClienteLocacao>()
				.HasKey(pp => new { pp.LocacaoId, pp.FuncionarioId });

			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				// equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
				// and modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
				entityType.GetForeignKeys()
				.Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
				.ToList()
				.ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
			}
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}


	}
}
