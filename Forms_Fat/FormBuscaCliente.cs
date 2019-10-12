using Dll_DB_Fat;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormBuscaCliente : Form
	{

		public FormBuscaCliente()
		{
			InitializeComponent();
		}

		private void FormBuscaCliente_Load(object sender, EventArgs e)
		{

		}
		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int clienteId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			if (ComboFiltro.Text == "Pessoa Fisica")
			{
				var cliente = new ClientesPFDao().GetAll().Single(x => x.Id == clienteId);
				var endereco = new EnderecosDao().DbGetEndereco(cliente.EnderecoId);
				var cnh = new CnhsDao().DbGetCnh(cliente.CnhId);
				cliente.Endereco = endereco;
				cliente.Cnh = cnh;
				var form = new FormCadastrarCliente(cliente)
				{
					MdiParent = this.ParentForm
				};
				this.Close();
				form.Show();
			}
			else
			{
				var cliente = new ClientesPjDao().GetAll().Single(x => x.Id == clienteId);
				var endereco = new EnderecosDao().DbGetEndereco(cliente.EnderecoId);
				cliente.Endereco = endereco;
				var form = new FormCadastrarCliente(cliente)
				{
					MdiParent = this.ParentForm
				};
				this.Close();
				form.Show();
			}




		}

		private void BtnPesquisar_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(ComboFiltro.Text))
			{
				MessageBox.Show("Favor selecionar um filtro para a busca.");
			}
			if (string.IsNullOrWhiteSpace(ComboTipo.Text))
			{
				MessageBox.Show("Favor Escolher o tipo de cliente a ser buscado.");
			}
			else
			{
				if (ComboFiltro.Text == "Pessoa Física")
				{
					var source = new ClientesPFDao().DbSearch(ComboFiltro.Text, txtPesquisa.Text);
					dataGridView1.DataSource = source;
					dataGridView1.Visible = true;
				}
				else
				{
					var source = new ClientesPjDao().DbSearch(ComboFiltro.Text, txtPesquisa.Text);
					dataGridView1.DataSource = source;
					dataGridView1.Visible = true;
				}
			}
		}

		private void ComboTipo_SelectedValueChanged(object sender, EventArgs e)
		{
			if (ComboTipo.Text == "Pessoa Jurídica")
			{
				ComboFiltro.Items.Add("Razão Social");
				ComboFiltro.Items.Add("CNPJ");
				ComboFiltro.Items.Remove("Nome");
				ComboFiltro.Items.Remove("RG");
				ComboFiltro.Items.Remove("CPF");

			}
			else
			{
				ComboFiltro.Items.Add("Nome");
				ComboFiltro.Items.Add("RG");
				ComboFiltro.Items.Add("CPF");
				ComboFiltro.Items.Remove("Razão Social");
				ComboFiltro.Items.Remove("CNPJ");


			}
		}
	}
}
