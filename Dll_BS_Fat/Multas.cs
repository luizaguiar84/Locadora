namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Multas : BaseModel
	{
		#region Construtores
		public Multas()
		{

		}
		public Multas(DateTime dataMulta, string descricao, DateTime vencimento, decimal valor, int pontos, int veiculoId)
		{
			DataMulta = dataMulta;
			Descricao = descricao;
			Vencimento = vencimento;
			Valor = valor;
			Pontos = pontos;
			VeiculoId = veiculoId;
		}
		#endregion

		#region Anotações
		[Key] 
		#endregion
		public int Id { get;  set; }
		
		#region Anotações
		[Display(Name = "Data da Multa")]
		[DataType(DataType.Date)] 
		#endregion
		public DateTime DataMulta { get;  set; }
		
		#region Anotações
		[MaxLength(200)]
		[Display(Name = "Descrição")] 
		#endregion
		public string Descricao { get;  set; }
		
		#region Anotações
		[Display(Name = "Data de vencimento")] 
		#endregion
		public DateTime Vencimento { get;  set; }
		
		#region Anotações
		[DataType(DataType.Currency)]
		#endregion
		public decimal Valor { get;  set; }
		
		#region Anotações
		[Display(Name = "Pontos")] 
		#endregion
		public int Pontos { get;  set; }

		public int VeiculoId { get;  set; }
		public virtual Veiculos Veiculo { get; set; }




		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
	}
}
