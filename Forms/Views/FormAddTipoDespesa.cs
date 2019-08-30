using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormAddTipoDespesa : Form
	{
		public FormAddTipoDespesa()
		{
			InitializeComponent();
		}

		private void BtnAddTipoDespesa_Click(object sender, EventArgs e)
		{
			var tipo = new TipoDespesa
			{
				Tipo = txtTipo.Text
			};

			new TipoDespesaDao().DbAddTipo(tipo);

			this.Close();

		}

		private void FormAddTipoDespesa_Load(object sender, EventArgs e)
		{

		}
	}
}
