using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormResultadoRelatorio : Form
	{
		private ICollection resultado;
		private string label;
		private string labelInferior;

		public FormResultadoRelatorio()
		{
			InitializeComponent();
		}

		public FormResultadoRelatorio(ICollection resultado, string label)
		{
			InitializeComponent();
			this.resultado = resultado;
			this.label = label;
			dataGridView1.DataSource = resultado;
			lblTituloPag.Text = label;
		}

		public FormResultadoRelatorio(ICollection resultado, string label, string labelInferior) : this(resultado, label)
		{
			this.labelInferior = labelInferior;
			lblInferior.Text = labelInferior;
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			var voltar = new FormRelatorios()
			{
				MdiParent = this.MdiParent,
				ControlBox = false,
				WindowState = FormWindowState.Maximized
			};
			voltar.Show();
			this.Close();
		}
	}
}
