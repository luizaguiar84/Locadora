
namespace Dll_BS_Fat
{
	using System;
    using System.ComponentModel.DataAnnotations;

    public class Pneus
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Estado { get; set; }

		[Display(Name = "Km Inicial")]
		public int KmInicial { get; set; }
		[Display(Name = "Km Atual")]
		public int KmAtual { get; set; }

		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }
		[Display(Name = "Data da adição")]
		public DateTime DataAdicao { get; set; }


	}
}
