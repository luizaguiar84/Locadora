﻿using FatCars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormDefinicoes : Form
	{
	

		public FormDefinicoes()
		{
			InitializeComponent();
		}

		private void txtSegFurtoBatida_Leave(object sender, EventArgs e)
		{
		}

		private void txtSeguroTerceiros_Leave(object sender, EventArgs e)
		{

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			//limpa formatacao
			string furto = decimal.Parse(txtSegFurtoBatida.Text).ToString("F2");
			string terceiros = decimal.Parse(txtSeguroTerceiros.Text).ToString("F2");


			Program.Valores.ValorSeguro = decimal.Parse(furto);
			Program.Valores.ValorSeguroTerceiros = decimal.Parse(terceiros);
			MessageBox.Show("Preços Atualizados com Sucesso!", "Aviso!");
			this.Hide();
		}

		private void FormTabelaDePrecos_Load(object sender, EventArgs e)
		{
			txtSeguroTerceiros.Text = Program.Valores.ValorSeguroTerceiros.ToString("F2");
			txtSegFurtoBatida.Text = Program.Valores.ValorSeguro.ToString("F2");
			

		}

		private void TxtSegFurtoBatida_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSegFurtoBatida_Enter(object sender, EventArgs e)
		{

		}

		private void txtSeguroTerceiros_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSeguroTerceiros_Enter(object sender, EventArgs e)
		{

		}
	}
}