namespace Forms.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Cliente
    {
        public Cliente()
        {
			//this.contratos = new HashSet<Contratos>();
			this.Cnh = new Cnh();
			this.Endereco = new Endereco();
        }

		[Key]
        public int Id { get; set; }
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
		public Cnh Cnh { get; set; }
		public sbyte? StatusCliente { get; set; }
		public Endereco Endereco { get; set; }


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
