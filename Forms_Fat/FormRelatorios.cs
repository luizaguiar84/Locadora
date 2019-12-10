using DbFat;
using System;
using System.Windows.Forms;
using Utilidades;

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
			LimparTela();
		}

		private void LimparTela()
		{
			this.Controls.LimparTextBoxes();
			this.groupPesquisa.Controls.LimparTextBoxes();
			this.groupPesquisaPeriodo.Controls.LimparTextBoxes();
			this.groupPesquisaPeriodo.Controls.LimparTextBoxes();
			this.groupPlacas.Controls.LimparTextBoxes();
			this.groupRelatorios.Controls.LimparTextBoxes();
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			var cliente = new FuncionariosDao();
			var listaClientes = cliente.GetMotoristas();

		}
	}
}
