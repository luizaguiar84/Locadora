using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{
	public partial class FormCadastrarDespesa : Form
	{
		public FormCadastrarDespesa()
		{
			InitializeComponent();
		}

		private void txtValor_Enter(object sender, EventArgs e)
		{
		}

		private void txtValor_Leave(object sender, EventArgs e)
		{
		}

		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtValor.IsNumeros(e);
		}

		
		private void FormCadastrarDespesa_Load(object sender, EventArgs e)
		{
			CarregarTabela();
		}

		private void CarregarTabela()
		{
			using (var repo = new LocadoraContext())
			{
				var despesas = repo.Despesas.ToList();

				dataGridView1.DataSource = despesas;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			SalvaDespesa();
		}

		private void SalvaDespesa()
		{
			Despesas d = new Despesas();

			d.Data = dataDespesa.Value;
			d.TipoDespesa.Tipo = comboTipo.Text;
			d.Valor = Convert.ToDecimal(txtValor.Text);
			d.Descricao = txtDescricao.Text;
			d.Status = 1;

			using (var repo = new LocadoraContext())
			{
				repo.Despesas.Add(d);
				repo.SaveChanges();
				CarregarTabela();

			}
		}
	}
}
