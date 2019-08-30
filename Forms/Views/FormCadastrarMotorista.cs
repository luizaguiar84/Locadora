using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormCadastrarMotorista : Form
	{
		public FormCadastrarMotorista()
		{
			InitializeComponent();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.ControlBox = true;
			formCadastrarCliente.Show();
		}
		private void FormCadastrarMotorista_Load(object sender, EventArgs e)
		{
			CarregaMotoristas();
		}

		private void CarregaMotoristas()
		{

			var motoristas = new ClientesDao().GetClientes();

			comboMotoristas.DataSource = motoristas;
			comboMotoristas.DisplayMember = "Nome";

		}

		private void ComboMotoristas_SelectedIndexChanged(object sender, EventArgs e)
		{
			Clientes motorista = (Clientes)comboMotoristas.SelectedItem;
			txtCnh.Text = motorista.Cnh.Numero;
			txtCategoria.Text = motorista.Cnh.Categoria;
			//maskedEmitida.Text = motorista.Cnh.Emissao.Value.ToString();
			//maskedValidade.Text = motorista.Cnh.Validade.Value.ToString();

		}
	}
}
