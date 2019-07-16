using Forms.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{

	public partial class FormCadastrarFuncionario : Form
	{

		public FormCadastrarFuncionario()
		{
			InitializeComponent();
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
				f.Demissao = DateTime.Parse(maskedDataDemissao.Text.Replace("/", "-"));
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



				//escrevendo no arquivo (teste)
				//var caminhoArquivo = "teste.txt";
				//using (var fs = new FileStream(caminhoArquivo, FileMode.Create))
				//using (var escritor = new StreamWriter(fs))
				//{
				//	escritor.WriteLine($"Nome: {Func.NOME}, Email: {Func.EMAIL} \n Endereço: {Func.LOGRADOURO}, {Func.NUM}. Bairro: {Func.BAIRRO}, " +
				//						$"Cidade: {Func.CIDADE} UF: {Func.UF}");
				//}
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
	}
}
