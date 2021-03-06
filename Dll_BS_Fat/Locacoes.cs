
namespace BsFat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;

	public class Locacoes : BaseModel
	{
		public Locacoes()
		{
			this.Cliente = new List<ClienteLocacao>();
		}

		public int Id { get; set; }

		public ICollection<ClienteLocacao> Cliente { get; set; }

		public int VeiculoId { get; set; }
		public virtual Veiculos Veiculo { get; set; }

		public int? SinistroId { get; set; }
		public virtual Sinistros Sinistro { get; set; }

		[DefaultValue("true")]
		public bool IsAtiva { get; set; }
		public DateTime DataContrato { get; set; }
		public DateTime? DataInicio { get; set; }
		public TimeSpan? HoraInicio { get; set; }
		public DateTime? DataFinal { get; set; }
		public TimeSpan? HoraFinal { get; set; }
		public decimal ValorTotal { get; set; }
		public decimal ValorAntecipado { get; set; }
		public string FormaDePagamento { get; set; }
		public int KmInicial { get; set; }
		public int KmDevolucao { get; set; }
		public string LiberadoPor { get; set; }
		public string RecebidoPor { get; set; }
		public string NivelCombustivel { get; set; }
		public bool SeguroCarro { get; set; }
		public bool SeguroTerceiros { get; set; }
		public decimal ValorSeguro { get; set; }
		public decimal ValorSeguroTerceiros { get; set; }

		public void AddCliente(Funcionarios funcionario)
		{
			this.Cliente.Add(new ClienteLocacao() { FuncionarioId = funcionario.Id });
		}

		//public decimal CalculaValorTotal(Locacoes locacao, Veiculos veiculo)
		//{
		//	var diasLocados = (int)Math.Ceiling((decimal)locacao.DataFinal.Value.Subtract(locacao.DataInicio.Value).Days);

		//	decimal valorSeguro = 0;
		//	if (SeguroCarro)
		//	{
		//		//valorSeguro += diasLocados * Program.Valores.ValorSeguro;
		//	}
		//	if (SeguroTerceiros)
		//	{
		//		//	valorSeguro += diasLocados * Program.Valores.ValorSeguroTerceiros;
		//	}

		//	return (veiculo.ValorDiaria * diasLocados) + valorSeguro;


		//}


		//public virtual ICollection<Contratocarro> contratocarro { get; set; }
	}
}
