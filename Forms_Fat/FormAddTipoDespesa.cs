using BsFat;
using DbFat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormAddTipoDespesa : Form
	{
		public FormAddTipoDespesa()
		{
			InitializeComponent();
		}

		private void BtnAddTipoDespesa_Click(object sender, EventArgs e)
		{
			var tipoDespesa = new TipoDespesa
			{
				Tipo = txtTipo.Text
			};

			if (new TipoDespesaDao().DbAddTipo(tipoDespesa))
			{
				MessageBox.Show("Tipo de despesa adicionado com sucesso!");
			}
			else
			{
				MessageBox.Show("Erro na adição de despesa.");
			}
			this.Close();

		}

		private void FormAddTipoDespesa_Load(object sender, EventArgs e)
		{

		}
	}
}
