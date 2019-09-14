namespace Dll_BS_Fat
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Funcionarios
	{
		public Funcionarios()
		{
			this.Endereco = new Enderecos();
			this.Cnh = new Cnhs();
		}

		[Key]
		public int Id { get; set; }
		[DefaultValue(true)]
		public bool IsAtivo { get; set; }
		[MaxLength(250)]
		[Required]
		public string Nome { get; set; }
		[MaxLength(20)]
		[Required]
		public string Cpf { get; set; }
		[MaxLength(20)]
		public string Rg { get; set; }
		[MaxLength(200)]
		public string Email { get; set; }
		[MaxLength(20)]
		public string TelResidencial { get; set; }
		[MaxLength(20)]
		public string TelCelular { get; set; }
		[Required]
		public decimal Salario { get; set; }
		[Required]
		public DateTime Admissao { get; set; }
		[MaxLength(20)]
		[Required]
		public string Ctps { get; set; }
		[MaxLength(20)]
		[Required]
		public string Pis { get; set; }
		[MaxLength(20)]
		[Required]
		public string TituloEleitor { get; set; }
		public DateTime Nascimento { get; set; }
		public DateTime? Demissao { get; set; }

		public int CnhId { get; set; }
		[MaxLength(20)]
		public Cnhs Cnh { get; set; }

		public int EnderecoId { get; set; }
		public Enderecos Endereco { get; set; }

		public string Observacoes { get; set; }

		


		//public int CARGOS_IDCARGO { get; set; }
		//public int USUARIOS_IDUSUARIO { get; set; }
		//public int MATRICULA { get; set; }

		//public virtual Cargos cargos { get; set; }
		//public virtual Usuarios usuarios { get; set; }



	}
}