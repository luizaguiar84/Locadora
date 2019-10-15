using System;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Obrigacoes
	{
		#region Construtores
		public Obrigacoes()
		{

		}
		public Obrigacoes(DateTime data, string tipo, decimal valor, string descricao, int veiculoId)
		{
			Data = data;
			Tipo = tipo;
			Valor = valor;
			Descricao = descricao;
			VeiculoId = veiculoId;
		}
		#endregion

		#region Anotações
		[Key] 
		#endregion
		public int Id { get;  set; }
		
		#region Anotações
		[DataType(DataType.Date)] 
		#endregion
		public DateTime Data { get;  set; }
		
		#region Anotações
		[MaxLength(100)]
		[Display(Name = "Tipo de Obrigação")] 
		#endregion
		public string Tipo { get;  set; }
		
		#region Anotações
		[DataType(DataType.Currency)] 
		#endregion
		public decimal Valor { get;  set; }
		
		#region Anotações
		[MaxLength(250)]
		[Display(Name = "Descrição")] 
		#endregion
		public string Descricao { get;  set; }

		public int VeiculoId { get;  set; }
		public virtual Veiculos Veiculo { get;  set; }


	}
}
