using Dll_BS_Fat;
using Dll_DB_Fat;
using Dll_Utilidades;
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

			EnderecosBuilder enderecoBuilder = new EnderecosBuilder()
				.GetCep(maskedCEP.Text)
				.GetLogradouro(txtLogradouro.Text)
				.GetNumero(txtNumero.Text)
				.GetComplemento(txtComplemento.Text)
				.GetBairro(txtBairro.Text)
				.GetCidade(txtCidade.Text)
				.GetUf(txtUF.Text);
			var endereco = enderecoBuilder.Build();

			CnhsBuilder cnhBuilder = new CnhsBuilder()
				.GetEmissao(dateCnhEmitida.Value)
				.GetValidade(dateCnhValidade.Value)
				.GetNumero(txtCNH.Text)
				.GetCategoria(comboCategoriaCnh.Text);
			var cnh = cnhBuilder.Build();

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
				.GetDemissao(dateDemissao.Value)
				.GetEndereco(endereco)
				.GetCnh(cnh);

			funcionario = FBuilder.Build();

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
			CnhsBuilder cnhBuilder = new CnhsBuilder()
				.GetEmissao(dateCnhEmitida.Value)
				.GetValidade(dateCnhValidade.Value)
				.GetNumero(txtCNH.Text)
				.GetCategoria(comboCategoriaCnh.Text);
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
				.GetDemissao(dateDemissao.Value)
				.GetEndereco(endereco)
				.GetCnh(cnh);

			Funcionarios funcionario = FBuilder.Build();

			
			new FuncionariosDao().DbAdd(funcionario);
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
			dateNascimento.Text = f.Nascimento.ToString();
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

