using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormRelatorios : Form
	{
		public FormRelatorios()
		{
			InitializeComponent();
		}

		private void FormRelatorios_Load(object sender, EventArgs e)
		{

		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			var cliente = new ClientesDao();
			var listaClientes = cliente.GetClientes();

		}
	}
}
