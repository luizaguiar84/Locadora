using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
	public class ClienteLocacao
	{
		public int ClienteId { get; set; }
		public Clientes Cliente { get; set; }

		public int LocacaoId { get; set; }
		public Locacoes Locacao { get; set; }
	}
}
