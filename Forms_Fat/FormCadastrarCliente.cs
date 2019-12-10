using BsFat;
using DbFat;
using Utilidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarCliente : Form
	{
		private Funcionarios funcionario = new Funcionarios();
		private ClientesPJ clientePj = new ClientesPJ();
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
			btnAtualizar.Hide();

		}
		
		public FormCadastrarCliente(ClientesPJ cliente)
		{
			InitializeComponent();
			this.clientePj = cliente;
			PreencherFormulario(clientePj);
			//radioPessoaFisica.Enabled = false;
			//radioPessoaJuridica.Enabled = false;
			btnAtualizar.Show();
		}

		private void FormCadastrarCliente_Load(object sender, EventArgs e)
		{
			LimpaTela();
		}

		private void PreencherId()
		{
			var idCliente = new FuncionariosDao().BuscaIdMax();
			idCliente++;
			txtId.Text = Convert.ToString(idCliente);
		}


		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
			//this.checkAtivo.Checked = true;
			this.lblNome.Focus();
		}
		private void AtualizarPj(ClientesPJ cliente)
		{
			int id = Convert.ToInt32(txtId.Text);
			cliente.Endereco.Id = id;

			EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
				.GetCep(maskedCEP.Text)
				.GetLogradouro(txtLogradouro.Text)
				.GetNumero(txtNumero.Text)
				.GetComplemento(txtComplemento.Text)
				.GetBairro(txtBairro.Text)
				.GetCidade(txtCidade.Text)
				.GetUf(txtUF.Text);
			Enderecos endereco = enderecoBuilder.Build();

			cliente.Endereco = endereco;
			cliente.RazaoSocial = txtNome.Text;
			cliente.Cnpj = maskedCpf.Text;
			cliente.Contato = txtProfissao.Text;
			cliente.Email = txtEmail.Text;
			cliente.Ie = txtRG.Text;
			cliente.TelComercial = txtTelCom.Text;
			cliente.TelCelular = txtTelCel.Text;

			if (MessageBox.Show($"Favor confirmar a atualização:\n" +
								$"Nome da empresa:{cliente.RazaoSocial}\n" +
								$" Cnpj: {cliente.Cnpj} - IE: {cliente.Ie}\n " +
								$"E-Mail: {cliente.Email} - Contato: {cliente.Contato} \n" +
								$"Telefone: {cliente.TelComercial}\n" +
								$"Endereço:\n " +
								$"CEP: {cliente.Endereco.Cep} \n" +
								$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
								$"Bairro: {cliente.Endereco.Bairro}  / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n",
								"Confirmação",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

				if (new ClientesPjDao().DbUpdate(cliente))
				{
					MessageBox.Show("Cadastro Atualizado com sucesso!", "Sucesso!");
					ConfirmaSaida();
				}
				else
				{
					MessageBox.Show("Erro na atualização, tente novamente.");
				}
			}
		}

		private void ConfirmaSaida()
		{
			if (MessageBox.Show("Gostaria de Adicionar outro cliente?","Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				LimpaTela();
			}
			else
			{
				this.Close();
			}
		}

		private void CadastrarPj()
		{
			bool ativo = true;
			//if (checkAtivo.Checked) ativo = true;

			EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
				.GetCep(maskedCEP.Text)
				.GetLogradouro(txtLogradouro.Text)
				.GetNumero(txtNumero.Text)
				.GetComplemento(txtComplemento.Text)
				.GetBairro(txtBairro.Text)
				.GetCidade(txtCidade.Text)
				.GetUf(txtUF.Text);
			var endereco = enderecoBuilder.Build();

			ClientesPJBuilder PjBuilder = new ClientesPJBuilder()
				.GetIsAtivo(ativo)
				.GetRazaoSocial(txtNome.Text)
				.GetCnpj(maskedCpf.Text)
				.GetContato(txtProfissao.Text)
				.GetTelCelular(txtTelCel.Text)
				.GetEmail(txtEmail.Text)
				.GetIe(txtRG.Text)
				.GetTelComercial(txtTelCom.Text)
				.GetEndereco(endereco);
			clientePj = PjBuilder.Build();

			if (MessageBox.Show($"Favor confirmar os dados:\n" +
								$"Nome da empresa:{clientePj.RazaoSocial}\n" +
								$" Cnpj: {clientePj.Cnpj} - IE: {clientePj.Ie}\n " +
								$"E-Mail: {clientePj.Email} - Contato: {clientePj.Contato} \n" +
								$"Telefone: {clientePj.TelComercial}\n" +
								$"Endereço:\n " +
								$"CEP: {clientePj.Endereco.Cep} \n" +
								$"{clientePj.Endereco.Logradouro} {clientePj.Endereco.Num} Complemento: {clientePj.Endereco.Complemento} \n" +
								$"Bairro: {clientePj.Endereco.Bairro}  / Cidade: {clientePj.Endereco.Cidade} / UF: {clientePj.Endereco.Uf} \n",
								"Confirmação",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (new ClientesPjDao().DbAdd(clientePj))
				{
					MessageBox.Show("Cadastro Efetuado com sucesso!", "Sucesso!");
					ConfirmaSaida();
				}
				else
				{
					MessageBox.Show("Erro ao adicionar cliente, tente novamente!");
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
					enderecos = Utilidades.Utilidades.BuscaCep(maskedCEP);

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
		private void PreencherFormulario(ClientesPJ cliente)
		{
			//if (cliente is Motoristas cli)
			//{
			//	radioPessoaFisica.Checked = true;
			//	radioPessoaJuridica.Checked = false;

			//	if (cli.IsAtivo == false)
			//	{
			//		checkAtivo.Checked = false;
			//	}
			//	else
			//	{
			//		checkAtivo.Checked = true;
			//	}
			//	txtId.Text = cli.Id.ToString();
			//	txtNome.Text = cli.Nome;
			//	maskedCpf.Text = cli.Cpf;
			//	txtEmail.Text = cli.Email;
			//	txtRG.Text = cli.Rg;
			//	dateNascimento.Value = cli.Nascimento;
			//	dateCnhEmitida.Value = cli.Cnh.Emissao;
			//	dateCnhValidade.Value = cli.Cnh.Validade;
			//	txtTelCom.Text = cli.TelComercial;
			//	txtTelRes.Text = cli.TelResidencial;
			//	txtTelCel.Text = cli.TelCelular;
			//	txtCNH.Text = cli.Cnh.Numero;
			//	txtCategoria.Text = cli.Cnh.Categoria;

			//	this.groupEndereco.Select();
			//	maskedCEP.Text = cli.Endereco.Cep;
			//	txtLogradouro.Text = cli.Endereco.Logradouro;
			//	txtNumero.Text = cli.Endereco.Num;
			//	txtComplemento.Text = cli.Endereco.Complemento;
			//	txtBairro.Text = cli.Endereco.Bairro;
			//	txtCidade.Text = cli.Endereco.Cidade;
			//	txtUF.Text = cli.Endereco.Uf;
			//}
		
				ClientesPJ c = cliente;

				//radioPessoaJuridica.Checked = true;
				//radioPessoaFisica.Checked = false;

				//if (c.IsAtivo == false)
				//{
				//	checkAtivo.Checked = false;
				//}
				//else
				//{
				//	checkAtivo.Checked = true;
				//}
				txtId.Text = c.Id.ToString();
				txtNome.Text = c.RazaoSocial;
				maskedCpf.Text = c.Cnpj;
				txtProfissao.Text = c.Contato;
				txtEmail.Text = c.Email;
				txtRG.Text = c.Ie;
				txtTelCom.Text = c.TelComercial;
				txtTelCel.Text = c.TelCelular;
				maskedCEP.Text = c.Endereco.Cep;
				txtLogradouro.Text = c.Endereco.Logradouro;
				txtNumero.Text = c.Endereco.Num;
				txtComplemento.Text = c.Endereco.Complemento;
				txtBairro.Text = c.Endereco.Bairro;
				txtCidade.Text = c.Endereco.Cidade;
				txtUF.Text = c.Endereco.Uf;
			
		}
		

		private void BtnSalvar_Click_1(object sender, EventArgs e)
		{

			//if (radioPessoaFisica.Checked == true)
			//{
			//	CadastrarPf();
			//}

			if (validaCliente())
			{
				CadastrarPj();
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


		private void BtnAtualizar_Click(object sender, EventArgs e)
		{
			if (validaCliente())
			{
				int id = Convert.ToInt32(txtId.Text);
				var cliente = new ClientesPjDao().GetById(id);
				AtualizarPj(cliente);
			}
			
			//}
			//else
			//{
			//	var cliente = new MotoristasDao().GetById(id);
			//	AtualizarPf(cliente);
			//}
		}

		private bool validaCliente()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtNome.Text))
			{
				MessageBox.Show("Favor preencher a razão Social do Cliente");
			}
			else if (String.IsNullOrWhiteSpace(maskedCpf.Text))
			{
				MessageBox.Show("Favor informar o CNPJ do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Favor informar o E-Mail do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(txtRG.Text))
			{
				MessageBox.Show("Favor informar a IE do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(txtTelCom.Text))
			{
				MessageBox.Show("Favor informar o Telefone comercial do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(txtProfissao.Text))
			{
				MessageBox.Show("Favor informar um nome de contato do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(txtTelCel.Text))
			{
				MessageBox.Show("Favor informar o celular do contato do cliente.");
			}
			else if (String.IsNullOrWhiteSpace(maskedCEP.Text))
			{
				MessageBox.Show("Favor informar o endereço do cliente.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		
		#region Comentados
		//private void RadioPessoaJuridica_CheckedChanged(object sender, EventArgs e)
		//{
		//	if (radioPessoaJuridica.Checked)
		//	{
		//		RadioPJ();
		//	}
		//	else
		//	{
		//		RadioPF();
		//	}
		//}

		//private void RadioPessoaFisica_CheckedChanged(object sender, EventArgs e)
		//{
		//	if (radioPessoaFisica.Checked == true)
		//	{
		//		RadioPF();
		//	}
		//	else
		//	{
		//		RadioPJ();
		//	}
		//}
		//private void CadastrarPf()
		//{
		//	bool ativo = false;
		//	if (checkAtivo.Checked)
		//	{
		//		ativo = true;
		//	}
		//	CnhsBuilder cnhBuilder = new CnhsBuilder()
		//		.GetEmissao(dateCnhEmitida.Value)
		//		.GetValidade(dateCnhValidade.Value)
		//		.GetNumero(txtCNH.Text)
		//		.GetCategoria(txtCategoria.Text);
		//	Cnhs cnh = cnhBuilder.Build();

		//	EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
		//		.GetCep(maskedCEP.Text)
		//		.GetLogradouro(txtLogradouro.Text)
		//		.GetNumero(txtNumero.Text)
		//		.GetComplemento(txtComplemento.Text)
		//		.GetBairro(txtBairro.Text)
		//		.GetCidade(txtCidade.Text)
		//		.GetUf(txtUF.Text);
		//	Enderecos endereco = enderecoBuilder.Build();

		//	MotoristasBuilder cli = new MotoristasBuilder()
		//		.GetIsAtivo(ativo)
		//		.GetNome(txtNome.Text)
		//		.GetCpf(maskedCpf.Text)
		//		.GetEmail(txtEmail.Text)
		//		.GetRg(txtRG.Text)
		//		.GetNascimento(dateNascimento.Value)
		//		.GetTelComercial(txtTelCom.Text)
		//		.GetTelCelular(txtTelCel.Text)
		//		.GetTelResidencial(txtTelRes.Text)
		//		.GetCnh(cnh)
		//		.GetEndereco(endereco);
		//	clientePf = cli.Build();

		//	if (MessageBox.Show($"Favor confirmar os dados:\n\n" +
		//						$"Nome: {clientePf.Nome}\n" +
		//						$"CPF: {clientePf.Cpf} - RG: {clientePf.Rg}\n" +
		//						$"Email: {clientePf.Email}\n" +
		//						$"Nascimento: {clientePf.Nascimento.ToShortDateString()} \n" +
		//						$"Telefone Comercial: {clientePf.TelComercial} - Residencial {clientePf.TelResidencial} - Celular: {clientePf.TelCelular}\n" +
		//						$"CNH: {clientePf.Cnh.Numero} / Categoria: {clientePf.Cnh.Categoria} \n" +
		//						$"\nEndereço:\n\n" +
		//						$"CEP: {clientePf.Endereco.Cep}\n" +
		//						$"{clientePf.Endereco.Logradouro} {clientePf.Endereco.Num} Complemento: {clientePf.Endereco.Complemento} \n" +
		//						$"Bairro: {clientePf.Endereco.Bairro} / Cidade: {clientePf.Endereco.Cidade} / UF: {clientePf.Endereco.Uf} \n" +
		//						$"",
		//						"Confirmação",
		//						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		new MotoristasDao().DbAdd(clientePf);
		//		MessageBox.Show("Cadastro Efetuado com sucesso!");
		//		LimpaTela();
		//	}
		//}

		//public FormCadastrarCliente(Motoristas cliente)
		//{
		//	InitializeComponent();
		//	this.clientePf = cliente;
		//	PreencherFormulario(clientePf);
		//	radioPessoaFisica.Enabled = false;
		//	radioPessoaJuridica.Enabled = false;
		//	btnAtualizar.Show();
		//}

		//private void AtualizarPf(Motoristas cliente)
		//{
		//	bool ativo = false;
		//	if (checkAtivo.Checked) ativo = true;

		//	EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
		//		.GetCep(maskedCEP.Text)
		//		.GetLogradouro(txtLogradouro.Text)
		//		.GetNumero(txtNumero.Text)
		//		.GetComplemento(txtComplemento.Text)
		//		.GetBairro(txtBairro.Text)
		//		.GetCidade(txtCidade.Text)
		//		.GetUf(txtUF.Text);
		//	var endereco = enderecoBuilder.Build();

		//	CnhsBuilder cnhBuilder = new CnhsBuilder()
		//		.GetEmissao(dateCnhEmitida.Value)
		//		.GetValidade(dateCnhValidade.Value)
		//		.GetNumero(txtCNH.Text)
		//		.GetCategoria(txtCategoria.Text);
		//	var cnh = cnhBuilder.Build();

		//	MotoristasBuilder clienteBuilder = new MotoristasBuilder()
		//		.GetIsAtivo(ativo)
		//		.GetNome(txtNome.Text)
		//		.GetCpf(maskedCpf.Text)
		//		.GetEmail(txtEmail.Text)
		//		.GetRg(txtRG.Text)
		//		.GetNascimento(dateNascimento.Value)
		//		.GetTelComercial(txtTelCom.Text)
		//		.GetTelCelular(txtTelCel.Text)
		//		.GetTelResidencial(txtTelRes.Text)
		//		.GetCnh(cnh)
		//		.GetEndereco(endereco);

		//	cliente = clienteBuilder.Build();

		//	if (MessageBox.Show($"Favor confirmar a atualização dos dados:\n\n" +
		//						$"Nome: {cliente.Nome}\n" +
		//						$"CPF: {cliente.Cpf} - RG: {cliente.Rg}\n" +
		//						$"Email: {cliente.Email}\n" +
		//						$"Nascimento: {cliente.Nascimento.ToShortDateString()} \n" +
		//						$"Telefone Comercial: {cliente.TelComercial} - Residencial {cliente.TelResidencial} - Celular: {cliente.TelCelular}\n" +
		//						$"CNH: {cliente.Cnh.Numero} / Categoria: {cliente.Cnh.Categoria} \n" +
		//						$"\nEndereço:\n\n" +
		//						$"CEP: {cliente.Endereco.Cep}\n" +
		//						$"{cliente.Endereco.Logradouro} {cliente.Endereco.Num} Complemento: {cliente.Endereco.Complemento} \n" +
		//						$"Bairro: {cliente.Endereco.Bairro} / Cidade: {cliente.Endereco.Cidade} / UF: {cliente.Endereco.Uf} \n" +
		//						$"",
		//						"Confirmação",
		//						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		int id = Convert.ToInt32(txtId.Text);

		//		cliente.Cnh.Id = id;
		//		cliente.Endereco.Id = id;

		//		new MotoristasDao().DbAdd(cliente);
		//		MessageBox.Show("Cadastro Atualizado com sucesso!");
		//		LimpaTela();
		//	}
		//} 

		//private void RadioPF()
		//{
		//	lblNome.Text = "Nome";
		//	lblCpf.Text = "CPF";
		//	maskedCpf.Name = "maskedCPF";
		//	this.maskedCpf.Size = new System.Drawing.Size(87, 20);
		//	maskedCpf.Mask = "999.999.999-99";
		//	lblRG.Text = "RG";
		//	lblProfissao.Text = "Profissão";
		//	this.lblProfissao.Location = new System.Drawing.Point(544, 95);
		//	this.txtProfissao.Location = new System.Drawing.Point(544, 111);
		//	lblNascimento.Show();
		//	dateNascimento.Show();
		//	lblCNH.Show();
		//	txtCNH.Show();
		//	lblCategoria.Show();
		//	txtCategoria.Show();
		//	lblEmitida.Show();
		//	dateCnhEmitida.Show();
		//	lblValidade.Show();
		//	dateCnhValidade.Show();
		//	lblTelCel.Show();
		//	txtTelCel.Show();
		//	lblTelRes.Show();
		//	txtTelRes.Show();

		//}
		//private void RadioPJ()
		//{
		//	lblNome.Text = "Razão Social";
		//	lblCpf.Text = "CNPJ";
		//	maskedCpf.Mask = "99.999.999/9999-99";
		//	this.maskedCpf.Size = new System.Drawing.Size(110, 20);
		//	lblRG.Text = "IE";
		//	lblProfissao.Text = "Contato";
		//	this.lblProfissao.Location = new System.Drawing.Point(561, 95);
		//	this.txtProfissao.Location = new System.Drawing.Point(561, 111);
		//	lblTelCom.Text = "Telefone";
		//	lblNascimento.Hide();
		//	dateNascimento.Hide();
		//	lblCNH.Hide();
		//	txtCNH.Hide();
		//	lblCategoria.Hide();
		//	txtCategoria.Hide();
		//	lblEmitida.Hide();
		//	dateCnhEmitida.Hide();
		//	lblValidade.Hide();
		//	dateCnhValidade.Hide();
		//	lblTelCel.Hide();
		//	txtTelCel.Hide();
		//	lblTelRes.Hide();
		//	txtTelRes.Hide();
		//}
		#endregion

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtNumero.IsNumeros(e);
		}
	}
}
