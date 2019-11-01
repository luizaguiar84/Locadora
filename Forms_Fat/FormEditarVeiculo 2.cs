using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormEditarVeiculo : Form
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
			comboCor.Text = v.Cor.ToString();
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
			var veiculoBuilder = new VeiculosBuilder()
				.GetPortas(Convert.ToInt32(numericPortas.Value))
				//.GetCor((@string)Enum.Parse(typeof(@string), comboCor.SelectedText))
				.GetCor(comboCor.Text)
				.GetPlaca(maskedTxtPlaca.Text.ToUpper())
				.GetRenavam(txtRenavam.Text)
				.GetChassi(txtChassi.Text)
				.GetLugares(Convert.ToInt32(numericLugares.Value))
				.GetQuilometragem(Convert.ToInt32(txtOdometro.Text))
				.GetStatus(comboStatus.Text)
				.GetValorDiaria(txtValorDiaria.Text)
				.GetObservacoes(txtObservacoes.Text)
				.GetArCondicionado(checkArCond.Checked)
				.GetDirecaoHidraulica(checkDirecaoHidraulica.Checked)
				.GetVidroEletrico(checkVidroEletrico.Checked)
				.GetAbs(checkAbs.Checked)
				.GetAirBag(checkAirBag.Checked);

			veiculo = veiculoBuilder.Build();

			new VeiculosDao().DbUpdate(veiculo);

			MessageBox.Show("Veículo Atualizado com Sucesso!");

			this.Close();
		}
	}
}
