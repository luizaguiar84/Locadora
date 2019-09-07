using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormBuscaCarro : Form
	{

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

			var veiculo = new VeiculosDao().GetVeiculos()
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
