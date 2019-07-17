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
			SalvarEntrada();
		}

		private void SalvarEntrada()
		{
			Estoque e = new Estoque();

			e.Peca = txtNomeEntrada.Text;
			e.Quantidade = Convert.ToInt32(txtQuantidadeEntrada.Text);
			e.ValorUnitario = Convert.ToDecimal(txtValorUnitEntrada.Text);
			e.IncluidoPor = txtIncluidoPor.Text;
			e.Observacoes = txtObservacoes.Text;

			using (var repo = new LocadoraContext())
			{
				repo.Estoque.Add(e);
				repo.SaveChanges();
			}

			MessageBox.Show("Produto adicionado com sucesso ao estoque!");

			AtualizaTabela();
		}

		private void AtualizaTabela()
		{
			using (var repo = new LocadoraContext())
			{
				var estoque = repo.Estoque.ToList();

				dataGridConsulta.DataSource = estoque;
			}
		}

		private void btnSalvarSaida_Click(object sender, EventArgs e)
		{
			SalvarSaida();
		}

		private void SalvarSaida()
		{
			using (var repo = new LocadoraContext())
			{
				var e = new Estoque();


				e.Id = Convert.ToInt32(txtIdSaida.Text);
				e.Quantidade = Convert.ToInt32(txtQuantidadeSaida.Text);
				e.ValorUnitario = Convert.ToDecimal(txtValorUnitSaida.Text);
				e.RetiradoPor = txtRetirado.Text;
				e.Observacoes = txtObservacoes.Text;

				repo.Estoque.Update(e);
				repo.SaveChanges();

				AtualizaTabela();
				
			}
		}

		private void PreenchePeca(int id)
		{
			using (var repo = new LocadoraContext())
			{
				
				var peca = repo.Estoque
							.Where(e => e.Id == id)
							.SingleOrDefault();

				txtNomeSaida.Text = peca.Peca;
			}
		}

		

		private void dataGridSaida_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = Convert.ToInt32(dataGridConsulta["Id", e.RowIndex].Value);
			PreenchePeca(id);
		}

		private void dataGridSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
