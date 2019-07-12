namespace Forms.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("Cliente")]
	public class Cliente
    {
        public Cliente()
        {
            //this.contratos = new HashSet<Contratos>();
        }

		[Key]
        public int Id { get; set; }
		public string TipoCliente { get; set; }

        public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Cnpj { get; set; }
		public string Profissao { get; set; }
		public string Contato { get; set; }
		public string Email { get; set; }
		public string Rg { get; set; }
		public string Ie { get; set; }
		public DateTime? Nascimento { get; set; } // o ? significa que pode ser nulo
		public string TelComercial { get; set; }
		public string TelResidencial { get; set; }
		public string TelCelular { get; set; }
		public string Cnh { get; set; }
		public string CnhCategoria { get; set; }
		public string CnhEmissao { get; set; }
		public string CnhValidade { get; set; }

		public Nullable<sbyte> StatusCliente { get; set; }
		public int EnderecoCliente { get; set; }

		//public int USUARIO_IDUSUARIO { get; set; }


		//public virtual Usuarios usuarios { get; set; }
		//public virtual Endereco endereco { get; set; }
		//public virtual ICollection<Contratos> contratos { get; set; }
	}
}
