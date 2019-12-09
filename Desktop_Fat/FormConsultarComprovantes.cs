using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormConsultarComprovantes : Form
	{
		public FormConsultarComprovantes()
		{
			InitializeComponent();
		}

		private void FormConsultarComprovantes_Load(object sender, EventArgs e)
		{
			groupBox1.Left = (Width - groupBox1.Width) / 2;
			groupBox1.Top = ((Height - groupBox1.Height) - 50) / 2;
		}

		private void FormConsultarComprovantes_Resize(object sender, EventArgs e)
		{
			groupBox1.Left = (Width - groupBox1.Width) / 2;
			groupBox1.Top = ((Height - groupBox1.Height) - 50) / 2;
		}
	}
}
