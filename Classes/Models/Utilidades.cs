namespace Classes.Models

{
	using Correios.CEP;
	using System;
	using System.Windows.Forms;

	/// <summary>
	/// Utilidades do sistema
	/// </summary>
	public static class Utilidades
	{
		/// <summary>
		/// Formata o TextBox para forma Monetária
		/// </summary>
		/// <param name="text">nome do TextBox</param>
		/// <param name="format"></param>
		public static void IsDinheiro(this TextBox text, string format = "C2")
		{

			if (double.TryParse(text.Text, out double value))
			{
				text.Text = value.ToString(format);
			}
			else
			{
				if (text.Text == null)
					text.Text = "0,00";
			}
		}
		
		/// <summary>
		/// Valida a data do MaskedTextBox
		/// </summary>
		/// <param name="texto">Nome do MaskedTextBox</param>
		public static void IsData(this MaskedTextBox texto)
		{
			if (!string.IsNullOrWhiteSpace(texto.Text))
			{
				try
				{
					DateTime data = DateTime.Parse(texto.Text.Replace("/", "-"));

					
					if (data > DateTime.Now)
					{
						MessageBox.Show("Data incorreta, favor preencher novamente.", "Erro!");
						texto.Text = "";
						texto.Focus();
					}
					if(data.Year < (DateTime.Now.Year - 120))
					{
						MessageBox.Show("Ano Inválido, favor preencher novamente.", "Erro!");
						texto.Text = "";
						texto.Focus();
					}
					if(data.Month > 12 || data.Month < 1)
					{
						MessageBox.Show("Mês inválido, favor preencher novamente.", "Erro!");
						texto.Text = "";
						texto.Focus();
					}
					if (data.Day > 31 || data.Day <1)
					{
						MessageBox.Show("Dia Inválido, favor preencher novamente.", "Erro!");
						texto.Text = "";
						texto.Focus();
					}
				}
				catch
				{
				
				}
			}		
		}

		/// <summary>
		/// Aceitar apenas numeros no campo.
		/// </summary>
		/// <param name="e"></param>
		public static void IsNumeros(this object obj, KeyPressEventArgs e)
		{

			if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
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
			if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
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
				int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
				int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
				int soma;
				int resto;
				string digito;
				string tempCnpj;
				cnpj = cnpj.Trim();
				cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
				if (cnpj.Length != 14)
					return false;
				tempCnpj = cnpj.Substring(0, 12);
				soma = 0;
				for (int i = 0; i < 12; i++)
					soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
				resto = (soma % 11);
				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;
				digito = resto.ToString();
				tempCnpj += digito;
				soma = 0;
				for (int i = 0; i < 13; i++)
					soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
				resto = (soma % 11);
				if (resto < 2)
					resto = 0;
				else
					resto = 11 - resto;
				digito += resto.ToString();
				return cnpj.EndsWith(digito);
			}
		
		/// <summary>
		/// Valida o CPF
		/// </summary>
		/// <param name="cpf">insira o <paramref name="cpf"/></param>
		/// <returns></returns>
		public static bool IsCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf += digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito += resto.ToString();
			return cpf.EndsWith(digito);
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
	}

	
}
