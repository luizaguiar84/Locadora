using System;
using System.IO;
using System.Windows.Forms;
using Forms;
using Forms.Models;
using Correios.CEP;


namespace Forms
{
	public partial class FormCadastrarCliente : Form
	{


		public FormCadastrarCliente()

		{
			InitializeComponent();
		}

		private void RadioPF()
		{
			lblCpf.Text = "CPF";
			maskedCpf.Name = "maskedCPF";
			maskedCpf.Mask = "999.999.999-99";
			lblRG.Text = "RG";
			lblProfissao.Text = "Profissão";
			lblNascimento.Show();
			txtNascimento.Show();
			lblCNH.Show();
			txtCNH.Show();
			lblCategoria.Show();
			txtCategoria.Show();
			lblEmitida.Show();
			maskedEmitida.Show();
			lblValidade.Show();
			maskedValidade.Show();
			lblTelCel.Show();
			txtTelCel.Show();
			lblTelRes.Show();
			txtTelRes.Show();
		}

		private void RadioPJ()
		{
			lblCpf.Text = "CNPJ";
			//maskedCpf.Name = "maskedCnpj";
			maskedCpf.Mask = "99.999.999/9999-99";
			lblRG.Text = "IE";
			lblProfissao.Text = "Contato";
			lblTelCom.Text = "Telefone";
			lblNascimento.Hide();
			txtNascimento.Hide();
			lblCNH.Hide();
			txtCNH.Hide();
			lblCategoria.Hide();
			txtCategoria.Hide();
			lblEmitida.Hide();
			maskedEmitida.Hide();
			lblValidade.Hide();
			maskedValidade.Hide();
			lblTelCel.Hide();
			txtTelCel.Hide();
			lblTelRes.Hide();
			txtTelRes.Hide();
		}

