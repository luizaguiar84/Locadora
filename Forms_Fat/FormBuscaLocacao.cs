using Dll_DB_Fat;
using System;
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

			dataGridView1.DataSource = new LocacoesDao().GetLocacoes();

			//using (var contexto = new LocadoraContext())
			//{
			// var query = from locacao in contexto.Locacoes
			// 			join cl in contexto.ClienteLocacao on locacao.Id equals cl.LocacaoId
			// 			join cliente in contexto.Clientes on cl.ClienteId equals cliente.Id
			// 			join veiculo in contexto.Veiculos on locacao.VeiculoId equals veiculo.Id
			// 			where
			// 			cliente.Id == cl.ClienteId &&
			// 			locacao.Id == cl.LocacaoId &&
			// 			veiculo.Id == locacao.VeiculoId
			// 			select new
			// 			{
			// 				OS = locacao.Id,
			// 				Cliente = cliente.Nome,
			// 				VeiculoAlugado = veiculo.Modelo,
			// 				veiculo.Placa,
			// 				DataInicio = locacao.DataInicio,
			// 				locacao.DataFinal,
			// 				IsAtiva = locacao.IsAtiva
			// 			};

			//	query = query.Take(10);

			//if (ComboFiltro.Text == "Placa")
			//{
			//							//.Where(x => x.Placa.Contains(txtPesquisa.Text) && x.IsAtiva)
			//							//.ToList();
			//	//NomeiaColunasDataGrid();
			//}
			//	if (ComboFiltro.Text == "Cliente")
			//	{
			//		dataGridView1.DataSource = query
			//								.Where(x => x.Cliente.Contains(txtPesquisa.Text) && x.IsAtiva)
			//								.ToList();
			//		NomeiaColunasDataGrid();
			//	}
			//	if (string.IsNullOrWhiteSpace(ComboFiltro.Text))
			//	{
			//		MessageBox.Show("Favor Escolher a opção de busca no Filtro.");
			//	}
			//}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LocacaoId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);
		}
	}
}
