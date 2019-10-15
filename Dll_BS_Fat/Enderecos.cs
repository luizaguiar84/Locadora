using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Enderecos
	{
		#region Construtores
		public Enderecos()
		{

		}
		public Enderecos(string cep, string logradouro, string num, string complemento, string bairro, string cidade, string uf)
		{
			Cep = cep;
			Logradouro = logradouro;
			Num = num;
			Complemento = complemento;
			Bairro = bairro;
			Cidade = cidade;
			Uf = uf;
		}
		#endregion

		#region Anotações
		[Key] 
		#endregion
		public int Id { get; set; }
		
		#region Anotações
		[MaxLength(9)]
		[Display(Name = "CEP")] 
		#endregion
		public string Cep { get; set; }
		
		#region Anotações
		[Display(Name = "Logradouro")]
		[MaxLength(200)] 
		#endregion
		public string Logradouro { get; set; }
		
		#region Anotações
		[Display(Name = "Número")]
		[MaxLength(10)] 
		#endregion
		public string Num { get; set; }
		
		#region Anotações
		[MaxLength(200)] 
		#endregion
		public string Complemento { get; set; }
		
		#region Anotações
		[MaxLength(200)] 
		#endregion
		public string Bairro { get; set; }
		
		#region Anotações
		[MaxLength(200)] 
		#endregion
		public string Cidade { get; set; }
		
		#region Anotações
		[Display(Name = "UF")]
		[MaxLength(2)]
		[StringLength(2)]
		#endregion
		public string Uf { get; set; }


	}
}
