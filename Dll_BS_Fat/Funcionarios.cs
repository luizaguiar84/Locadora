namespace Dll_BS_Fat
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Funcionarios
	{
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

		[Key]
		public int Id { get;  set; }

		#region Validações
		[DefaultValue(true)]
		[Display(Name = "Funcionário Ativo", Description = "Funcionário Ativo")] 
		#endregion
		public bool IsAtivo { get;  set; }

		#region Validações
		[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
		[Required(ErrorMessage = "O nome completo é obrigatório.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")] 
		#endregion
		public string Nome { get;  set; }

		#region Validações
		[Required(ErrorMessage = "O Email é obrigatório.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "E-Mail", Description = "E-Mail")] 
		#endregion
		public string Email { get;  set; }
		public Enderecos Endereco { get; set; }
		public int EnderecoId { get;  set; }
		public Cnhs Cnh { get; set; }
		public int CnhId { get;  set; }
		[MaxLength(20)]
		[Required(ErrorMessage = "RG deve ser preenchido")]
		public string Rg { get;  set; }
		[Required(ErrorMessage = "CPF deve ser preenchido")]
		public string Cpf { get;  set; }
		#region Validações
		[Display(Name = "Data Nascimento")]
		[Required(ErrorMessage = "Data deve ser preenchida")]
		[RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))| 
		(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data invalida")] 
		#endregion
		public DateTime? Nascimento { get;  set; }
		[MaxLength(20)]
		public string TelResidencial { get;  set; }
		[MaxLength(20)]
		public string TelCelular { get;  set; }
		#region Validações
		[Required(ErrorMessage = "Salário deve ser preenchido")]
		[Display(Name = "Salário")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")] 
		#endregion
		public decimal Salario { get;  set; }

		#region Validações
		[Required(ErrorMessage = "Data de admissão deve ser preenchida.")] 
		#endregion
		public DateTime Admissao { get;  set; }

		#region Validações
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados da CTPS devem ser preenchidos")] 
		#endregion
		public string Ctps { get;  set; }

		#region Validações
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados do PIS devem ser preenchidos")] 
		#endregion
		public string Pis { get;  set; }

		#region Validações
		[MaxLength(20)]
		[Required(ErrorMessage = "Dados do Título de eleitor devem ser preenchidos")] 
		#endregion
		public string TituloEleitor { get;  set; }
		public DateTime? Demissao { get;  set; }
		public string Observacoes { get;  set; }




		//public int CARGOS_IDCARGO { get; set; }
		//public int USUARIOS_IDUSUARIO { get; set; }
		//public int MATRICULA { get; set; }

		//public virtual Cargos cargos { get; set; }
		//public virtual Usuarios usuarios { get; set; }



	}
}
