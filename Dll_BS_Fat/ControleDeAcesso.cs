using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsFat
{
	public class ControleDeAcesso
	{
		public bool CadastrarNovoUsuario { get; set; }
		public bool CadastrarNovoVeiculo { get; set; }
		public bool CadastrarFuncionario { get; set; }
		public bool CadastrarCliente { get; set; }
		public bool CadastrarCargo { get; set; }

		public bool EditarUsuario { get; set; }
		public bool BuscarCliente { get; set; }
		public bool BuscarVeiculos { get; set; }

	}
}
