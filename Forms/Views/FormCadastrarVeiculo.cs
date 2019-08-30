using Classes.DAO;
using Classes.Models;
using FatCars.Desktop;
using hbehr.FipeAPI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FatCars
{
	public partial class FormCadastrarVeiculo : Form
	{
		readonly FipeApi api = new FipeCarrosApi(); // For Cars
		private readonly Classes.Models.Veiculos veiculo;

		#region VALIDACOES
		private void TxtOdometro_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtOdometro.IsNumeros(e);
		}
		private void TxtValorDiaria_Enter(object sender, EventArgs e)
		{
		}
		private void TxtQtdLitros_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtKmAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtKmManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtKmSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtValorObrigacoes_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtValorSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtValorManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}
		private void TxtValorUnitAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		#endregion
		public FormCadastrarVeiculo()
		{
			InitializeComponent();
			txtMontadora.Hide();
			txtModelo.Hide();
			txtAnoModelo.Hide();
		}
		public FormCadastrarVeiculo(Classes.Models.Veiculos veiculo)
		{
			InitializeComponent();
			this.veiculo = veiculo;
			PreencherFormulario(veiculo);
		}
		private void BtnLocalizar_Click(object sender, EventArgs e)
		{
			var formBuscaCarro = new FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void BtnLocalizar_Click_1(object sender, EventArgs e)
		{
			var busca = new FormBuscaCarro
			{
				MdiParent = this.MdiParent,
				ControlBox = false
			};
			this.Close();
			busca.Show();

		}


		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			if (txtId.Text == "")
			{
				CadastrarVeiculo();
			}
			else
			{
				AtualizarVeiculo(veiculo);
			}
			
		}
		
		private void CadastrarVeiculo()
		{
			Classes.Models.Veiculos v = new Classes.Models.Veiculos();

			v.Montadora = comboMontadora.Text;
			v.Modelo = comboModelo.Text;
			v.AnoModelo = comboAno.Text;
			v.Portas = Convert.ToInt32(numericPortas.Value);
			v.Cor = comboCor.Text;
			v.Placa = maskedTxtPlaca.Text.ToUpper();
			v.Renavam = txtRenavam.Text;
			v.Chassi = txtChassi.Text;
			v.Lugares = Convert.ToInt32(numericLugares.Value);
			v.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			v.Status = comboStatus.Text;
			v.Combustivel = txtCombustivel.Text;
			v.ValorAtual = txtValorAtualCarro.Text;
			v.ValorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
			v.Observacoes = txtObservacoes.Text;
			v.ArCondicionado = checkArCond.Checked;
			v.DirecaoHidraulica = checkDirecaoHidraulica.Checked;
			v.VidroEletrico = checkVidroEletrico.Checked;
			v.Abs = checkAbs.Checked;
			v.AirBag = checkAirBag.Checked;
			if (comboStatus.Text == "ATIVO")
			{
				v.IsAtivo = true;
			}

			new VeiculosDao().DbAdd(v);

			LimpaTela();


		}

		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
			this.TabCadastroVeiculos.Controls.LimparTextBoxes();
			this.tabInformacoes.Controls.LimparTextBoxes();
		}

		private void FormCadastrarNovoVeiculo_Load(object sender, EventArgs e)
		{
			CarregaMontadoras();
		}

		private void CarregaMontadoras()
		{
			var _marcas = api.GetMarcas();
			comboMontadora.DataSource = _marcas;
			comboMontadora.DisplayMember = "name";
		}

		private void CarregaModelos(string marca)
		{
			var Veiculos = api.GetVeiculos(marca); // Sync
			comboModelo.DataSource = Veiculos;
			comboModelo.DisplayMember = "name";
		}

		private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;
			IEnumerable<AnoModelo> anoModelos = api.GetAnoModelos(_marca.id, _veiculo.id); // Sync
			comboAno.DataSource = anoModelos;
			comboAno.DisplayMember = "name";
		}

		private void ComboMontadora_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			CarregaModelos(_marca.id);
			hbehr.FipeAPI.Veiculos veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem; // Sync
		}

		private void ComboAno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;
			AnoModelo anoModelo = (AnoModelo)comboAno.SelectedItem;
			PrecoCorrente precoCorrente = api.GetPrecoCorrente(_marca.id, _veiculo.id, anoModelo.id);
			txtCombustivel.Text = precoCorrente.combustivel;
			txtValorAtualCarro.Text = precoCorrente.preco;
		}

		private void PreencherFormulario(Classes.Models.Veiculos v)
		{
			txtId.Text = v.Id.ToString();

			comboMontadora.Hide();
			txtMontadora.Text = v.Montadora;
			comboModelo.Hide();
			txtModelo.Text = v.Modelo;
			comboAno.Hide();
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

		private void AtualizarVeiculo(Classes.Models.Veiculos v)
		{
			v.Portas = Convert.ToInt32(numericPortas.Value);
			v.Cor = comboCor.Text;
			v.Placa = maskedTxtPlaca.Text.ToUpper();
			v.Renavam = txtRenavam.Text;
			v.Chassi = txtChassi.Text;
			v.Lugares = Convert.ToInt32(numericLugares.Value);
			v.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			v.Status = comboStatus.Text;
			v.ValorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
			v.Observacoes = txtObservacoes.Text;

			v.ArCondicionado = checkArCond.Checked;
			v.DirecaoHidraulica = checkDirecaoHidraulica.Checked;
			v.VidroEletrico = checkVidroEletrico.Checked;
			v.Abs = checkAbs.Checked;
			v.AirBag = checkAirBag.Checked;

			new VeiculosDao().DbUpdate(v);

			ReabrirForm();
		}

		private void ReabrirForm()
		{
			var form = new FormCadastrarVeiculo
			{
				MdiParent = this.MdiParent,
				ControlBox = false
			};
			this.Close();
			form.Show();
		}



		
	}
}
