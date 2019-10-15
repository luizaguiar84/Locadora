namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Funcionarios
	{
		#region Construtores
		public Funcionarios()
		{
			this.Endereco = new Enderecos();
			this.Cnh = new Cnhs();
		}

		public Funcionarios(bool isAtivo, string nome, string email, Enderecos endereco, Cnhs cnh, string rg, string cpf, DateTime? nascimento, string telResidencial, string telCelular, decimal salario, DateTime admissao, string ctps, string pis, string tituloEleitor, DateTime? demissao, string observacoes)
		{
			IsAtivo = isAtivo;
			Nome = nome;
			Email = email;
			Endereco = endereco;
			Cnh = cnh;
			Rg = rg;
			Cpf = cpf;
			Nascimento = nascimento;
			TelResidencial = telResidencial;
			TelCelular = telCelular;
			Salario = salario;
			Admissao = admissao;
			Ctps = ctps;
			Pis = pis;
			TituloEleitor = tituloEleitor;
			Demissao = demissao;
			Observacoes = observacoes;
		}

		#endregion
		
		#region Anota��es
		[Key] 
		#endregion
		public int Id { get; set; }

		#region Anota��es
		[DefaultValue(true)]
		[Display(Name = "Funcion�rio Ativo", Description = "Funcion�rio Ativo")]
		#endregion
		public bool IsAtivo { get; set; }

		#region Anota��es
		[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
		[Required(ErrorMessage = "O nome completo � obrigat�rio.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "N�meros e caracteres especiais n�o s�o permitidos no nome.")]
		#endregion
		public string Nome { get; set; }

		#region Anota��es
		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage = "O Email � obrigat�rio.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no m�nimo 5 e no m�ximo 50 caracteres.")]
		[Display(Name = "E-Mail", Description = "E-Mail")]
		#endregion
		public string Email { get; set; }
		public Enderecos Endereco { get; set; }
		public int EnderecoId { get; set; }
		public Cnhs Cnh { get; set; }
		public int CnhId { get; set; }

		#region Anota��es
		[Display(Name = "RG")]
		[MaxLength(20)]
		[Required(ErrorMessage = "RG deve ser preenchido")] 
		#endregion
		public string Rg { get; set; }

		#region Anota��es
		[Display(Name = "CPF")]
		[Required(ErrorMessage = "CPF deve ser preenchido")] 
		#endregion
		public string Cpf { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data Nascimento")]
		[Required(ErrorMessage = "Data deve ser preenchida")]
		[RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))| 
		(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data invalida")]
		#endregion
		public DateTime? Nascimento { get; set; }

		#region Anota��es
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Telefone Residencial")]
		[MaxLength(20)] 
		#endregion
		public string TelResidencial { get; set; }

		#region Anota��es
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Telefone Celular")]
		[MaxLength(20)] 
		#endregion
		public string TelCelular { get; set; }
		
		#region Anota��es
		[DataType(DataType.Currency)]
		[Required(ErrorMessage = "Sal�rio deve ser preenchido")]
		[Display(Name = "Sal�rio")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
		#endregion
		public decimal Salario { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Required(ErrorMessage = "Data de admiss�o deve ser preenchida.")]
		[Display(Name = "Data de Admiss�o")]
		#endregion
		public DateTime Admissao { get; set; }

		#region Anota��es
		[Display(Name = "CTPS")]
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados da CTPS devem ser preenchidos")]
		#endregion
		public string Ctps { get; set; }

		#region Anota��es
		[Display(Name = "PIS")]
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados do PIS devem ser preenchidos")]
		#endregion
		public string Pis { get; set; }

		#region Anota��es
		[Display(Name = "T�tulo de Eleitor")]
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados do T�tulo de eleitor devem ser preenchidos")]
		#endregion
		public string TituloEleitor { get; set; }

		#region Anota��es
		[DataType(DataType.Date)]
		[Display(Name = "Data de Demiss�o")]
		#endregion
		public DateTime? Demissao { get; set; }

		#region Anota��es
		[DataType(DataType.MultilineText)]
		[Display(Name = "Observa��es")]
		#endregion
		public string Observacoes { get; set; }




		//public int CARGOS_IDCARGO { get; set; }
		//public int USUARIOS_IDUSUARIO { get; set; }
		//public int MATRICULA { get; set; }

		//public virtual Cargos cargos { get; set; }
		//public virtual Usuarios usuarios { get; set; }



	}
}
