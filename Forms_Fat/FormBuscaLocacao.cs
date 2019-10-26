using Dll_DB_Fat;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormBuscaLocacao : Form
	{
		public int LocacaoId { get; private set; }

		public FormBuscaLocacao()
		{
			InitializeComponent();
		}

		private void FormBuscaLocacao_Load(object sender, EventArgs e)
		{
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			EfetuarPesquisa();
		}

		private void EfetuarPesquisa()
		{
			MessageBox.Show("Falta Arrumar os filtros!");

			//dataGridView1.DataSource = new LocacoesDao().GetViewLocacoes();

			//var query = (IEnumerable)new LocacoesDao().GetLocacoes();


			//if (ComboFiltro.Text == "Placa")
			//{
			//	//.Where(x => x.Placa.Contains(txtPesquisa.Text) && x.IsAtiva)
			//	//.ToList();
			//	//NomeiaColunasDataGrid();
			//}
			//if (ComboFiltro.Text == "Cliente")
			//{
			//	dataGridView1.DataSource = query.AsQueryable()
			//							.Where(x => x.Cliente.Contains(txtPesquisa.Text) && x.IsAtiva)
			//							.ToList();
			//	//NomeiaColunasDataGrid();
			//}
			//if (string.IsNullOrWhiteSpace(ComboFiltro.Text))
			//{
			//	MessageBox.Show("Favor Escolher a opção de busca no Filtro.");
			//}
		}


		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LocacaoId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);
		}
	}
}
