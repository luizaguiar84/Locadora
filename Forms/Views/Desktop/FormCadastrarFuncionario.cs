using Forms.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{

	public partial class FormCadastrarFuncionario : Form
	{
		private Funcionarios funcionario;

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

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaFuncionario buscaFuncionario = new FormBuscaFuncionario();
			buscaFuncionario.Show();
		}

	private void maskedCpf_Leave(object sender, EventArgs e)
		{
			if (!Utilidades.IsCpf(maskedCpf.Text))
			{
				MessageBox.Show("CPF inválido, digite novamente");
				maskedCpf.Text = "";
				maskedCpf.Focus();
			}
		}

		private void btnSalvar_Click_1(object sender, EventArgs e)
		{
			var funcionario = new Funcionarios();

			if (txtId.Text != "")
			{
				using (var contexto = new LocadoraContext())
				{
					int id = Convert.ToInt32(txtId.Text);

					var _funcionario = contexto.Funcionarios
								.Where(f => f.Id == id)
									.Single();

					funcionario = _funcionario;
				}
			}

			if (funcionario != null)
			{
				AtualizarFuncionario(funcionario);
	
			}
			else
			{
				CadastrarNovoFuncionario();
			}
		}

		private void AtualizarFuncionario(Funcionarios f)
		{
			f.Nome = txtNome.Text;
			f.Cpf = maskedCpf.Text;
			f.Rg = txtRG.Text;
			f.Email = txtEmail.Text;
			f.TelResidencial = txtTelRes.Text;
			f.TelCelular = txtTelCel.Text;
			f.Salario = decimal.Parse(txtSalario.Text);
			f.Admissao = DateTime.Parse(maskedDataAdmissao.Text.Replace("/", "-"));
			f.Ctps = txtCTPS.Text;
			f.Pis = txtPIS.Text;
			f.TituloEleitor = txtTitEleitor.Text;
			f.Nascimento = DateTime.Parse(maskedNascimento.Text.Replace("/", "-"));

			if (maskedDataDemissao.Text != "__/__/____")
			{
				f.Demissao = DateTime.Parse(maskedDataDemissao.Text.Replace("/", "-"));

			}
			f.Cnh.Numero = txtCNH.Text;
			f.Cnh.Categoria = txtCategoriaCNH.Text;
			f.Cnh.Emissao = DateTime.Parse(maskedEmitidaCNH.Text.Replace("/", "-"));
			f.Cnh.Validade = DateTime.Parse(maskedValidadeCNH.Text.Replace("/", "-"));
			f.Endereco.Cep = maskedCEP.Text;
			f.Endereco.Logradouro = txtLogradouro.Text;
			f.Endereco.Num = txtNumero.Text;
			f.Endereco.Bairro = txtBairro.Text;
			f.Endereco.Cidade = txtCidade.Text;
			f.Endereco.Uf = txtUF.Text;

			using (var contexto = new LocadoraContext())
			{
				int id = Convert.ToInt32(txtId.Text);

				f.Cnh.Id = id;
				f.Endereco.Id = id;

				contexto.Funcionarios.Update(f);
				contexto.SaveChanges();
			}
			MessageBox.Show("Dados do funcionário Atualizado com Sucesso.", "Alerta");

			this.tabInfoFuncionarios.Controls.LimparTextBoxes();
			this.Controls.LimparTextBoxes();
			this.groupEndereco.Controls.LimparTextBoxes();
		}
	

		private void maskedCEP_Leave(object sender, EventArgs e)
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

		private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtSalario.IsNumeros(e);
		}

		private void maskedCpf_KeyPress(object sender, KeyPressEventArgs e)
		{
			maskedCpf.IsNumeros(e);
		}

		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtValor.IsNumeros(e);
		}

		private void txtNrPontos_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtNrPontos.IsNumeros(e);
		}

		private void txtValor_Enter(object sender, EventArgs e)
		{
			txtValor.IsDinheiro();
		}

		private void txtValor_Leave(object sender, EventArgs e)
		{
			txtValor.IsDinheiro();
		}

		private void maskedDataMulta_Leave(object sender, EventArgs e)
		{
			maskedDataMulta.IsData();
		}

		private void maskedVencimentoMulta_Leave(object sender, EventArgs e)
		{
			maskedVencimentoMulta.IsData();
		}

		private void maskedNascimento_Leave(object sender, EventArgs e)
		{
			maskedNascimento.IsData();
		}

		private void maskedDataAdmissao_Leave(object sender, EventArgs e)
		{
			maskedDataAdmissao.IsData();
		}

		private void maskedDataDemissao_Leave(object sender, EventArgs e)
		{
			maskedDataDemissao.IsData();
		}

		private void maskedEmitidaCNH_Leave(object sender, EventArgs e)
		{
			maskedEmitidaCNH.IsData();
		}

		private void maskedValidadeCNH_Leave(object sender, EventArgs e)
		{
			maskedValidadeCNH.IsData();
		}

		private void CadastrarNovoFuncionario()
		{
			var f = new Funcionarios();

			f.Nome = txtNome.Text;
			f.Cpf = maskedCpf.Text;
			f.Rg = txtRG.Text;
			f.Email = txtEmail.Text;
			f.TelResidencial = txtTelRes.Text;
			f.TelCelular = txtTelCel.Text;
			f.Salario = decimal.Parse(txtSalario.Text);
			f.Admissao = DateTime.Parse(maskedDataAdmissao.Text.Replace("/", "-"));
			f.Ctps = txtCTPS.Text;
			f.Pis = txtPIS.Text;
			f.TituloEleitor = txtTitEleitor.Text;
			f.Nascimento = DateTime.Parse(maskedNascimento.Text.Replace("/", "-"));

			if (maskedDataDemissao.Text != "__/__/____")
			{
				f.Demissao = DateTime.Parse(maskedDataDemissao.Text.Replace("/", "-"));

			}
			f.Cnh.Numero = txtCNH.Text;
			f.Cnh.Categoria = txtCategoriaCNH.Text;
			f.Cnh.Emissao = DateTime.Parse(maskedEmitidaCNH.Text.Replace("/", "-"));
			f.Cnh.Validade = DateTime.Parse(maskedValidadeCNH.Text.Replace("/", "-"));
			f.Endereco.Cep = maskedCEP.Text;
			f.Endereco.Logradouro = txtLogradouro.Text;
			f.Endereco.Num = txtNumero.Text;
			f.Endereco.Bairro = txtBairro.Text;
			f.Endereco.Cidade = txtCidade.Text;
			f.Endereco.Uf = txtUF.Text;

			using (var contexto = new LocadoraContext())
			{
				contexto.Funcionarios.Add(f);
				contexto.SaveChanges();
			}
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
			maskedDataAdmissao.Text = f.Admissao.ToString().Replace("-", "/");
			txtCTPS.Text = f.Ctps;
			txtPIS.Text = f.Pis;
			txtTitEleitor.Text = f.TituloEleitor;
			maskedNascimento.Text = f.Nascimento.ToString().Replace("-", "/");
			maskedDataDemissao.Text = f.Demissao.ToString().Replace("-", "/");
			txtCNH.Text = f.Cnh.Numero;
			txtCategoriaCNH.Text = f.Cnh.Categoria;
			maskedEmitidaCNH.Text = f.Cnh.Emissao.ToString().Replace("-", "/");
			maskedValidadeCNH.Text = f.Cnh.Validade.ToString().Replace("-", "/");
			maskedCEP.Text = f.Endereco.Cep;
			txtLogradouro.Text = f.Endereco.Logradouro;
			txtNumero.Text = f.Endereco.Num;
			txtBairro.Text = f.Endereco.Bairro;
			txtCidade.Text = f.Endereco.Cidade;
			txtUF.Text = f.Endereco.Uf;
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			var busca = new FormBuscaFuncionario();
			busca.MdiParent = this.MdiParent;
			busca.ControlBox = false;
			this.Close();
			busca.Show();
		}
	}
}
