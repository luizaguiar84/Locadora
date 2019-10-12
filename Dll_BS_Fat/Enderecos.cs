using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class Enderecos
	{
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

		[Key]
		public int Id { get; set; }
		[MaxLength(9)]
		public string Cep { get;  set; }
		[MaxLength(200)]
		public string Logradouro { get;  set; }
		[MaxLength(10)]
		public string Num { get;  set; }
		[MaxLength(200)]
		public string Complemento { get;  set; }
		[MaxLength(200)]
		public string Bairro { get;  set; }
		[MaxLength(200)]
		public string Cidade { get;  set; }
		[MaxLength(2)]
		public string Uf { get;  set; }


	}
}
