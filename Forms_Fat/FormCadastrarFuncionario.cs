using Dll_DB_Fat;
using Dll_BS_Fat;
using System;
using System.Linq;
using System.Windows.Forms;
using Dll_Utilidades;

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
			this.funcionario = funcionario;
			InitializeComponent();
			PreencherFormulario(funcionario);
		}
		private void FormCadastrarFuncionario_Load(object sender, EventArgs e)
		{
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			var buscaFuncionario = new FormBuscaFuncionario();
			buscaFuncionario.Show();
		}
		private void MaskedCpf_Leave(object sender, EventArgs e)
		{
			if (!Utilidades.ValidarCpf(maskedCpf.Text))
			{
				MessageBox.Show("CPF inválido, digite novamente");
				maskedCpf.Text = "";
				maskedCpf.Focus();
			}
		}
		private void AtualizarFuncionario(Funcionarios funcionario)
		{
			funcionario.Nome = txtNome.Text;
			funcionario.Cpf = maskedCpf.Text;
			funcionario.Rg = txtRG.Text;
			funcionario.Email = txtEmail.Text;
			funcionario.TelResidencial = txtTelRes.Text;
			funcionario.TelCelular = txtTelCel.Text;
			funcionario.Salario = decimal.Parse(txtSalario.Text);
			funcionario.Admissao = dateAdmissao.Value;
			funcionario.Ctps = txtCTPS.Text;
			funcionario.Pis = txtPIS.Text;
			funcionario.TituloEleitor = txtTitEleitor.Text;
			funcionario.Nascimento = dateNascimento.Value;
			funcionario.Demissao = dateDemissao.Value;
			funcionario.Cnh.Numero = txtCNH.Text;
			funcionario.Cnh.Categoria = comboCategoriaCnh.Text;
			funcionario.Cnh.Emissao = dateCnhEmitida.Value;
			funcionario.Cnh.Validade = dateCnhValidade.Value;
			funcionario.Endereco.Cep = maskedCEP.Text;
			funcionario.Endereco.Logradouro = txtLogradouro.Text;
			funcionario.Endereco.Num = txtNumero.Text;
			funcionario.Endereco.Bairro = txtBairro.Text;
			funcionario.Endereco.Cidade = txtCidade.Text;
			funcionario.Endereco.Uf = txtUF.Text;

			int id = Convert.ToInt32(txtId.Text);

			funcionario.Cnh.Id = id;
			funcionario.Endereco.Id = id;

			new FuncionariosDao().DbUpdate(funcionario);
			MessageBox.Show("Dados do funcionário Atualizado com Sucesso.", "Alerta");
			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
		}
		private void CadastrarNovoFuncionario()
		{
			var f = new Funcionarios
			{
				Nome = txtNome.Text,
				Cpf = maskedCpf.Text,
				Rg = txtRG.Text,
				Email = txtEmail.Text,
				TelResidencial = txtTelRes.Text,
				TelCelular = txtTelCel.Text,
				Salario = decimal.Parse(txtSalario.Text),
				Admissao = dateAdmissao.Value,
				Ctps = txtCTPS.Text,
				Pis = txtPIS.Text,
				TituloEleitor = txtTitEleitor.Text,
				Nascimento = dateNascimento.Value,
				Demissao = dateDemissao.Value
			};

			f.Cnh.Numero = txtCNH.Text;
			f.Cnh.Categoria = comboCategoriaCnh.Text;
			f.Cnh.Emissao = dateCnhEmitida.Value;
			f.Cnh.Validade = dateCnhValidade.Value;
			f.Endereco.Cep = maskedCEP.Text;
			f.Endereco.Logradouro = txtLogradouro.Text;
			f.Endereco.Num = txtNumero.Text;
			f.Endereco.Bairro = txtBairro.Text;
			f.Endereco.Cidade = txtCidade.Text;
			f.Endereco.Uf = txtUF.Text;

			new FuncionariosDao().DbAdd(f);
			MessageBox.Show("Funcionário adicionado com Sucesso.", "Alerta");

			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
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
			dateNascimento.Value = f.Nascimento;
			dateDemissao.Value = f.Demissao.Value;
			txtCNH.Text = f.Cnh.Numero;
			comboCategoriaCnh.Text = f.Cnh.Categoria;
			dateCnhEmitida.Value = f.Cnh.Emissao.Value;
			dateCnhValidade.Value = f.Cnh.Validade.Value;
			maskedCEP.Text = f.Endereco.Cep;
			txtLogradouro.Text = f.Endereco.Logradouro;
			txtNumero.Text = f.Endereco.Num;
			txtBairro.Text = f.Endereco.Bairro;
			txtCidade.Text = f.Endereco.Cidade;
			txtUF.Text = f.Endereco.Uf;
		}
		private void BtnSalvar_Click(object sender, EventArgs e)
		{

			if (txtId.Text != "")
			{
				var funcionario = new FuncionariosDao().GetFuncionario(txtId.Text);
				AtualizarFuncionario(funcionario);
			}
			else
			{
				CadastrarNovoFuncionario();
			}

		}
		private void MaskedCEP_Leave_1(object sender, EventArgs e)
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
	}
}

