namespace Classes.Models
{
	using System;
	using System.Collections.Generic;
	using System.Windows;
    using System.Windows.Forms;

    public class Usuarios
	{
		//	public Usuarios()
		//	{
		//		this.cliente = new HashSet<Cliente>();
		//		this.funcionarios = new HashSet<Funcionarios>();
		//	}

		public int Id { get; set; }

		public bool IsAtivo { get; set; }
		public int Nivel { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public int FuncionariosId { get; set; }
		public Funcionarios Funcionario { get; set; }

		public bool ConfereUsuario(List<Usuarios> usuarios)
		{
			foreach (var _usuario in usuarios)
			{
				if (_usuario.Login == this.Login)
				{
					MessageBox.Show("Nome de usuario já existe, por favor escolha outro");
					return false;
				}
			}
			return true;
		}

		public bool ConfirmaSenha(string senha, string confirmacao)
		{
			if (senha == confirmacao)
			{
				return true;
			}
			return false;
		}

		



		//public virtual ICollection<Cliente> cliente { get; set; }
		//public virtual ICollection<Funcionarios> funcionarios { get; set; }
	}
}
