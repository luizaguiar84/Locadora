using Dll_Utilidades;
using Dll_BS_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dll_DB_Fat;

namespace Dll_Forms_Fat
{
	public partial class FormBuscaCarro : Form
	{
		public Form x = new Form();

		public FormBuscaCarro()
		{
			InitializeComponent();
		}

		private void FormBuscaCarro_Load(object sender, EventArgs e)
		{
		}

		private void BtnPesquisar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ComboFiltro.Text))
			{
				MessageBox.Show("Favor selecionar um filtro para a pesquisa.");
			}
			else
			{
				var busca = new VeiculosDao().DbSearch(ComboFiltro.Text, txtPesquisar.Text);
				dataGridView1.Visible = true;
				dataGridView1.DataSource = busca;
			}
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int veiculoId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			var veiculo = new VeiculosDao().GetAll()
											.Where(v => v.Id == veiculoId)
											.SingleOrDefault();

			var form = new FormCadastrarVeiculo(veiculo)
			{
				MdiParent = this.MdiParent
			};
			form.Show();
			this.Close();
		}
	}
}
