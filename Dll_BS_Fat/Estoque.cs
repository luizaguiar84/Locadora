using System;

namespace Dll_BS_Fat
{
	public class Estoque
	{
		public int Id { get; set; }
		public string Peca { get; set; }
		public string Descricao { get; set; }
		public decimal ValorUnitario { get; set; }
		public DateTime DataAdicao { get; set; }
		public DateTime? DataSaida { get; set; }
		public int Quantidade { get; set; }
		public string Observacoes { get; set; }
		public string IncluidoPor { get; set; }
		public string RetiradoPor { get; set; }
	}
}
