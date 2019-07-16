﻿using Forms;
using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public partial class FormCadastrarNovoVeiculo : Form
	{
		public FormCadastrarNovoVeiculo()
		{
			InitializeComponent();
		}
	


		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}


		private void btnLocalizar_Click_1(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}


		private void btnSalvar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Veiculo Cadastrado com sucesso!");			
		}

		private void FormCadastrarNovoVeiculo_Load(object sender, EventArgs e)
		{

		}

		private void maskedDataAbastecimento_Leave(object sender, EventArgs e)
		{
			maskedDataAbastecimento.IsData();
		}

		private void maskedDataManutencao_Leave(object sender, EventArgs e)
		{
			maskedDataManutencao.IsData();
		}

		private void maskedDataSinistro_Leave(object sender, EventArgs e)
		{
			maskedDataSinistro.IsData();
		}

		private void maskedDataObrigacoes_Leave(object sender, EventArgs e)
		{
			maskedDataObrigacoes.IsData();
		}

		private void txtOdometro_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtOdometro.IsNumeros(e);
		}

		private void txtValorDiaria_Enter(object sender, EventArgs e)
		{
			txtValorDiaria.IsDinheiro();
		}

		private void txtQtdLitros_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtKmAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtKmManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtKmSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorObrigacoes_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorUnitAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

	}
}