		private void RadioPF_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioPF.Checked == true)
			{
				RadioPF();
			}
			else
			{
				RadioPJ();
			}
		}

		private void RadioPj_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioPj.Checked == true)
			{
				RadioPJ();
			}
			else
			{
				RadioPF();
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCliente formBuscaCliente = new Views.Desktop.FormBuscaCliente();
			formBuscaCliente.Show();
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{

			var _cliente = new Cliente();
			//var _telefone = new Telefonecliente();
			//_cliente.endereco = new Endereco();

			if (radioPF.Checked == true)
			{
				_cliente.TipoCliente = "PF";
				_cliente.Nome = txtNome.Text;
				_cliente.Cpf = maskedCpf.Text;
				_cliente.Profissao = txtProfissao.Text;
				_cliente.Email = txtEmail.Text;
				_cliente.Rg = txtRG.Text;
				_cliente.Nascimento = DateTime.Parse(txtNascimento.Text.Replace("/", "-"));
				_cliente.TelComercial = txtTelCom.Text;
				_cliente.TelResidencial = txtTelRes.Text;
				_cliente.TelCelular = txtTelCel.Text;
				_cliente.Cnh = txtCNH.Text;
				_cliente.CnhCategoria = txtCategoria.Text;
				_cliente.CnhEmissao = maskedEmitida.Text;
				_cliente.CnhValidade = maskedValidade.Text;
				//_cliente.endereco.Cep = maskedCEP.Text;
				//_cliente.endereco.Logradouro = txtLogradouro.Text;
				//_cliente.endereco.Bairro = txtBairro.Text;
				//_cliente.endereco.Cidade = txtCidade.Text;
				//_cliente.endereco.Complemento = txtComplemento.Text;
				//_cliente.endereco.Num = txtNumero.Text;
				//_cliente.endereco.Uf = txtUF.Text;

				if (MessageBox.Show("Favor confirmar os dados:\n"
					+ _cliente.Nome + "\n"
					+ _cliente.Nascimento + "\n"
					+ "E-Mail: " + _cliente.Email + "\n"
					+ "Profissao: " + _cliente.Profissao + "\n"
					 /*
					"Telefone: " + _telefone.NumTelefone + "\n"
					+ "Endereço: " + _cliente.endereco.Logradouro + ", " + _cliente.endereco.Num + " Complemento: " + _cliente.endereco.Complemento + "\n"
					+ "Bairro: " + _cliente.endereco.Bairro + " / Cidade: " + _cliente.endereco.Cidade + " / UF: " + _cliente.endereco.Uf + "\n"
					+ "CEP: " + _cliente.endereco.Cep
					*/,
					"Confirmação",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (var contexto = new LocadoraContext())
					{
						contexto.Cliente.Add(_cliente);
						contexto.SaveChanges();
					}

					MessageBox.Show("Cadastro Efetuado com sucesso!");
					
					this.tabCadastro.Controls.LimparTextBoxes();
					this.groupEndereco.Controls.LimparTextBoxes();

					//escrevendo no arquivo (teste)
					//try
					//{
					//	var caminhoArquivo = "testeCliente.txt";
					//	using (var fs = new FileStream(caminhoArquivo, FileMode.Create))
					//	using (var escritor = new StreamWriter(fs))
					//	{
					//		escritor.WriteLine($"Nome: {_cliente.NOME_CLIENTE}, Email: {_cliente.EMAIL} \n Endereço: {_cliente.endereco.LOGRADOURO}," +
					//			$" {_cliente.endereco.NUM}. Bairro: {_cliente.endereco.BAIRRO} Cidade: {_cliente.endereco.CIDADE} " +
					//			$"UF: {_cliente.endereco.UF}");

					//	}
					//}
					//catch
					//{
					//	MessageBox.Show("Erro na gravaçao do arquivo.");
					//}
				}
			}
			if (radioPj.Checked == true)
			{
				_cliente.Nome = txtNome.Text;
				_cliente.Cnpj = maskedCpf.Text;
				_cliente.Profissao = txtProfissao.Text;
				_cliente.Email = txtEmail.Text;
				_cliente.Ie = txtRG.Text;
				//_telefone.NumTelefone = txtTelRes.Text;
				//_cliente.endereco.Cep = maskedCEP.Text;
				//_cliente.endereco.Logradouro = txtLogradouro.Text;
				//_cliente.endereco.Bairro = txtBairro.Text;
				//_cliente.endereco.Cidade = txtCidade.Text;
				//_cliente.endereco.Complemento = txtComplemento.Text;
				//_cliente.endereco.Num = txtNumero.Text;
				//_cliente.endereco.Uf = txtUF.Text;

				if (MessageBox.Show("Favor confirmar os dados:\n"
					+ "Nome da empresa: " + _cliente.Nome + "\n"
					+ "E-Mail: " + _cliente.Email + "\n"
					+ "Contato: " + _cliente.Profissao + "\n",
					/*+ 
					"Telefone: " + _telefone.NumTelefone + "\n"
					+ "Endereço: " + _cliente.endereco.Logradouro + ", " + _cliente.endereco.Num + " Complemento: " + _cliente.endereco.Complemento + "\n"
					+ "Bairro: " + _cliente.endereco.Bairro + " / Cidade: " + _cliente.endereco.Cidade + " / UF: " + _cliente.endereco.Uf + "\n"
					+ "CEP: " + _cliente.endereco.Cep
					*/
					"Confirmação",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MessageBox.Show("Cadastro Efetuado com sucesso!", "Sucesso!");
					using (var contexto = new LocadoraContext())
					{
						contexto.Cliente.Add(_cliente);
						contexto.SaveChanges();
					}
					this.tabCadastro.Controls.LimparTextBoxes();
					this.groupEndereco.Controls.LimparTextBoxes();

				}

			}
		}

			private void MaskedCEP_Leave(object sender, EventArgs e)
			{
				if (!string.IsNullOrWhiteSpace(maskedCEP.Text))
				{
					try
					{
						var enderecos = new string[4];
						enderecos = Utilidades.BuscaCep(maskedCEP);

						if (enderecos != null)
						{
							txtLogradouro.Text = enderecos[0];
							txtCidade.Text = enderecos[1];
							txtBairro.Text = enderecos[2];
							txtUF.Text = enderecos[3];
						}
						else
						{
							MessageBox.Show("Cep não localizado...");
						}
					}
					catch
					{
						MessageBox.Show("Favor inserir um CEP válido.");
						maskedCEP.Text = "";
						maskedCEP.Focus();
					}
				}
			}

			private void TxtNascimento_Leave(object sender, EventArgs e)
			{
				txtNascimento.IsData();
			}

			private void FormCadastrarCliente_Load(object sender, EventArgs e)
			{

			}

			private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
			{
				txtValor.IsNumeros(e);
			}

			private void txtNrPontos_KeyPress(object sender, KeyPressEventArgs e)
			{
				txtProfissao.IsNumeros(e);
			}

			private void txtValor_Enter(object sender, EventArgs e)
			{
				txtValor.IsDinheiro();
			}

			private void txtValor_Leave(object sender, EventArgs e)
			{
				txtValor.IsDinheiro();
			}

			private void maskedEmitida_Leave(object sender, EventArgs e)
			{
				maskedEmitida.IsData();
			}

			private void maskedValidade_Leave(object sender, EventArgs e)
			{
				maskedValidade.IsData();
			}

			private void maskedVencimentoMulta_Leave(object sender, EventArgs e)
			{
				maskedVencimentoMulta.IsData();
			}

			private void maskedDataMulta_Leave(object sender, EventArgs e)
			{
				maskedDataMulta.IsData();
			}

			private void maskedCpf_Leave(object sender, EventArgs e)
			{
				/*
				if (maskedCpf.Text != null)
				{
					if (!Utilidades.IsCpf(maskedCpf.Text))
					{
						MessageBox.Show("CPF inválido, digite novamente");
						maskedCpf.Text = "";
						maskedCpf.Focus();
					}
				}
				*/
			}
	}
}
