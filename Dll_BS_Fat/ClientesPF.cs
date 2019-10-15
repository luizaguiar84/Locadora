namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class ClientesPF
	{
		public ClientesPF()
		{
		}

		public ClientesPF(string nome, string rg, string cpf, DateTime? nascimento, TipoCliente tipoCliente, string profissao, string email,
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

		[DefaultValue(true)]
		public bool IsAtivo { get; set; }

		[Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
		[Required(ErrorMessage = "O nome completo é obrigatório.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O Email é obrigatório.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "E-Mail")]
		public string Email { get; set; }
		public Enderecos Endereco { get; set; }
		public int EnderecoId { get; set; }
		public Cnhs Cnh { get; set; }
		public int CnhId { get; set; }

		[MaxLength(20)]
		public string Rg { get; set; }

		public string Cpf { get; set; }
		public DateTime? Nascimento { get; set; }

		[MaxLength(2)]
		public TipoCliente TipoCliente { get; set; }
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
