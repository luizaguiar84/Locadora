namespace Utilidades
{
    using Caelum.Stella.CSharp.Format;
    using Caelum.Stella.CSharp.Validation;
	using Correios.CEP;
	using System;
    using System.Collections.Generic;
    using System.Configuration;
	using System.Windows.Forms;

	/// <summary>
	/// Utilidades do sistema
	/// </summary>
	public static class Utilidades
	{

		/// <summary>
		/// Aceitar apenas numeros no campo.
		/// </summary>
		/// <param name="e"></param>
		public static void IsNumeros(this object obj, KeyPressEventArgs e)
		{
			if (!(Char.IsNumber(e.KeyChar) &&
				  Char.IsDigit(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Aceitar apenas letras no campo.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="e"></param>
		public static void IsLetras(this object obj, KeyPressEventArgs e)
		{
			if (!(Char.IsLetter(e.KeyChar) ||
				  Char.IsControl(e.KeyChar) ||
				  Char.IsSeparator(e.KeyChar)))

				e.Handled = true;

		}

		/// <summary>
		/// Método para limpar os TextBoxes
		/// </summary>
		/// <param name="controles">Selecione os controles a apagar (nao esqueça os que estao dentro dos grids</param>
		public static void LimparTextBoxes(this Control.ControlCollection controles)
		{
			foreach (Control ctrl in controles)
			{
				if (ctrl is TextBox)
				{
					(ctrl as TextBox).Text = string.Empty;
				}
				if (ctrl is MaskedTextBox)
				{
					(ctrl as MaskedTextBox).Text = string.Empty;

				}
				if (ctrl is ComboBox)
				{
					(ctrl as ComboBox).Text = string.Empty;

				}
				if (ctrl is RichTextBox)
				{
					(ctrl as RichTextBox).Text = string.Empty;

				}
				if (ctrl is CheckedListBox)
				{
					((CheckedListBox)(ctrl)).Text = string.Empty;

				}
				if (ctrl is CheckBox)
				{
					(ctrl as CheckBox).Checked = false;

				}
			}
		}

		/// <summary>
		/// Faz a Validaçao do CNPJ
		/// </summary>
		/// <param name="cnpj">insira o <paramref name="cnpj"/></param>
		/// <returns></returns>
		public static bool IsCnpj(string cnpj)
		{
			if (new CNPJValidator().IsValid(cnpj))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Valida o CPF
		/// </summary>
		/// <param name="cpf">insira o <paramref name="cpf"/></param>
		/// <returns></returns>
		public static bool ValidarCpf(string cpf)
		{
			if (new CPFValidator().IsValid(cpf))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static string FormatarCPF(this string cpf)
		{
			return new CPFFormatter().Format(cpf);
		}

		public static string FormatarCNPJ(this string cnpj)
		{
			return new CNPJFormatter().Format(cnpj);
		}

		/// <summary>
		/// Valida o PIS
		/// </summary>
		/// <param name="pis">insira o <paramref name="pis"/></param>
		/// <returns></returns>
		public static bool IsPis(string pis)
		{
			int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			if (pis.Trim().Length != 11)
				return false;
			pis = pis.Trim();
			pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(pis[i].ToString()) * multiplicador[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			return pis.EndsWith(resto.ToString());
		}

		/// <summary>
		/// Busca o CEP
		/// </summary>
		/// <param name="maskedCEP">Campo do CEP</param>
		/// <returns></returns>
		public static string[] BuscaCep(MaskedTextBox maskedCEP)
		{
			cepConsulta endereco = correiosCEP.GetAddress(maskedCEP.Text);


			if (endereco.Cep != null)
			{
				var enderecos = new string[4];

				enderecos[0] = endereco.Rua;
				enderecos[1] = endereco.Cidade;
				enderecos[2] = endereco.Bairro;
				enderecos[3] = endereco.UF;
				return enderecos;
			}
			else
			{
				return null;
			}

		}

		public static string LeDadosStringCoexao(string chave)
		{
			string RetornaStringConexao = string.Empty;

			try
			{
				RetornaStringConexao = ConfigurationManager.ConnectionStrings[chave].ConnectionString;
			}
			catch (Exception ex)
			{
				string err = ex.Message;
				RetornaStringConexao = string.Empty;
			}

			return RetornaStringConexao;
		}

		/// <summary>
		/// Recupera lista de Enum
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static IList<T> EnumToList<T>()
		{
			if (!typeof(T).IsEnum)
				throw new Exception("T isn't an enumerated type");

			IList<T> list = new List<T>();
			Type type = typeof(T);
			if (type != null)
			{
				Array enumValues = Enum.GetValues(type);
				foreach (T value in enumValues)
				{
					list.Add(value);
				}
			}

			return list;
		}
	}


}
