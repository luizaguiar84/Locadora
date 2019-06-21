using Forms;
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
	public partial class FormControlePatio : Form
	{
		public FormControlePatio()
		{
			InitializeComponent();
		}

		private void txtkmRetorno_TextChanged(object sender, EventArgs e)
		{
			lblKmRodado.Text = (int.Parse(txtkmRetorno.Text) - int.Parse(txtKmSaida.Text)).ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista formCadastrarMotorista = new FormCadastrarMotorista();
			formCadastrarMotorista.ControlBox = true;
			formCadastrarMotorista.Show();
		}

		private void btnAddCarro_Click(object sender, EventArgs e)
		{
			FormCadastrarNovoVeiculo formCadastrarNovoVeiculo = new FormCadastrarNovoVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.Show();
		}

		private void FormControlePatio_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.groupRegistro.Controls.LimparTextBoxes();
			this.groupRetorno.Controls.LimparTextBoxes();
			this.groupVeicFora.Controls.LimparTextBoxes();
			this.groupSaida.Controls.LimparTextBoxes();
		}

		private void txtKmSaida_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void maskedDataSaida_Leave(object sender, EventArgs e)
		{
			maskedDataSaida.IsData();
		}

		private void maskedDataRetorno_Leave(object sender, EventArgs e)
		{
			maskedDataRetorno.IsData();
		}

		private void txtkmRetorno_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
	}
}
