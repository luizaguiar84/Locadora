using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Linq;
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

			new TipoDespesaDao().DbAddTipo(tipoDespesa);
			this.Close();

		}

		private void FormAddTipoDespesa_Load(object sender, EventArgs e)
		{

		}
	}
}
