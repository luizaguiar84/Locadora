using System;
using System.IO;
using System.Windows.Forms;
using Forms;
using Forms.Entidades;
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
			var _telefone = new Telefonecliente();
			_cliente.endereco = new Endereco();

			if (radioPF.Checked == true)
			{
				_cliente.NOME_CLIENTE = txtNome.Text;
				_cliente.CPF = maskedCpf.Text;
				_cliente.PROFISSAO = txtProfissao.Text;
				_cliente.EMAIL = txtEmail.Text;
				_cliente.RG = txtRG.Text;
					//string nasc = txtNascimento.Text.Replace("/", "-");
					//client.DT_NASCIMENTO = DateTime.Parse(nasc);
				_telefone.NUMTELEFONE = txtTelRes.Text;
				_cliente.endereco.CEP = maskedCEP.Text;
				_cliente.endereco.LOGRADOURO = txtLogradouro.Text;
				_cliente.endereco.BAIRRO = txtBairro.Text;
				_cliente.endereco.CIDADE = txtCidade.Text;
				_cliente.endereco.COMPLEMENTO = txtComplemento.Text;
				_cliente.endereco.NUM = txtNumero.Text;
				_cliente.endereco.UF = txtUF.Text;

				if (MessageBox.Show("Favor confirmar os dados:\n"
					+ _cliente.NOME_CLIENTE + "\n"
					+ _cliente.DT_NASCIMENTO + "\n"
					+ "E-Mail: " + _cliente.EMAIL + "\n"
					+ "Profissao: " + _cliente.PROFISSAO + "\n"
					+ "Telefone: " + _telefone.NUMTELEFONE + "\n"
					+ "Endereço: " + _cliente.endereco.LOGRADOURO + ", " + _cliente.endereco.NUM + " Complemento: " + _cliente.endereco.COMPLEMENTO + "\n"
					+ "Bairro: " + _cliente.endereco.BAIRRO + " / Cidade: " + _cliente.endereco.CIDADE + " / UF: " + _cliente.endereco.UF + "\n"
					+ "CEP: " + _cliente.endereco.CEP,
					"Confirmação",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MessageBox.Show("Cadastro Efetuado com sucesso!");

					this.tabCadastro.Controls.LimparTextBoxes();
					this.groupEndereco.Controls.LimparTextBoxes();
					this.Close();

					//escrevendo no arquivo (teste)
					try
					{
						var caminhoArquivo = "testeCliente.txt";
						using (var fs = new FileStream(caminhoArquivo, FileMode.Create))
						using (var escritor = new StreamWriter(fs))
						{
							escritor.WriteLine($"Nome: {_cliente.NOME_CLIENTE}, Email: {_cliente.EMAIL} \n Endereço: {_cliente.endereco.LOGRADOURO}," +
								$" {_cliente.endereco.NUM}. Bairro: {_cliente.endereco.BAIRRO} Cidade: {_cliente.endereco.CIDADE} " +
								$"UF: {_cliente.endereco.UF}");

						}
					}
					catch
					{
						MessageBox.Show("Erro na gravaçao do arquivo.");
					}
				}
			}
			if (radioPj.Checked == true)
			{
				_cliente.NOME_CLIENTE = txtNome.Text;
				_cliente.CNPJ = maskedCpf.Text;
				_cliente.PROFISSAO = txtProfissao.Text;
				_cliente.EMAIL = txtEmail.Text;
				_cliente.IE = txtRG.Text;
				_telefone.NUMTELEFONE = txtTelRes.Text;
				_cliente.endereco.CEP = maskedCEP.Text;
				_cliente.endereco.LOGRADOURO = txtLogradouro.Text;
				_cliente.endereco.BAIRRO = txtBairro.Text;
				_cliente.endereco.CIDADE = txtCidade.Text;
				_cliente.endereco.COMPLEMENTO = txtComplemento.Text;
				_cliente.endereco.NUM = txtNumero.Text;
				_cliente.endereco.UF = txtUF.Text;

				if (MessageBox.Show("Favor confirmar os dados:\n"
					+ "Nome da empresa: " + _cliente.NOME_CLIENTE + "\n"
					+ "E-Mail: " + _cliente.EMAIL + "\n"
					+ "Contato: " + _cliente.PROFISSAO + "\n"
					+ "Telefone: " + _telefone.NUMTELEFONE + "\n"
					+ "Endereço: " + _cliente.endereco.LOGRADOURO + ", " + _cliente.endereco.NUM + " Complemento: " + _cliente.endereco.COMPLEMENTO + "\n"
					+ "Bairro: " + _cliente.endereco.BAIRRO + " / Cidade: " + _cliente.endereco.CIDADE + " / UF: " + _cliente.endereco.UF + "\n"
					+ "CEP: " + _cliente.endereco.CEP,
					"Confirmação",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MessageBox.Show("Cadastro Efetuado com sucesso!", "Sucesso!");

					this.tabCadastro.Controls.LimparTextBoxes();
					this.groupEndereco.Controls.LimparTextBoxes();
					this.Close();
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
