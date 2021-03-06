﻿using System;
using System.Windows.Forms;
using Dll_Utilidades;
using Dll_BS_Fat;
using Dll_DB_Fat;
using System.Linq;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarCliente : Form
	{
		private Clientes cliente;
		#region VALIDACOES
		private void TxtNrPontos_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtProfissao.IsNumeros(e);
		}
		#endregion

		public FormCadastrarCliente()
		{
			InitializeComponent();
			PreencherId();
		}
		public FormCadastrarCliente(Clientes cliente)
		{
			InitializeComponent();
			this.cliente = cliente;
			PreencherFormulario(cliente);
		}

		private void FormCadastrarCliente_Load(object sender, EventArgs e)
		{

		}

		private void PreencherId()
		{
			var idCliente = new ClientesDao().BuscaId();
			idCliente++;
			txtId.Text = Convert.ToString(idCliente);
		}

		private void AtualizarPf(Clientes cliente)
		{
			var _cliente = new Clientes
			{
				TipoCliente = "PF",
				Nome = txtNome.Text,
				Cpf = maskedCpf.Text,
				Profissao = txtProfissao.Text,
				Email = txtEmail.Text,
				Rg = txtRG.Text,
				Nascimento = dateNascimento.Value,
				TelComercial = txtTelCom.Text,
				TelResidencial = txtTelRes.Text,
				TelCelular = txtTelCel.Text
			};

			if (checkAtivo.Checked)
			{
				cliente.IsAtivo = true;
			}
			else
			{
				cliente.IsAtivo = false;
			}

			var cnh = new Cnhs
			{
				Numero = txtCNH.Text,
				Categoria = txtCategoria.Text,
				Emissao = dateCnhEmitida.Value,
				Validade = dateCnhValidade.Value
			};
			_cliente.Cnh = cnh;

			var endereco = new Enderecos
			{
				Cep = maskedCEP.Text,
				Logradouro = txtLogradouro.Text,
				Num = txtNumero.Text,
				Complemento = txtComplemento.Text,
				Bairro = txtBairro.Text,
				Cidade = txtCidade.Text,
				Uf = txtUF.Text
			};
			_cliente.Endereco = endereco;

			if (MessageBox.Show($"Favor confirmar a atualização dos dados:\n\n" +
								$"Nome: {cliente.Nome}\n" +
								$"CPF: {cliente.Cpf} - RG: {cliente.Rg}\n" +
								$"Profissão: {cliente.Profissao} / Email: {cliente.Email}\n" +
								$"Nascimento: {cliente.Nascimento.Value.ToShortDateString()} \n" +
								$"Telefone Comercial: {cliente.TelComercial} - Residencial {cliente.TelResidencial} - Celular: {cliente.TelCelular}\n" +
								$"CNH: {cliente.Cnh.Numero} / Categoria: {cliente.Cnh.Categoria} \n" +
								$"\nEndereço:\n\n" +
								$"CEP: {cliente.Endereco.Cep}\n" +
								$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
								$"Bairro: {cliente.Endereco.Bairro} / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n" +
								$"",
								"Confirmação",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				int id = Convert.ToInt32(txtId.Text);

				cliente = _cliente;
				cliente.Cnh.Id = id;
				cliente.Endereco.Id = id;

				var resultado = new ClientesDao().DbAdd(cliente);
				if (resultado)
				{
					MessageBox.Show("Cadastro Atualizado com sucesso!");
					LimpaTela();
				}
				else
				{
					MessageBox.Show("Erro na adição do cadastro.");
				}
				
			}
		}
		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
			this.checkAtivo.Checked = true;
			this.lblNome.Focus();
		}
		private void AtualizarPj(Clientes cliente)
		{
			if (checkAtivo.Checked)
			{
				cliente.IsAtivo = true;
			}
			else
			{
				cliente.IsAtivo = false;
			}
			cliente.TipoCliente = "PJ";
			cliente.Nome = txtNome.Text;
			cliente.Cnpj = maskedCpf.Text;
			cliente.Contato = txtProfissao.Text;
			cliente.Email = txtEmail.Text;
			cliente.Ie = txtRG.Text;
			cliente.TelComercial = txtTelCom.Text;
			cliente.Endereco.Cep = maskedCEP.Text;
			cliente.Endereco.Logradouro = txtLogradouro.Text;
			cliente.Endereco.Bairro = txtBairro.Text;
			cliente.Endereco.Cidade = txtCidade.Text;
			cliente.Endereco.Complemento = txtComplemento.Text;
			cliente.Endereco.Num = txtNumero.Text;
			cliente.Endereco.Uf = txtUF.Text;

			if (MessageBox.Show($"Favor confirmar a atualização:\n" +
								$"Nome da empresa:{cliente.Nome}\n" +
								$" Cnpj: {cliente.Cnpj} - IE: {cliente.Ie}\n " +
								$"E-Mail: {cliente.Email} - Contato: {cliente.Contato} \n" +
								$"Telefone: {cliente.TelResidencial}\n" +
								$"Endereço:\n " +
								$"CEP: {cliente.Endereco.Cep} \n" +
								$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
								$"Bairro: {cliente.Endereco.Bairro}  / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n",
								"Confirmação",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MessageBox.Show("Cadastro Atualizado com sucesso!", "Sucesso!");
				int id = Convert.ToInt32(txtId.Text);

				cliente.Endereco.Id = id;

				new ClientesDao().DbUpdate(cliente);

				LimpaTela();
			}
		}
		private void CadastrarPj()
		{
			var cliente = new Clientes
			{
				TipoCliente = "PJ",
				Nome = txtNome.Text,
				Cnpj = maskedCpf.Text,
				Contato = txtProfissao.Text,
				Email = txtEmail.Text,
				Ie = txtRG.Text,
				TelComercial = txtTelCom.Text
			};

			if (checkAtivo.Checked)
			{
				cliente.IsAtivo = true;
			}
			else
			{
				cliente.IsAtivo = false;
			}

			var endereco = new Enderecos
			{
				Cep = maskedCEP.Text,
				Logradouro = txtLogradouro.Text,
				Bairro = txtBairro.Text,
				Cidade = txtCidade.Text,
				Complemento = txtComplemento.Text,
				Num = txtNumero.Text,
				Uf = txtUF.Text
			};
			cliente.Endereco = endereco;

			if (MessageBox.Show($"Favor confirmar os dados:\n" +
								$"Nome da empresa:{cliente.Nome}\n" +
								$" Cnpj: {cliente.Cnpj} - IE: {cliente.Ie}\n " +
								$"E-Mail: {cliente.Email} - Contato: {cliente.Contato} \n" +
								$"Telefone: {cliente.TelResidencial}\n" +
								$"Endereço:\n " +
								$"CEP: {cliente.Endereco.Cep} \n" +
								$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
								$"Bairro: {cliente.Endereco.Bairro}  / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n",
								"Confirmação",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MessageBox.Show("Cadastro Efetuado com sucesso!", "Sucesso!");

				new ClientesDao().DbAdd(cliente);

				LimpaTela();
			}
		}
		private void CadastrarPf()
		{
			var cliente = new Clientes
			{
				TipoCliente = "PF",
				Nome = txtNome.Text,
				Cpf = maskedCpf.Text,
				Profissao = txtProfissao.Text,
				Email = txtEmail.Text,
				Rg = txtRG.Text,
				Nascimento = dateNascimento.Value,
				TelComercial = txtTelCom.Text,
				TelResidencial = txtTelRes.Text,
				TelCelular = txtTelCel.Text
			};

			if (checkAtivo.Checked)
			{
				cliente.IsAtivo = true;
			}
			else
			{
				cliente.IsAtivo = false;
			}

			var cnh = new Cnhs
			{
				Emissao = dateCnhEmitida.Value,
				Validade = dateCnhValidade.Value,
				Numero = txtCNH.Text,
				Categoria = txtCategoria.Text
			};

			var endereco = new Enderecos
			{
				Cep = maskedCEP.Text,
				Logradouro = txtLogradouro.Text,
				Num = txtNumero.Text,
				Complemento = txtComplemento.Text,
				Bairro = txtBairro.Text,
				Cidade = txtCidade.Text,
				Uf = txtUF.Text
			};

			cliente.Cnh = cnh;
			cliente.Endereco = endereco;

			if (MessageBox.Show($"Favor confirmar os dados:\n\n" +
								$"Nome: {cliente.Nome}\n" +
								$"CPF: {cliente.Cpf} - RG: {cliente.Rg}\n" +
								$"Profissão: {cliente.Profissao} / Email: {cliente.Email}\n" +
								$"Nascimento: {cliente.Nascimento.Value.ToShortDateString()} \n" +
								$"Telefone Comercial: {cliente.TelComercial} - Residencial {cliente.TelResidencial} - Celular: {cliente.TelCelular}\n" +
								$"CNH: {cliente.Cnh.Numero} / Categoria: {cliente.Cnh.Categoria} \n" +
								$"\nEndereço:\n\n" +
								$"CEP: {cliente.Endereco.Cep}\n" +
								$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
								$"Bairro: {cliente.Endereco.Bairro} / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n" +
								$"",
								"Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

				var resultado = new ClientesDao().DbAdd(cliente);
				if (resultado)
				{
					MessageBox.Show("Cadastro Efetuado com sucesso!");
					LimpaTela();
				}
				else
				{
					MessageBox.Show("Erro no salvamento, favor conferir os dados");
				}
			}
		}
		private void PreencheEndereco()
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
		private void PreencherFormulario(Clientes cliente)
		{
			if (cliente.TipoCliente == "PF")
			{
				radioPessoaFisica.Checked = true;
				radioPessoaJuridica.Checked = false;

				if (cliente.IsAtivo == false)
				{
					checkAtivo.Checked = false;
				}
				else
				{
					checkAtivo.Checked = true;
				}
				txtId.Text = cliente.Id.ToString();
				txtNome.Text = cliente.Nome;
				maskedCpf.Text = cliente.Cpf;
				txtProfissao.Text = cliente.Profissao;
				txtEmail.Text = cliente.Email;
				txtRG.Text = cliente.Rg;
				dateNascimento.Value = (DateTime)cliente.Nascimento;
				dateCnhEmitida.Value = (DateTime)cliente.Cnh.Emissao;
				dateCnhValidade.Value = (DateTime)cliente.Cnh.Validade;
				txtTelCom.Text = cliente.TelComercial;
				txtTelRes.Text = cliente.TelResidencial;
				txtTelCel.Text = cliente.TelCelular;
				txtCNH.Text = cliente.Cnh.Numero;
				txtCategoria.Text = cliente.Cnh.Categoria;

				this.groupEndereco.Select();
				maskedCEP.Text = cliente.Endereco.Cep;
				txtLogradouro.Text = cliente.Endereco.Logradouro;
				txtNumero.Text = cliente.Endereco.Num;
				txtComplemento.Text = cliente.Endereco.Complemento;
				txtBairro.Text = cliente.Endereco.Bairro;
				txtCidade.Text = cliente.Endereco.Cidade;
				txtUF.Text = cliente.Endereco.Uf;
			}
			else
			{
				radioPessoaJuridica.Checked = true;
				radioPessoaFisica.Checked = false;

				if (cliente.IsAtivo == false)
				{
					checkAtivo.Checked = false;
				}
				else
				{
					checkAtivo.Checked = true;
				}
				txtId.Text = cliente.Id.ToString();
				txtNome.Text = cliente.Nome;
				maskedCpf.Text = cliente.Cnpj;
				txtProfissao.Text = cliente.Contato;
				txtEmail.Text = cliente.Email;
				txtRG.Text = cliente.Ie;
				txtTelCom.Text = cliente.TelComercial;
				maskedCEP.Text = cliente.Endereco.Cep;
				txtLogradouro.Text = cliente.Endereco.Logradouro;
				txtNumero.Text = cliente.Endereco.Num;
				txtComplemento.Text = cliente.Endereco.Complemento;
				txtBairro.Text = cliente.Endereco.Bairro;
				txtCidade.Text = cliente.Endereco.Cidade;
				txtUF.Text = cliente.Endereco.Uf;
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
			this.lblProfissao.Location = new System.Drawing.Point(544, 95);
			this.txtProfissao.Location = new System.Drawing.Point(544, 111);
			lblNascimento.Show();
			dateNascimento.Show();
			lblCNH.Show();
			txtCNH.Show();
			lblCategoria.Show();
			txtCategoria.Show();
			lblEmitida.Show();
			dateCnhEmitida.Show();
			lblValidade.Show();
			dateCnhValidade.Show();
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
			this.lblProfissao.Location = new System.Drawing.Point(561, 95);
			this.txtProfissao.Location = new System.Drawing.Point(561, 111);
			lblTelCom.Text = "Telefone";
			lblNascimento.Hide();
			dateNascimento.Hide();
			lblCNH.Hide();
			txtCNH.Hide();
			lblCategoria.Hide();
			txtCategoria.Hide();
			lblEmitida.Hide();
			dateCnhEmitida.Hide();
			lblValidade.Hide();
			dateCnhValidade.Hide();
			lblTelCel.Hide();
			txtTelCel.Hide();
			lblTelRes.Hide();
			txtTelRes.Hide();
		}
		private void RadioPessoaFisica_CheckedChanged(object sender, EventArgs e)
		{
			if (radioPessoaFisica.Checked == true)
			{
				RadioPF();
			}
			else
			{
				RadioPJ();
			}
		}
		private void BtnSalvar_Click_1(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtId.Text);
			var cliente = new ClientesDao().GetAll()
							.Where(c => c.Id == id)
							.SingleOrDefault();
		
			if (cliente != null)
			{
				if (cliente.TipoCliente == "PF")
				{
					AtualizarPf(cliente);
				}
				else
				{
					AtualizarPj(cliente);
				}
			}
			else
			{
				if (radioPessoaFisica.Checked == true)
				{
					CadastrarPf();
				}
				if (radioPessoaJuridica.Checked == true)
				{
					CadastrarPj();
				}
			}
		}
		private void MaskedCEP_Leave(object sender, EventArgs e)
		{
			PreencheEndereco();
		}
		private void BtnLocalizar_Click(object sender, EventArgs e)
		{
			var busca = new FormBuscaCliente
			{
				MdiParent = this.MdiParent,
				ControlBox = false
			};

			this.Close();
			busca.Show();
		}
		private void RadioPessoaJuridica_CheckedChanged(object sender, EventArgs e)
		{
			if (radioPessoaJuridica.Checked)
			{
				RadioPJ();
			}
			else
			{
				RadioPF();
			}
		}
	}
}
