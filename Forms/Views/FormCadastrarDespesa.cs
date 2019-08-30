using Classes.DAO;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
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

			var tipoDespesa = new TipoDespesaDao().GetTipoDespesa();
			comboTipo.DataSource = tipoDespesa;
			comboTipo.DisplayMember = "Tipo";

		}

		private void CarregarTabela()
		{
			
				var despesas = new DespesasDao().GetDespesas();
				
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
			var tipoDespesa = new TipoDespesaDao().GetTipoDespesa();
			Despesas d = new Despesas();

			comboTipo.DataSource = tipoDespesa;
			comboTipo.ValueMember = "Tipo";

			TipoDespesa tipo = (TipoDespesa)comboTipo.SelectedItem;

			d.Data = dataDespesa.Value;
			d.TipoDespesaId = tipo.Id;
			d.Valor = Convert.ToDecimal(txtValor.Text);
			d.Descricao = txtDescricao.Text;
			d.IsAtiva = true;

			new DespesasDao().DbAdd(d);
			CarregarTabela();

		}

		

		private void BtnAddTipo_Click(object sender, EventArgs e)
		{
			var formAdd = new FormAddTipoDespesa();
			formAdd.Show();
		}
	}
}
