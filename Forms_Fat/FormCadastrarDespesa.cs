using Dll_BS_Fat;
using Dll_DB_Fat;
using Dll_Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarDespesa : Form
	{
		public FormCadastrarDespesa()
		{
			InitializeComponent();
		}

		#region VALIDACAO
		private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtValor.IsNumeros(e);
		}

		#endregion

		private void FormCadastrarDespesa_Load(object sender, EventArgs e)
		{
			CarregarTabela();
			CarregaTiposDespesa();
		}

		private void CarregaTiposDespesa()
		{

			var tipoDespesa = new TipoDespesaDao().GetAll();
			comboTipo.DataSource = tipoDespesa;
			comboTipo.DisplayMember = "Tipo";

		}

		private void CarregarTabela()
		{
			var despesas = new DespesasDao().GetAll();

			dataGridView1.DataSource = despesas;
			dataGridView1.Columns["Data"].Visible = true;
			dataGridView1.Columns["Descricao"].Visible = true;
			dataGridView1.Columns["Descricao"].HeaderText = "Descrição";
			dataGridView1.Columns["Id"].Visible = true;
			dataGridView1.Columns["IsAtiva"].Visible = false;
			dataGridView1.Columns["TipoDespesaId"].Visible = false;
			dataGridView1.Columns["Valor"].Visible = true;
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			SalvaDespesa();
		}

		private void SalvaDespesa()
		{
			var tipoDespesa = new TipoDespesaDao().GetAll();

			comboTipo.DataSource = tipoDespesa;
			comboTipo.ValueMember = "Tipo";
			TipoDespesa tipo = (TipoDespesa)comboTipo.SelectedItem;

			var despesaBuilder = new DespesasBuilder()
				.GetData(dataDespesa.Value)
				.GetTipoDespesaId(tipo.Id)
				.GetValor(Convert.ToDecimal(txtValor.Text))
				.GetDescricao(txtDescricao.Text)
				.GetIsAtiva(true);

			Despesas despesa = despesaBuilder.Build();

			new DespesasDao().DbAdd(despesa);
			CarregarTabela();
		}



		private void BtnAddTipo_Click(object sender, EventArgs e)
		{
			var formAdd = new FormAddTipoDespesa();
			formAdd.Show();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			var de = dateDe.Value;
			var ate = dateAte.Value;

			var query = new DespesasDao().GetAll()
							.Where(d => d.Data > de &&
									   d.Data < ate)
							.ToList();
			CarregarTabelaFiltro(query);

		}

		private void CarregarTabelaFiltro(List<Despesas> despesas)
		{

			dataGridView1.DataSource = despesas;
			dataGridView1.Columns["Data"].Visible = true;
			dataGridView1.Columns["Descricao"].Visible = true;
			dataGridView1.Columns["Descricao"].HeaderText = "Descrição";
			dataGridView1.Columns["Id"].Visible = true;
			dataGridView1.Columns["IsAtiva"].Visible = false;
			dataGridView1.Columns["TipoDespesaId"].Visible = false;
			dataGridView1.Columns["Valor"].Visible = true;
		}
	}
}
