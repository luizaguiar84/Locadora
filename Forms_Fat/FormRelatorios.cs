using Dll_DB_Fat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
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
			var cliente = new ClientesPFDao();
			var listaClientes = cliente.GetAll();

		}
	}
}
