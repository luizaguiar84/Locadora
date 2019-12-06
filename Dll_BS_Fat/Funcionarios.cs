namespace BsFat
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Funcionarios : BaseModel
	{
		#region Construtores
		public Funcionarios()
		{
			this.Endereco = new Enderecos();
		}

		public Funcionarios(bool isAtivo, string nome, string email, Enderecos endereco, string rg, string cpf, DateTime nascimento, string telResidencial, string telCelular, decimal salario, DateTime admissao, string ctps, string pis, string tituloEleitor, string observacoes)
		{
			IsAtivo = isAtivo;
			Nome = nome;
			Email = email;
			Endereco = endereco;
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
			Observacoes = observacoes;
		}

		public object GetMotoristas()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Anotações
		[Key] 
		#endregion
		public int Id { get; set; }

		#region Anotações
		[Required]
		[DefaultValue(true)]
		[Display(Name = "Funcionário Ativo", Description = "Funcionário Ativo")]
		#endregion
		public bool IsAtivo { get; set; }

		#region Anotações
		[Required(ErrorMessage = "O nome completo é obrigatório.")]
		[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
		#endregion
		public string Nome { get; set; }

		#region Anotações
		[Required(ErrorMessage = "O Email é obrigatório.")]
		[DataType(DataType.EmailAddress)]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "E-Mail", Description = "E-Mail")]
		#endregion
		public string Email { get; set; }
		

		#region Anotações
		[Display(Name = "RG")]
		[MaxLength(20)]
		[Required(ErrorMessage = "RG deve ser preenchido")] 
		#endregion
		public string Rg { get; set; }

		#region Anotações
		[Display(Name = "CPF")]
		[Required(ErrorMessage = "CPF deve ser preenchido")] 
		#endregion
		public string Cpf { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Data de nascimento deve ser preenchida")]
		[DataType(DataType.Date)]
		[Display(Name = "Data Nascimento")]
		[RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))| 
		(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data invalida")]
		#endregion
		public DateTime Nascimento { get; set; }

		#region Anotações
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Telefone Residencial")]
		[MaxLength(20)] 
		#endregion
		public string TelResidencial { get; set; }

		#region Anotações
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Telefone Celular")]
		[MaxLength(20)] 
		#endregion
		public string TelCelular { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Salário deve ser preenchido")]
		[DataType(DataType.Currency)]
		[Display(Name = "Salário")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0,c}")]
		#endregion
		public decimal Salario { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Data de admissão deve ser preenchida.")]
		[DataType(DataType.Date)]
		[Display(Name = "Data de Admissão")]
		[DisplayFormat(DataFormatString = "dd/mm/yyyy")]
		#endregion
		public DateTime Admissao { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Dados da CTPS devem ser preenchidos")]
		[Display(Name = "CTPS")]
		[MaxLength(20)]
		#endregion
		public string Ctps { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Dados do PIS devem ser preenchidos")]
		[Display(Name = "PIS")]
		[MaxLength(20)]
		#endregion
		public string Pis { get; set; }

		#region Anotações
		[Required(ErrorMessage = "Dados do Título de eleitor devem ser preenchidos")]
		[Display(Name = "Título de Eleitor")]
		[MaxLength(20)]
		#endregion
		public string TituloEleitor { get; set; }
	
		public Cnhs Cnh { get; set; }
		public int? CnhId { get; set; }

		//#region Anotações
		//[DataType(DataType.Date)]
		//[Display(Name = "Data de Demissão")]
		//#endregion
		//public DateTime? Demissao { get; set; }

		#region Anotações
		[DataType(DataType.MultilineText)]
		[Display(Name = "Observações")]
		#endregion
		public string Observacoes { get; set; }



		public Enderecos Endereco { get; set; }
		public int EnderecoId { get; set; }
		//public Cnhs Cnh { get; set; }
		//public int CnhId { get; set; }


		//public int CARGOS_IDCARGO { get; set; }
		//public int USUARIOS_IDUSUARIO { get; set; }
		//public int MATRICULA { get; set; }

		//public virtual Cargos cargos { get; set; }
		//public virtual Usuarios usuarios { get; set; }



	}
}
