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
	public partial class FormCadastrarDespesa : Form
	{
		public FormCadastrarDespesa()
		{
			InitializeComponent();
		}

		private void txtValor_Enter(object sender, EventArgs e)
		{
			txtValor.IsDinheiro();
		}

		private void txtValor_Leave(object sender, EventArgs e)
		{
			txtValor.IsDinheiro();
		}

		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtValor.IsNumeros(e);
		}

		private void maskedDataDespesa_Leave(object sender, EventArgs e)
		{
			maskedDataDespesa.IsData();
		}

		private void FormCadastrarDespesa_Load(object sender, EventArgs e)
		{

		}
	}
}
