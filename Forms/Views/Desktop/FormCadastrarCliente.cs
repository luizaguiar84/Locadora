using System;
using System.IO;
using System.Windows.Forms;
using Forms;
using Forms.Models;
using Correios.CEP;
using Forms.Views.Desktop;
using System.Linq;

namespace Forms
{
	public partial class FormCadastrarCliente : Form
	{
		private Cliente cliente;

		public FormCadastrarCliente()
		{
			InitializeComponent();
		}

		public FormCadastrarCliente(Cliente cliente)
		{
			this.cliente = cliente;
			InitializeComponent();
			PreencherFormulario(cliente);
		}

		private void PreencherFormulario(Cliente c)
		{
			if (c.TipoCliente == "PF")
			{
				this.tabControl1.SelectTab(0);

				radioPF.Checked = true;
				radioPj.Checked = false;

				if (c.StatusCliente == 0)
				{
					checkAtivo.Checked = false;
				}
				else
				{
					checkAtivo.Checked = true;
				}
				txtId.Text = c.Id.ToString();
				txtNome.Text = c.Nome;
				maskedCpf.Text = c.Cpf;
				txtProfissao.Text = c.Profissao;
				txtEmail.Text = c.Email;
				txtRG.Text = c.Rg;
				txtNascimento.Text = c.Nascimento.ToString().Replace("-", "/");
				txtTelCom.Text = c.TelComercial;
				txtTelRes.Text = c.TelResidencial;
				txtTelCel.Text = c.TelCelular;
				txtCNH.Text = c.Cnh.Numero;
				txtCategoria.Text = c.Cnh.Categoria;
				maskedEmitida.Text = c.Cnh.Emissao.ToString().Replace("-", "/");
				maskedValidade.Text = c.Cnh.Validade.ToString().Replace("-", "/");

				this.groupEndereco.Select();

				maskedCEP.Text = c.Endereco.Cep;
				txtLogradouro.Text = c.Endereco.Logradouro;
				txtNumero.Text = c.Endereco.Num;
				txtComplemento.Text = c.Endereco.Complemento;
				txtBairro.Text = c.Endereco.Bairro;
				txtCidade.Text = c.Endereco.Cidade;
				txtUF.Text = c.Endereco.Uf;
			}
			else
			{
				this.tabControl1.SelectTab(0);

				radioPj.Checked = true;
				radioPF.Checked = false;

				if (c.StatusCliente == 0)
				{
					checkAtivo.Checked = false;
				}
				else
				{
					checkAtivo.Checked = true;
				}
				txtId.Text = c.Id.ToString();
				txtNome.Text = c.Nome;
				maskedCpf.Text = c.Cnpj;
				txtProfissao.Text = c.Contato;
				txtEmail.Text = c.Email;
				txtRG.Text = c.Ie;
				txtTelCom.Text = c.TelComercial;

				groupEndereco.Select();
				maskedCEP.Text = c.Endereco.Cep;
				txtLogradouro.Text = c.Endereco.Logradouro;
				txtNumero.Text = c.Endereco.Num;
				txtComplemento.Text = c.Endereco.Complemento;
				txtBairro.Text = c.Endereco.Bairro;
				txtCidade.Text = c.Endereco.Cidade;
				txtUF.Text = c.Endereco.Uf;
			}
		}

