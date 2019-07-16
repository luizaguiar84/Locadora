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
	public partial class FormBuscaFuncionario : Form
	{
		private List<Funcionarios> Teste;

		public FormBuscaFuncionario()
		{
			InitializeComponent();
		}

		private void FormBuscaFuncionario_Load(object sender, EventArgs e)
		{

		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			using (var contexto = new LocadoraContext())
			{
				var resultado = contexto.Funcionarios
								.Where(c => EF.Functions.Like(c.Nome, $"%{txtPesquisa.Text}%"))
								.ToList();

				Teste = resultado;
			}
			dataGridView1.Visible = true;
			dataGridView1.DataSource = Teste;
		}

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int funcionarioId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			var funcionario = Teste.Single(x => x.Id == funcionarioId);

			using (var contexto = new LocadoraContext())
			{
				var resultadoCnh = contexto.Cnh
									.Where(cnh => cnh.Id == funcionario.Id)
									.SingleOrDefault();

				var resultadoEndereco = contexto.Endereco
										.Where(endereco => endereco.Id == funcionario.Id)
										.SingleOrDefault();

				funcionario.Cnh = resultadoCnh;
				funcionario.Endereco = resultadoEndereco;
			}

			var form = new FormCadastrarFuncionario(funcionario);
			form.MdiParent = this.ParentForm;
			this.Close();
			form.Show();
		}
	}
	}

