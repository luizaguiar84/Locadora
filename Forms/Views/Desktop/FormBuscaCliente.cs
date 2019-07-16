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
using System.Windows.Documents;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{
	public partial class FormBuscaCliente : Form
	{
		List<Cliente> Teste = new List<Cliente>();

		public FormBuscaCliente()
		{
			InitializeComponent();
		}

		private void FormBuscaCliente_Load(object sender, EventArgs e)
		{
			
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
		
			using (var contexto = new LocadoraContext())
			{
				var resultado = contexto.Cliente
								.Where(c => EF.Functions.Like(c.Nome, $"%{txtPesquisa.Text}%"))
								.ToList();
				
				Teste = resultado;
			}
			dataGridView1.Visible = true;
			dataGridView1.DataSource = Teste;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int clienteId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);
			var cliente = Teste.Single(x => x.Id == clienteId);

			using (var contexto = new LocadoraContext())
			{
				var resultadoCnh = contexto.Cnh
									.Where(cnh => cnh.Id == cliente.Id)
									.SingleOrDefault();

				var resultadoEndereco = contexto.Endereco
										.Where(endereco => endereco.Id == cliente.Id)
										.SingleOrDefault();

				cliente.Cnh = resultadoCnh;
				cliente.Endereco = resultadoEndereco;
			}

			var form = new FormCadastrarCliente(cliente);
			form.MdiParent = this.ParentForm;
			this.Close();
			form.Show();
		}
	}
}
