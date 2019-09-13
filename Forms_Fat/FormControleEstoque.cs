using Dll_DB_Fat;
using Dll_BS_Fat;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormControleEstoque : Form
	{
		public FormControleEstoque()
		{
			InitializeComponent();
		}

		private void FormControleEstoque_Load(object sender, EventArgs e)
		{
			AtualizaTabela();
		}

		private void btnSalvarEntrada_Click(object sender, EventArgs e)
		{
			Estoque estoque = new Estoque();

			estoque.Peca = txtNomeEntrada.Text;
			estoque.Quantidade = Convert.ToInt32(txtQuantidadeEntrada.Text);
			estoque.ValorUnitario = Convert.ToDecimal(txtValorUnitEntrada.Text);
			estoque.IncluidoPor = txtIncluidoPor.Text;
			estoque.Observacoes = txtObservacoes.Text;

			new EstoqueDao().DbAdd(estoque);

			MessageBox.Show("Produto adicionado com sucesso ao estoque!");

			AtualizaTabela();
		}

		private void AtualizaTabela()
		{

			var estoque = new EstoqueDao().GetAll();

			dataGridConsulta.DataSource = estoque;
		}

		private void btnSalvarSaida_Click(object sender, EventArgs e)
		{
			var estoque = new Estoque();


			estoque.Id = Convert.ToInt32(txtIdSaida.Text);
			estoque.Quantidade = Convert.ToInt32(txtQuantidadeSaida.Text);
			estoque.ValorUnitario = Convert.ToDecimal(txtValorUnitSaida.Text);
			estoque.RetiradoPor = txtRetirado.Text;
			estoque.Observacoes = txtObservacoes.Text;

			new EstoqueDao().DbUpdate(estoque);

			AtualizaTabela();
		}



		private void PreenchePeca(int id)
		{

			var peca = new EstoqueDao().GetAll()
						.Where(e => e.Id == id)
						.SingleOrDefault();

			txtNomeSaida.Text = peca.Peca;
		}



		private void dataGridSaida_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = Convert.ToInt32(dataGridConsulta["Id", e.RowIndex].Value);
			PreenchePeca(id);
		}
	}
}
