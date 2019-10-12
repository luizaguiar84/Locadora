namespace Dll_BS_Fat
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

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

		[Required(ErrorMessage = "Login deve ser informado!")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "Login deve ter entre 5 e 50 caracteres!")]
		public string Login { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[StringLength(10, MinimumLength = 4)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Display(Name = "Confirmar Senha")]
		[Compare("Password", ErrorMessage = "Senhas informadas não conferem")]
		public string ConfirmaSenha { get; set; }

		public int FuncionariosId { get; set; }
		public Funcionarios Funcionario { get; set; }

		public bool ConfereUsuario(List<Usuarios> usuarios)
		{
			foreach (var usuario in usuarios)
			{
				if (usuario.Login == this.Login)
				{
					return false;
				}
			}
			return true;
		}

		public bool ConfirmarSenha(string senha, string confirmacao)
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
