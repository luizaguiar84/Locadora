using System;
using System.Windows.Forms;
using Dll_DB_Fat;
using Dll_BS_Fat;

namespace Dll_Forms_Fat
{
	public partial class FormEditarVeiculo: Form
    {
		private Veiculos veiculo;

		public FormEditarVeiculo()
        {
			InitializeComponent();
		}

		public FormEditarVeiculo(Veiculos veiculo)
		{
			InitializeComponent();
			this.veiculo = veiculo;
			PreencherFormulario(veiculo);
		}

		private void FormEditarVeiculo_Load(object sender, EventArgs e)
		{
		}

		private void PreencherFormulario(Veiculos v)
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

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			veiculo.Portas = Convert.ToInt32(numericPortas.Value);
			veiculo.Cor = comboCor.Text;
			veiculo.Placa = maskedTxtPlaca.Text;
			veiculo.Renavam = txtRenavam.Text;
			veiculo.Chassi = txtChassi.Text;
			veiculo.Lugares = Convert.ToInt32(numericLugares.Value);
			veiculo.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			veiculo.Status = comboStatus.Text;
			veiculo.ValorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
			veiculo.Observacoes = txtObservacoes.Text;
			veiculo.ArCondicionado = checkArCond.Checked;
			veiculo.DirecaoHidraulica = checkDirecaoHidraulica.Checked;
			veiculo.VidroEletrico = checkVidroEletrico.Checked;
			veiculo.AirBag = checkAirBag.Checked;
			veiculo.Abs = checkAbs.Checked;

			new VeiculosDao().DbUpdate(veiculo);

			MessageBox.Show("Veículo Atualizado com Sucesso!");
		
			this.Close();
		}
	}
}
