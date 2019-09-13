namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;

	public class Clientes : IBSBanco<Clientes>
	{
		public Clientes()
		{
			this.Cnh = new Cnhs();
			this.Endereco = new Enderecos();
			this.Locacao = new List<ClienteLocacao>();
		}


		[Key]
		public int Id { get; set; }
		[DefaultValue(true)]
		public bool IsAtivo { get; set; }
		[MaxLength(2)]
		public string TipoCliente { get; set; }
		[MaxLength(200)]
		[Required]
		public string Nome { get; set; }
		[MaxLength(20)]
		public string Cpf { get; set; }
		[MaxLength(20)]
		public string Cnpj { get; set; }
		[MaxLength(50)]
		public string Profissao { get; set; }
		[MaxLength(200)]
		public string Contato { get; set; }
		[MaxLength(200)]
		public string Email { get; set; }
		[MaxLength(20)]
		public string Rg { get; set; }
		[MaxLength(20)]
		public string Ie { get; set; }
		public DateTime? Nascimento { get; set; } // o ? significa que pode ser nulo
		[MaxLength(14)]
		public string TelComercial { get; set; }
		[MaxLength(14)]
		public string TelResidencial { get; set; }
		[MaxLength(14)]
		public string TelCelular { get; set; }

		public int CnhId { get; set; }
		public Cnhs Cnh { get; set; }

		public int EnderecoId { get; set; }
		public Enderecos Endereco { get; set; }

		public ICollection<ClienteLocacao> Locacao { get; set; }

		public bool DbAdd()
		{
			throw new NotImplementedException();
		}

		public bool DbUpdate()
		{
			throw new NotImplementedException();
		}

		public bool DeleteRegistro()
		{
			throw new NotImplementedException();
		}

		public List<Clientes> GetAll()
		{
			throw new NotImplementedException();
		}


		//public int USUARIO_IDUSUARIO { get; set; }
		//public virtual Usuarios usuarios { get; set; }
		//public virtual Endereco endereco { get; set; }
		//public virtual ICollection<Contratos> contratos { get; set; }

		public override string ToString()
		{
			return $"Nome do CLiente: {this.Nome} ";
		}
	}
}
