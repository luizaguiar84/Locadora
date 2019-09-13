using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_BS_Fat
{
	public class Enderecos
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(9)]
		public string Cep { get; set; }
		[MaxLength(200)]
		public string Logradouro { get; set; }
		[MaxLength(10)]
		public string Num { get; set; }
		[MaxLength(200)]
		public string Complemento { get; set; }
		[MaxLength(200)]
		public string Bairro { get; set; }
		[MaxLength(200)]
		public string Cidade { get; set; }
		[MaxLength(2)]
		public string Uf { get; set; }

		
	}
}
