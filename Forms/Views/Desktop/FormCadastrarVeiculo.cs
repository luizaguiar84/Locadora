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


		private void txtValorDiaria_Leave(object sender, EventArgs e)
		{
			txtValorDiaria.IsDinheiro();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			/*
			carros carro = new carros();
			carro.ANO_FAB = (int)numericFab.Value;
			carro.ANO_MOD = (int)numericMod.Value;
			carro.PORTAS = (int)numericPortas.Value;
			carro.cor.COR1 = comboCor.Text;
			carro.PLACA = maskedTxtPlaca.Text;
			carro.RENAVAM = txtRenavam.Text;
			carro.CHASSI = txtChassi.Text;
			carro.QUILOMETRAGEM = int.Parse(txtOdometro.Text);


			MessageBox.Show("Veiculo Cadastrado com sucesso!");

			var u = new Util();
			u.LimparTextBoxes(this.tabInformacoes.Controls);
			*/
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

		private void txtValorUnitAbastecimento_Leave(object sender, EventArgs e)
		{
			txtValorUnitAbastecimento.IsDinheiro();
		}

		private void txtValorUnitAbastecimento_Enter(object sender, EventArgs e)
		{
			txtValorUnitAbastecimento.IsDinheiro();
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

		private void txtValorManutencao_Enter(object sender, EventArgs e)
		{
			txtValorManutencao.IsDinheiro();
		}

		private void txtValorManutencao_Leave(object sender, EventArgs e)
		{
			txtValorManutencao.IsDinheiro();
		}

		private void txtKmSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorSinistro_Enter(object sender, EventArgs e)
		{
			txtValorSinistro.IsDinheiro();
		}

		private void txtValorSinistro_Leave(object sender, EventArgs e)
		{
			txtValorSinistro.IsDinheiro();
		}

		private void txtValorObrigacoes_Enter(object sender, EventArgs e)
		{
			txtValorObrigacoes.IsDinheiro();
		}

		private void txtValorObrigacoes_Leave(object sender, EventArgs e)
		{
			txtValorObrigacoes.IsDinheiro();
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
