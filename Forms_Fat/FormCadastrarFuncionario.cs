using BsFat;
using DbFat;
using Utilidades;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{


	public partial class FormCadastrarFuncionario : Form
	{
		private readonly Funcionarios funcionario;

		#region VALIDACOES
		private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtSalario.IsNumeros(e);
		}

		private void MaskedCpf_KeyPress(object sender, KeyPressEventArgs e)
		{
			maskedCpf.IsNumeros(e);
		}

		#endregion
		public FormCadastrarFuncionario()
		{
			InitializeComponent();
		}
		public FormCadastrarFuncionario(Funcionarios funcionario)
		{
			InitializeComponent();
			this.funcionario = funcionario;
			PreencherFormulario(funcionario);
		}
		private void FormCadastrarFuncionario_Load(object sender, EventArgs e)
		{
			comboCargo.DataSource = new CargosDao().GetAll();		
			comboCargo.DisplayMember = nameof(Cargos.Cargo);
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			var buscaFuncionario = new FormBuscaFuncionario();
			buscaFuncionario.Show();
		}
		private void MaskedCpf_Leave(object sender, EventArgs e)
		{
			if (!Utilidades.Utilidades.ValidarCpf(maskedCpf.Text))
			{
				MessageBox.Show("CPF inválido, digite novamente");
				maskedCpf.Text = "";
				maskedCpf.Focus();
			}
		}
		private void AtualizarFuncionario(Funcionarios funcionario)
		{

			EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
				.GetCep(maskedCEP.Text)
				.GetLogradouro(txtLogradouro.Text)
				.GetNumero(txtNumero.Text)
				.GetComplemento(txtComplemento.Text)
				.GetBairro(txtBairro.Text)
				.GetCidade(txtCidade.Text)
				.GetUf(txtUF.Text);
			var endereco = enderecoBuilder.Build();

			funcionario.Nome = txtNome.Text;
			funcionario.Cpf = maskedCpf.Text;
			funcionario.Rg = txtRG.Text;
			funcionario.Email = txtEmail.Text;
			funcionario.TelResidencial = txtTelRes.Text;
			funcionario.TelCelular = txtTelCel.Text;
			funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
			funcionario.Ctps = txtCTPS.Text;
			funcionario.Pis = txtPIS.Text;
			funcionario.TituloEleitor = txtTitEleitor.Text;
			funcionario.Nascimento = dateNascimento.Value;
			funcionario.Endereco = endereco;

			int id = Convert.ToInt32(txtId.Text);
			funcionario.Endereco.Id = id;

			if (new FuncionariosDao().DbUpdate(funcionario))
			{
				MessageBox.Show("Dados do funcionário Atualizado com Sucesso.", "Alerta");
				if (funcionario.CnhId == 0)
				{
					if (!CriarCnh(funcionario))
					{
						ConfirmaSaida();
					}
				}
				else
				{
					ConfirmaSaida();
				}
			}
			else
			{
				MessageBox.Show("Erro na atualização do funcionário, tente novamente!");
			}
		}
		private void CadastrarNovoFuncionario(Funcionarios funcionario)
		{

			CnhsBuilder cnhBuilder = new CnhsBuilder()
				.GetEmissao(DateTime.Now)
				.GetValidade(DateTime.Now)
				.GetNumero("")
				.GetCategoria("");
			var cnh = cnhBuilder.Build();

			EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
				.GetCep(maskedCEP.Text)
				.GetLogradouro(txtLogradouro.Text)
				.GetNumero(txtNumero.Text)
				.GetComplemento(txtComplemento.Text)
				.GetBairro(txtBairro.Text)
				.GetCidade(txtCidade.Text)
				.GetUf(txtUF.Text);
			var endereco = enderecoBuilder.Build();

			FuncionariosBuilder FBuilder = new FuncionariosBuilder()
				.GetNome(txtNome.Text)
				.GetCpf(maskedCpf.Text)
				.GetRg(txtRG.Text)
				.GetEmail(txtEmail.Text)
				.GetTelResidencial(txtTelRes.Text)
				.GetTelCelular(txtTelCel.Text)
				.GetSalario(Convert.ToDecimal(txtSalario.Text))
				.GetAdmissao(dateAdmissao.Value)
				.GetCtps(txtCTPS.Text)
				.GetPis(txtPIS.Text)
				.GetTituloEleitor(txtTitEleitor.Text)
				.GetNascimento(dateNascimento.Value)
				//.GetDemissao(dateDemissao.Value)
				.GetEndereco(endereco);

			funcionario = FBuilder.Build();
			funcionario.CargoId = ((Cargos)comboCargo.SelectedItem).Id;
			funcionario.Cnh = cnh;
			if (new FuncionariosDao().DbAdd(funcionario))
			{
				MessageBox.Show("Funcionário adicionado com Sucesso.", "Alerta");
				if (!CriarCnh(funcionario))
				{
					ConfirmaSaida();
				}
				else
				{
					MessageBox.Show("Erro na adição do funcionario, tente novamente!");
				}
			}
		}

		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
		}

		private void ConfirmaSaida()
		{
			if (MessageBox.Show("Gostaria de adicionar um novo funcionario?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				LimpaTela();
			}
			else
			{
				this.Close();
			}
		}

		private static bool CriarCnh(Funcionarios funcionario)
		{
			bool ret = false;
			if (MessageBox.Show("Adicionar uma CNH ao funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				var cadastrarCnh = new FormCadastrarMotorista(funcionario);
				cadastrarCnh.Show();
				return true;
			}
			return ret;
		}

		private void PreencherFormulario(Funcionarios f)
		{
			txtId.Text = f.Id.ToString();
			txtNome.Text = f.Nome;
			maskedCpf.Text = f.Cpf;
			txtRG.Text = f.Rg;
			txtEmail.Text = f.Email;
			txtTelRes.Text = f.TelResidencial;
			txtTelCel.Text = f.TelCelular;
			txtSalario.Text = f.Salario.ToString();
			dateAdmissao.Value = f.Admissao;
			txtCTPS.Text = f.Ctps;
			txtPIS.Text = f.Pis;
			txtTitEleitor.Text = f.TituloEleitor;
			dateNascimento.Text = f.Nascimento.ToString();
			//dateDemissao.Value = f.Demissao.Value;
			maskedCEP.Text = f.Endereco.Cep;
			txtLogradouro.Text = f.Endereco.Logradouro;
			txtNumero.Text = f.Endereco.Num;
			txtBairro.Text = f.Endereco.Bairro;
			txtCidade.Text = f.Endereco.Cidade;
			txtUF.Text = f.Endereco.Uf;
			
				if (f.Cnh.Numero != "")
			{
				groupCNH.Visible = true;
				txtCNH.Text = f.Cnh.Numero;
				txtCategoria.Text = f.Cnh.Categoria;
				dateEmitida.Value = f.Cnh.Emissao;
				dateValidade.Value = f.Cnh.Validade;
			}
		}
		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			if (validaFuncionario())
			{
				var funcionario = new Funcionarios();

				if (txtId.Text != "")
				{
					funcionario = new FuncionariosDao().GetFuncionario(txtId.Text);
					AtualizarFuncionario(funcionario);
				}
				else
				{
					CadastrarNovoFuncionario(funcionario);
				}
			}
		}

		private bool validaFuncionario()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtNome.Text))
			{
				MessageBox.Show("Favor preencher o nome do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(maskedCpf.Text))
			{
				MessageBox.Show("Favor preencher o CPF do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtRG.Text))
			{
				MessageBox.Show("Favor preencher o RG do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Favor preencher o Email do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtTelCel.Text))
			{
				MessageBox.Show("Favor preencher o Telefone Celular do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtSalario.Text))
			{
				MessageBox.Show("Favor preencher o Salário do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(comboCargo.Text))
			{
				if (comboCargo.Items.Count < 1)
				{
					MessageBox.Show("Nenhum Cargo Cadastrado, Favor Cadastrar na área correspondente.");
				}
				MessageBox.Show("Favor preencher o Cargo do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtCTPS.Text))
			{
				MessageBox.Show("Favor preencher o numero da CTPS do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtPIS.Text))
			{
				MessageBox.Show("Favor preencher o PIS do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(txtTitEleitor.Text))
			{
				MessageBox.Show("Favor preencher o Titulo de eleitor do funcionário.");
			}
			else if (String.IsNullOrWhiteSpace(maskedCEP.Text))
			{
				MessageBox.Show("Favor preencher o endereço do funcionário.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void MaskedCEP_Leave_1(object sender, EventArgs e)
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
		private void BtnLocalizar_Click(object sender, EventArgs e)
		{
			var busca = new FormBuscaFuncionario
			{
				MdiParent = this.MdiParent,
				ControlBox = false
			};

			this.Close();
			busca.Show();

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void btnAtualizarCnh_Click(object sender, EventArgs e)
		{
			var atualizar = new FormCadastrarMotorista(funcionario);
			atualizar.Show();

		}

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtNumero.IsNumeros(e);
		}
	}
}

