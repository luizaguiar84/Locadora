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

		#region Anota��es
		[Key] 
		#endregion
		public int Id { get;  set; }
		
		#region Anota��es
		[Display(Name = "Data da Multa")]
		[DataType(DataType.Date)] 
		#endregion
		public DateTime DataMulta { get;  set; }
		
		#region Anota��es
		[MaxLength(200)]
		[Display(Name = "Descri��o")] 
		#endregion
		public string Descricao { get;  set; }
		
		#region Anota��es
		[Display(Name = "Data de vencimento")] 
		#endregion
		public DateTime Vencimento { get;  set; }
		
		#region Anota��es
		[DataType(DataType.Currency)]
		#endregion
		public decimal Valor { get;  set; }
		
		#region Anota��es
		[Display(Name = "Pontos")] 
		#endregion
		public int Pontos { get;  set; }

		public int VeiculoId { get;  set; }
		public virtual Veiculos Veiculo { get; set; }




		//public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }

		//public virtual Contratocarro contratocarro { get; set; }
	}
}
