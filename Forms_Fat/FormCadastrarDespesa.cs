using BsFat;
using DbFat;
using Utilidades;
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
			PreencheComboTipo();
			LimpaTextBoxes();
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

			foreach (var despesa in despesas)
			{
				new DespesasDao().GetById(despesa.Id);
			}

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
			if (validaDespesa())
			{
				SalvaDespesa();
			}
		}

		private bool validaDespesa()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtDescricao.Text))
			{
				MessageBox.Show("Favor informar a descrição da despesa!");
			}
			else if (String.IsNullOrWhiteSpace(txtValor.Text))
			{
				MessageBox.Show("Favor informar o valor da despesa!");
			}
			else if (comboTipo.Items.Count < 1)
			{
				if (MessageBox.Show("Não existe tipo de despesa cadastrado, cadastrar?", "Importante!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					AdicionaDespesa();
				}
			}
			else
			{
				ret = true;
			}

			return ret;
		}

		private void SalvaDespesa()
		{
			TipoDespesa tipo = (TipoDespesa)comboTipo.SelectedItem;

			var despesaBuilder = new DespesasBuilder()
				.GetData(dataDespesa.Value.Date)
				.GetTipoDespesaId(tipo.Id)
				.GetValor(Convert.ToDecimal(txtValor.Text))
				.GetDescricao(txtDescricao.Text)
				.GetIsAtiva(true);

			Despesas despesa = despesaBuilder.Build();

			if (new DespesasDao().DbAdd(despesa))
			{
				if(MessageBox.Show("Despesa cadastrada com sucessso!\nCadastrar Nova?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					CarregarTabela();
					LimpaTextBoxes();
				}
				else
				{
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("Erro na adição de despesa, favor tentar novamente.");
			}
		}

		private void LimpaTextBoxes()
		{
			this.Controls.LimparTextBoxes();
		}

		private void PreencheComboTipo()
		{
			var tipoDespesa = new TipoDespesaDao().GetAll();

			comboTipo.DataSource = tipoDespesa;
			comboTipo.ValueMember = "Tipo";
		}

		private void BtnAddTipo_Click(object sender, EventArgs e)
		{
			AdicionaDespesa();
		}

		private static void AdicionaDespesa()
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
