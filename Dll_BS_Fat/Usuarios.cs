namespace BsFat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Usuarios : BaseModel
	{
		public Usuarios()
		{
		}

		#region Anota��es
		[Key]
		#endregion
		public int Id { get; set; }

		#region Anota��es
		[Display(Name = "Usu�rio Ativo")]
		#endregion
		public bool IsAtivo { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor Informar o n�vel do usu�rio")]
		[Display(Name = "Nivel do usu�rio")]
		[Range(1,4, ErrorMessage = "O nivel do usu�rio deve estar entre 1 e 4")]
		#endregion
		public int Nivel { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Login deve ser informado!")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "Login deve ter entre 5 e 50 caracteres!")]
		#endregion
		public string Login { get; set; }

		

		#region Anota��es
		[Required(ErrorMessage = "Favor digitar a senha")]
		[DataType(DataType.Password)]
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Senha deve ter entre {1} e {0} d�gitos")]
		[Display(Name = "Password")]
		#endregion
		public string Password { get; set; }

		#region Anota��es
		[Required(ErrorMessage = "Favor confirmar a senha")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirmar Senha")]
		[Compare("Password", ErrorMessage = "Senhas informadas n�o conferem")]
		#endregion
		public string ConfirmaSenha { get; set; }


		//public Funcionarios Funcionario { get; set; }

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
