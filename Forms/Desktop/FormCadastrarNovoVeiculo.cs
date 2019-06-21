using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormCadastrarNovoVeiculo : Form
	{
		public FormCadastrarNovoVeiculo()
		{
			InitializeComponent();
		}
		//Metodo para limpar todos os textbox
		private void limparTextBoxes(Control.ControlCollection controles)
		{
			//Faz um laço para todos os controles passados no parâmetro
			foreach (Control ctrl in controles)
			{
				//Se o contorle for um TextBox...
				if (ctrl is TextBox)
				{
					((TextBox)(ctrl)).Text = String.Empty;
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Veiculo Cadastrado com sucesso!");
			limparTextBoxes(this.Controls);


		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void FormCadastrarNovoVeiculo_Load(object sender, EventArgs e)
		{
			/*centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;

			label1.Left = (Width - label1.Width) / 2;
			LayoutCadastro.Left = (Width - LayoutCadastro.Width) / 2;
			Btn_Salvar.Left = (Width - Btn_Salvar.Width) / 2;
			*/

		}

		private void FormCadastrarNovoVeiculo_Resize(object sender, EventArgs e)
		{
			/*centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
			*/
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void btnLocalizar_Click_1(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void txtValorDiaria_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtValorDiaria_Leave(object sender, EventArgs e)
		{
			txtValorDiaria.Text = double.Parse(txtValorDiaria.Text).ToString("C");

		}
	}
}
