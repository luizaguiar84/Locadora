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
	public partial class FormCadastrarMotorista : Form
	{
		public FormCadastrarMotorista()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.ControlBox = true;
			formCadastrarCliente.Show();
		}

		private void maskedValidade_Leave(object sender, EventArgs e)
		{
			maskedValidade.IsData();
		}

		private void maskedEmitida_Leave(object sender, EventArgs e)
		{
			maskedEmitida.IsData();
		}

		private void FormCadastrarMotorista_Load(object sender, EventArgs e)
		{
			CarregaMotoristas();
		}

		private void CarregaMotoristas()
		{
			using (var repo = new LocadoraContext())
			{
				var motoristas = repo.Cliente.ToList();
				comboMotoristas.DataSource = motoristas;
				comboMotoristas.DisplayMember = "Nome";
			}
		}

		private void comboMotoristas_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cliente motorista = (Cliente)comboMotoristas.SelectedItem;
			txtCnh.Text = motorista.Cnh.Numero;
			txtCategoria.Text = motorista.Cnh.Categoria;
			//maskedEmitida.Text = motorista.Cnh.Emissao.Value.ToString();
			//maskedValidade.Text = motorista.Cnh.Validade.Value.ToString();

		}
	}
}
