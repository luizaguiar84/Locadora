using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Models;

namespace Forms.Views.Desktop
{
    public partial class FormEditarVeiculo: Form
    {
		private Veiculo veiculo;

		public FormEditarVeiculo()
        {
			InitializeComponent();
		}

		public FormEditarVeiculo(Veiculo veiculo)
		{
			InitializeComponent();
			this.veiculo = veiculo;
			PreencherFormulario(veiculo);
		}

		private void FormEditarVeiculo_Load(object sender, EventArgs e)
		{

		}

		private void PreencherFormulario(Veiculo v)
		{
			txtId.Text = v.Id.ToString();
			txtMontadora.Text = v.Montadora;
			txtModelo.Text = v.Modelo;
			txtAnoModelo.Text = v.AnoModelo;
			numericPortas.Value = v.Portas;
			comboCor.Text = v.Cor;
			maskedTxtPlaca.Text = v.Placa;
			txtRenavam.Text = v.Renavam;
			txtChassi.Text = v.Chassi;
			numericLugares.Value = v.Lugares;
			txtOdometro.Text = v.Quilometragem.ToString();
			comboStatus.Text = v.Status;
			txtCombustivel.Text = v.Combustivel;
			txtValorAtualCarro.Text = v.ValorAtual;
			txtValorDiaria.Text = v.ValorDiaria.ToString();
			txtObservacoes.Text = v.Observacoes;
			checkArCond.Checked = Convert.ToBoolean(v.ArCondicionado);
			checkDirecaoHidraulica.Checked = Convert.ToBoolean(v.DirecaoHidraulica);
			checkVidroEletrico.Checked = Convert.ToBoolean(v.VidroEletrico);
			checkAbs.Checked = Convert.ToBoolean(v.Abs);
			checkAirBag.Checked = Convert.ToBoolean(v.AirBag);

		}

		private void AtualizarVeiculo(Veiculo v)
		{
			v.Portas = Convert.ToInt32(numericPortas.Value);
			v.Cor = comboCor.Text;
			v.Placa = maskedTxtPlaca.Text;
			v.Renavam = txtRenavam.Text;
			v.Chassi = txtChassi.Text;
			v.Lugares = Convert.ToInt32(numericLugares.Value);
			v.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			v.Status = comboStatus.Text;
			v.ValorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
			v.Observacoes = txtObservacoes.Text;
			v.ArCondicionado = Convert.ToSByte(checkArCond.Checked);


			using (var contexto = new LocadoraContext())
			{
				contexto.Veiculos.Update(v);
				contexto.SaveChanges();
			}
			MessageBox.Show("Veiculo Atualizado com sucesso!");
			this.Close();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			AtualizarVeiculo(veiculo);
		}

		private void txtChassi_KeyPress(object sender, KeyPressEventArgs e)
		{
		}
	}
}
