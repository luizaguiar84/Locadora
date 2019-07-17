using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Models;

namespace Forms.Views.Desktop
{
	public partial class FormDevolucao : Form
	{
		private Cliente cliente;

		public FormDevolucao()
		{
			InitializeComponent();
		}

		public FormDevolucao(Cliente cliente)
		{
			InitializeComponent();
			this.cliente = cliente;
			this.txtNome.Text = cliente.Nome;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo formCadastrarNovoVeiculo = new FormCadastrarVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.TabCadastroVeiculos.SelectTab(3);
			formCadastrarNovoVeiculo.Show();
				
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaLocacao buscaLocacao = new Views.Desktop.FormBuscaLocacao();
			buscaLocacao.Show();
		}

		private void FormDevolucao_Load(object sender, EventArgs e)
		{

		}

		private void txtKmDevolucao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
	}
}
