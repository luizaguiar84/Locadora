﻿using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormSobre : Form
	{
		public FormSobre()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Palmeiras próximo campeão mundial!");
		}

		private void FormSobre_Load(object sender, EventArgs e)
		{
			//Centralizando
			LogoFat.Left = (Width - LogoFat.Width) / 2;
			label1.Left = (Width - label1.Width) / 2;
			label2.Left = (Width - label2.Width) / 2;
		}
	}
}
