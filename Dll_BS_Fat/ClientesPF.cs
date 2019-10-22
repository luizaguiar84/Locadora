namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class ClientesPF : BaseModel
	{
		public ClientesPF()
		{
		}

		public ClientesPF(string nome, string rg, string cpf, DateTime nascimento, TipoCliente tipoCliente, string profissao, string email,
			string telResidencial, string telComercial, string telCelular, bool isAtivo, Cnhs cnh, Enderecos endereco)
		{
			Nome = nome;
			Rg = rg;
			Cpf = cpf;
			Nascimento = nascimento;
			TipoCliente = tipoCliente;
			Profissao = profissao;
			Email = email;
			TelResidencial = telResidencial;
			TelComercial = telComercial;
			TelCelular = telCelular;
			IsAtivo = isAtivo;
			Cnh = cnh;
			this.Endereco = endereco;
			this.Locacao = new List<ClienteLocacao>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[DefaultValue(true)]
		public bool IsAtivo { get; set; }

		[Required(ErrorMessage = "O nome completo é obrigatório.")]
		[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
		[DataType(DataType.Text)]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O Email é obrigatório.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "E-Mail")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		public Enderecos Endereco { get; set; }
		public int EnderecoId { get; set; }
		public Cnhs Cnh { get; set; }
		public int CnhId { get; set; }

		[Required(ErrorMessage = "Favor informar o número do RG")]
		[MaxLength(20)]
		[Display(Name = "RG")]
		[DataType(DataType.Text)]
		public string Rg { get; set; }

		[Required(ErrorMessage = "Favor informar o CPF")]
		[Display(Name = "CPF")]
		public string Cpf { get; set; }

		[Required(ErrorMessage = "Favor informar a data de nascimento")]
		[Display(Name = "Data de Nascimento")]
		[DataType(DataType.Date)]
		public DateTime Nascimento { get; set; }

		[MaxLength(2)]
		public TipoCliente TipoCliente { get; set; }

		[Required(ErrorMessage = "Favor informar a profissão")]
		[MaxLength(50)]
		public string Profissao { get; set; }

		[MaxLength(14)]
		public string TelResidencial { get; set; }
		public string TelComercial { get; set; }

		[MaxLength(14)]
		public string TelCelular { get; set; }


		public ICollection<ClienteLocacao> Locacao { get; set; }


		//public int USUARIO_IDUSUARIO { get; set; }
		//public virtual Usuarios usuarios { get; set; }
		//public virtual Endereco endereco { get; set; }
		//public virtual ICollection<Contratos> contratos { get; set; }

		public override string ToString()
		{
			return $"Nome do CLiente: {Nome} ";
		}
	}
}
