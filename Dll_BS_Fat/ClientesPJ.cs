﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dll_BS_Fat
{
	public class ClientesPJ
	{

		#region CONSTRUTORES
		public ClientesPJ()
		{
			Enderecos Endereco = new Enderecos();
		}

		public ClientesPJ(bool isAtivo, string razaoSocial, string contato, string email, string cnpj, string ie, Enderecos endereco, string telComercial)
		{
			IsAtivo = isAtivo;
			RazaoSocial = razaoSocial;
			Contato = contato;
			Email = email;
			Cnpj = cnpj;
			Ie = ie;
			Endereco = endereco;
			TelComercial = telComercial;
			this.ListaVeiculos = new List<Veiculos>();

		}
		public ClientesPJ(string razaoSocial, string contato, string email, string cnpj, string ie)
		{
			RazaoSocial = razaoSocial;
			Contato = contato;
			Email = email;
			Cnpj = cnpj;
			Ie = ie;
			Enderecos Endereco = new Enderecos();

		}
		#endregion
		[Key]
		public int Id { get; set; }

		#region Validações
		[DefaultValue(true)] 
		[Display(Name ="Ativo", Description ="Cliente é ativo?")]
		#endregion
		public bool IsAtivo { get;  set; }

		#region Validações
		[Required(ErrorMessage = "Razão Social é obrigatória.")]
		[Display(Name = "Razão Social", Description = "Razão Social da empresa.")]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos na Razão Social.")] 
		#endregion
		public string RazaoSocial { get; set; }

		#region Validações
		[Required(ErrorMessage = "O Contato é obrigatório.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Contato deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "Contato", Description ="Nome do contato na empresa")]
		[MaxLength(50)] 
		#endregion
		public string Contato { get; set; }

		#region Validações
		[Required(ErrorMessage = "O Email é obrigatório.")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
		[Display(Name = "E-Mail")]
		[MaxLength(50)] 
		#endregion
		public string Email { get; set; }

		#region Validações
		[Display(Name = "CNPJ")]
		[MaxLength(17)]
		[StringLength(17, ErrorMessage = "O CNPJ deve ter no máximo 17 dígitos.")]
		[Required(ErrorMessage = "CNPJ deve ser preenchido.")] 
		#endregion
		public string Cnpj { get; set; }

		#region Validações
		[Display(Name = "Inscrição Estadual")]
		[MaxLength(17)]
		[StringLength(17, ErrorMessage = "A Inscrição Estadual deve ter no máximo 17 dígitos.")]
		[Required(ErrorMessage = "Inscrição Estadual deve ser preenchida.")] 
		#endregion
		public string Ie { get; set; }

		public Enderecos Endereco { get; set; }
		public int EnderecoId { get; set; }
		#region Validações
		[MaxLength(14)] 
		[Display(Name ="Telefone Comercial")]
		#endregion
		public string TelComercial { get;  set; }
		public ICollection<ClienteLocacao> Locacao { get; set; }
		public ICollection<Veiculos> ListaVeiculos { get; set; }
	}
}