using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormBuscaFuncionario : Form
	{
		public FormBuscaFuncionario()
		{
			InitializeComponent();
		}

		private void FormBuscaFuncionario_Load(object sender, EventArgs e)
		{
		}

		private void BtnPesquisar_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(ComboFiltro.Text))
			{
				MessageBox.Show("Favor selecionar um filtro para a busca.");
			}
			else
			{
				var source = new FuncionariosDao().DbSearch(ComboFiltro.Text, txtPesquisa.Text);

				dataGridView1.DataSource = source;
				dataGridView1.Visible = true;

				//MontarDataGrid(source);
			}
		}

		private void MontarDataGrid(List<Funcionarios> source)
		{
			dataGridView1.DataSource = source;
			dataGridView1.Visible = true;
			dataGridView1.Columns["Id"].Visible = true;
			dataGridView1.Columns["IsAtivo"].Visible = true;
			dataGridView1.Columns["Nome"].Visible = true;
			dataGridView1.Columns["Cpf"].Visible = true;
			dataGridView1.Columns["Cpf"].HeaderText = "CPF";
			dataGridView1.Columns["Rg"].HeaderText = "RG";
			dataGridView1.Columns["Email"].HeaderText = "E-Mail";
			dataGridView1.Columns["TelResidencial"].Visible = false;
			dataGridView1.Columns["TelCelular"].Visible = false;
			dataGridView1.Columns["Salario"].Visible = false;
			dataGridView1.Columns["Admissao"].Visible = false;
			dataGridView1.Columns["Ctps"].Visible = false;
			dataGridView1.Columns["Pis"].Visible = false;
			dataGridView1.Columns["TituloEleitor"].Visible = false;
			dataGridView1.Columns["Nascimento"].Visible = false;
			dataGridView1.Columns["Demissao"].Visible = false;
			dataGridView1.Columns["Cnh"].Visible = false;
			dataGridView1.Columns["Endereco"].Visible = false;
			dataGridView1.Columns["Observacoes"].Visible = false;
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			int funcionarioId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			var funcionario = new FuncionariosDao().GetFuncionario(funcionarioId);

			var form = new FormCadastrarFuncionario(funcionario)
			{
				MdiParent = this.ParentForm
			};

			this.Close();
			form.Show();
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

