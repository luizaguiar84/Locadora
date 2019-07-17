using Forms.Models;
using Microsoft.EntityFrameworkCore;
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
	public partial class FormBuscaCarro : Form
	{
		List<Veiculo> Teste;

		public FormBuscaCarro()
		{
			InitializeComponent();
		}

		private void FormBuscaCarro_Load(object sender, EventArgs e)
		{

		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			using (var contexto = new LocadoraContext())
			{
				var resultado = contexto.Veiculos
								.Where(c => EF.Functions.Like(c.Modelo, $"%{txtPesquisar.Text}%"))
								.ToList();

				Teste = resultado;
			}
			dataGridView1.Visible = true;
			dataGridView1.DataSource = Teste;
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int veiculoId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			var veiculo = Teste.Single(x => x.Id == veiculoId);

			var form = new FormCadastrarVeiculo(veiculo);
			form.MdiParent = this.MdiParent;

			form.Show();
			this.Close();

		}
	}
}