		private void RadioPF()
		{
			lblNome.Text = "Nome";
			lblCpf.Text = "CPF";
			maskedCpf.Name = "maskedCPF";
			this.maskedCpf.Size = new System.Drawing.Size(87, 20);
			maskedCpf.Mask = "999.999.999-99";
			lblRG.Text = "RG";
			lblProfissao.Text = "Profissão";
			this.lblProfissao.Location = new System.Drawing.Point(518, 81);
			this.txtProfissao.Location = new System.Drawing.Point(518, 97);
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
			lblNome.Text = "Razão Social";
			lblCpf.Text = "CNPJ";
			maskedCpf.Mask = "99.999.999/9999-99";
			this.maskedCpf.Size = new System.Drawing.Size(110, 20);
			lblRG.Text = "IE";
			lblProfissao.Text = "Contato";
			this.lblProfissao.Location = new System.Drawing.Point(538, 81);
			this.txtProfissao.Location = new System.Drawing.Point(538, 97);
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

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			var cliente = new Cliente();

			if (txtId.Text != "")
			{
				using (var contexto = new LocadoraContext())
				{
					int id = Convert.ToInt32(txtId.Text);

					var _cliente = contexto.Cliente
								.Where(c => c.Id == id)
									.Single();
				cliente = _cliente;
				}
			}
			
			if (cliente != null)
			{
				if (radioPF.Checked == true)
				{
					AtualizarPf(cliente);
				}
				if (radioPj.Checked == true)
				{
					AtualizarPj(cliente);
				}
			}
			else
			{
				if (radioPF.Checked == true)
				{
					CadastrarPf();
				}
				if (radioPj.Checked == true)
				{
					CadastrarPj();
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

		private void btnSalvarMulta_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			var busca = new FormBuscaCliente();
			busca.MdiParent = this.MdiParent;
			busca.ControlBox = false;
			this.Close();
			busca.Show();
		}

		private void tabCadastro_Click(object sender, EventArgs e)
		{

		}

		private void AtualizarPf(Cliente c)
		{
			if (checkAtivo.Checked)
			{
				c.StatusCliente = 1;
			}
			else
			{
				c.StatusCliente = 0;
			}
			c.TipoCliente = "PF";
			c.Nome = txtNome.Text;
			c.Cpf = maskedCpf.Text;
			c.Profissao = txtProfissao.Text;
			c.Email = txtEmail.Text;
			c.Rg = txtRG.Text;
			if (txtNascimento.Text != "__/__/____")
			{
				c.Nascimento = DateTime.Parse(txtNascimento.Text.Replace("/", "-"));

			}
			
			c.TelComercial = txtTelCom.Text;
			c.TelResidencial = txtTelRes.Text;
			c.TelCelular = txtTelCel.Text;
			c.Cnh.Numero = txtCNH.Text;
			c.Cnh.Categoria = txtCategoria.Text;
			if (maskedEmitida.Text != "__/__/____")
			{
				c.Cnh.Emissao = DateTime.Parse(maskedEmitida.Text.Replace("/", "-"));

			}
			if (maskedValidade.Text != "__/__/____")
			{
				c.Cnh.Validade = DateTime.Parse(maskedValidade.Text.Replace("/", "-"));

			}
			c.Endereco.Cep = maskedCEP.Text;
			c.Endereco.Logradouro = txtLogradouro.Text;
			c.Endereco.Num = txtNumero.Text;
			c.Endereco.Complemento = txtComplemento.Text;
			c.Endereco.Bairro = txtBairro.Text;
			c.Endereco.Cidade = txtCidade.Text;
			c.Endereco.Uf = txtUF.Text;

			if (MessageBox.Show($"Favor confirmar a atualização dos dados:\n\n" +
				$"Nome: {c.Nome}\n" +
				$"CPF: {c.Cpf} - RG: {c.Rg}\n" +
				$"Profissão: {c.Profissao} / Email: {c.Email}\n" +
				$"Nascimento: {c.Nascimento.Value.ToShortDateString()} \n" +
				$"Telefone Comercial: {c.TelComercial} - Residencial {c.TelResidencial} - Celular: {c.TelCelular}\n" +
				$"CNH: {c.Cnh.Numero} / Categoria: {c.Cnh.Categoria} \n" +
				$"\nEndereço:\n\n" +
				$"CEP: {c.Endereco.Cep}\n" +
				$"{c.Endereco.Logradouro} {c.Endereco.Num} Complemento: {c.Endereco.Complemento} \n" +
				$"Bairro: {c.Endereco.Bairro} / Cidade: {c.Endereco.Cidade} / UF: {c.Endereco.Uf} \n" +
				$"",
				"Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				using (var contexto = new LocadoraContext())
				{
					var resultadoCnh = contexto.Cnh
										.Where(cnh => cnh.Id == c.Id)
										.SingleOrDefault();

					var resultadoEndereco = contexto.Endereco
											.Where(endereco => endereco.Id == c.Id)
											.SingleOrDefault();

					c.Cnh = resultadoCnh;
					c.Endereco = resultadoEndereco;

					contexto.Cliente.Update(c);
					contexto.SaveChanges();
				}



				MessageBox.Show("Cadastro Atualizado com sucesso!");

				this.tabCadastro.Controls.LimparTextBoxes();
				this.groupEndereco.Controls.LimparTextBoxes();
				this.checkAtivo.Checked = true;
				this.lblNome.Focus();
			}
		}

		private void AtualizarPj(Cliente c)
		{
			if (checkAtivo.Checked)
			{
				c.StatusCliente = 1;
			}
			else
			{
				c.StatusCliente = 0;
			}
			c.TipoCliente = "PJ";
			c.Nome = txtNome.Text;
			c.Cnpj = maskedCpf.Text;
			c.Contato = txtProfissao.Text;
			c.Email = txtEmail.Text;
			c.Ie = txtRG.Text;
			c.TelComercial = txtTelCom.Text;
			c.Endereco.Cep = maskedCEP.Text;
			c.Endereco.Logradouro = txtLogradouro.Text;
			c.Endereco.Bairro = txtBairro.Text;
			c.Endereco.Cidade = txtCidade.Text;
			c.Endereco.Complemento = txtComplemento.Text;
			c.Endereco.Num = txtNumero.Text;
			c.Endereco.Uf = txtUF.Text;

			if (MessageBox.Show($"Favor confirmar a atualização:\n" +
				$"Nome da empresa:{c.Nome}\n" +
				$" Cnpj: {c.Cnpj} - IE: {c.Ie}\n " +
				$"E-Mail: {c.Email} - Contato: {c.Contato} \n" +
				$"Telefone: {c.TelResidencial}\n" +
				$"Endereço:\n " +
				$"CEP: {c.Endereco.Cep} \n" +
				$"{c.Endereco.Logradouro} {c.Endereco.Num} Complemento: {c.Endereco.Complemento} \n" +
				$"Bairro: {c.Endereco.Bairro}  / Cidade: {c.Endereco.Cidade} / UF: {c.Endereco.Uf} \n",
				"Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MessageBox.Show("Cadastro Atualizado com sucesso!", "Sucesso!");
				using (var contexto = new LocadoraContext())
				{

					var resultadoEndereco = contexto.Endereco
											.Where(endereco => endereco.Id == c.Id)
											.SingleOrDefault();

					c.Endereco = resultadoEndereco;

					contexto.Cliente.Update(c);
					contexto.SaveChanges();
				}
				this.tabCadastro.Controls.LimparTextBoxes();
				this.groupEndereco.Controls.LimparTextBoxes();
				this.checkAtivo.Checked = true;
				this.lblNome.Focus();
			}
		}

		private void CadastrarPj()
		{
			var c = new Cliente();

			if (checkAtivo.Checked)
			{
				c.StatusCliente = 1;
			}
			else
			{
				c.StatusCliente = 0;
			}
			c.TipoCliente = "PJ";
			c.Nome = txtNome.Text;
			c.Cnpj = maskedCpf.Text;
			c.Contato = txtProfissao.Text;
			c.Email = txtEmail.Text;
			c.Ie = txtRG.Text;
			c.TelComercial = txtTelCom.Text;
			c.Endereco.Cep = maskedCEP.Text;
			c.Endereco.Logradouro = txtLogradouro.Text;
			c.Endereco.Bairro = txtBairro.Text;
			c.Endereco.Cidade = txtCidade.Text;
			c.Endereco.Complemento = txtComplemento.Text;
			c.Endereco.Num = txtNumero.Text;
			c.Endereco.Uf = txtUF.Text;

			if (MessageBox.Show($"Favor confirmar os dados:\n" +
				$"Nome da empresa:{c.Nome}\n" +
				$" Cnpj: {c.Cnpj} - IE: {c.Ie}\n " +
				$"E-Mail: {c.Email} - Contato: {c.Contato} \n" +
				$"Telefone: {c.TelResidencial}\n" +
				$"Endereço:\n " +
				$"CEP: {c.Endereco.Cep} \n" +
				$"{c.Endereco.Logradouro} {c.Endereco.Num} Complemento: {c.Endereco.Complemento} \n" +
				$"Bairro: {c.Endereco.Bairro}  / Cidade: {c.Endereco.Cidade} / UF: {c.Endereco.Uf} \n",
				"Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MessageBox.Show("Cadastro Efetuado com sucesso!", "Sucesso!");
				using (var contexto = new LocadoraContext())
				{
					contexto.Cliente.Add(c);
					contexto.SaveChanges();
				}
				this.tabCadastro.Controls.LimparTextBoxes();
				this.groupEndereco.Controls.LimparTextBoxes();
				this.checkAtivo.Checked = true;
				this.lblNome.Focus();
			}
		}

		private void CadastrarPf()
		{
			var c = new Cliente();

			if (checkAtivo.Checked)
			{
				c.StatusCliente = 1;
			}
			else
			{
				c.StatusCliente = 0;
			}
			c.TipoCliente = "PF";
			c.Nome = txtNome.Text;
			c.Cpf = maskedCpf.Text;
			c.Profissao = txtProfissao.Text;
			c.Email = txtEmail.Text;
			c.Rg = txtRG.Text;
			if (txtNascimento.Text != "__/__/____")
			{
				c.Nascimento = DateTime.Parse(txtNascimento.Text.Replace("/", "-"));

			}
			c.TelComercial = txtTelCom.Text;
			c.TelResidencial = txtTelRes.Text;
			c.TelCelular = txtTelCel.Text;
			c.Cnh.Numero = txtCNH.Text;
			c.Cnh.Categoria = txtCategoria.Text;
			
			if (maskedEmitida.Text != "__/__/____")
			{
				c.Cnh.Emissao = DateTime.Parse(maskedEmitida.Text.Replace("/", "-"));

			}
			if (maskedValidade.Text != "__/__/____")
			{
				c.Cnh.Validade = DateTime.Parse(maskedValidade.Text.Replace("/", "-"));

			}
			c.Endereco.Cep = maskedCEP.Text;
			c.Endereco.Logradouro = txtLogradouro.Text;
			c.Endereco.Num = txtNumero.Text;
			c.Endereco.Complemento = txtComplemento.Text;
			c.Endereco.Bairro = txtBairro.Text;
			c.Endereco.Cidade = txtCidade.Text;
			c.Endereco.Uf = txtUF.Text;

			if (MessageBox.Show($"Favor confirmar os dados:\n\n" +
				$"Nome: {c.Nome}\n" +
				$"CPF: {c.Cpf} - RG: {c.Rg}\n" +
				$"Profissão: {c.Profissao} / Email: {c.Email}\n" +
				$"Nascimento: {c.Nascimento.Value.ToShortDateString()} \n" +
				$"Telefone Comercial: {c.TelComercial} - Residencial {c.TelResidencial} - Celular: {c.TelCelular}\n" +
				$"CNH: {c.Cnh.Numero} / Categoria: {c.Cnh.Categoria} \n" +
				$"\nEndereço:\n\n" +
				$"CEP: {c.Endereco.Cep}\n" +
				$"{c.Endereco.Logradouro} {c.Endereco.Num} Complemento: {c.Endereco.Complemento} \n" +
				$"Bairro: {c.Endereco.Bairro} / Cidade: {c.Endereco.Cidade} / UF: {c.Endereco.Uf} \n" +
				$"",
				"Confirmação",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				using (var contexto = new LocadoraContext())
				{
					contexto.Cliente.Add(c);
					contexto.SaveChanges();
				}

				MessageBox.Show("Cadastro Efetuado com sucesso!");

				this.tabCadastro.Controls.LimparTextBoxes();
				this.groupEndereco.Controls.LimparTextBoxes();
				this.checkAtivo.Checked = true;
				this.lblNome.Focus();
			}
		}

		private void maskedCEP_Leave_1(object sender, EventArgs e)
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
	}
}
