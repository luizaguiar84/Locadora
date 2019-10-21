using Dll_BS_Fat;
using Dll_DB_Fat;
using Dll_Utilidades;
using hbehr.FipeAPI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarVeiculo : Form
	{
		readonly FipeApi api = new FipeCarrosApi(); // For Cars
		private readonly Dll_BS_Fat.Veiculos veiculo;

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
		public FormCadastrarVeiculo(Dll_BS_Fat.Veiculos veiculo)
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
			bool ativo = false;
			if (comboStatus.Text == "ATIVO") ativo = true;

			var veiculoBuilder = new VeiculosBuilder()
				.GetMontadora(comboMontadora.Text)
				.GetModelo(comboModelo.Text)
				.GetAnoModelo(comboAno.Text)
				.GetPortas(Convert.ToInt32(numericPortas.Value))
				//.GetCor((@string)Enum.Parse(typeof(@string), comboCor.Text))
				.GetCor(comboCor.Text)
				.GetPlaca(maskedTxtPlaca.Text.ToUpper())
				.GetRenavam(txtRenavam.Text)
				.GetChassi(txtChassi.Text)
				.GetLugares(Convert.ToInt32(numericLugares.Value))
				.GetQuilometragem(Convert.ToInt32(txtOdometro.Text))
				.GetStatus(comboStatus.Text)
				.GetCombustivel(txtCombustivel.Text)
				.GetValorAtual(txtValorAtualCarro.Text)
				.GetValorDiaria(Convert.ToDecimal(txtValorDiaria.Text))
				.GetObservacoes(txtObservacoes.Text)
				.GetArCondicionado(checkArCond.Checked)
				.GetDirecaoHidraulica(checkDirecaoHidraulica.Checked)
				.GetVidroEletrico(checkVidroEletrico.Checked)
				.GetAbs(checkAbs.Checked)
				.GetAirBag(checkAirBag.Checked)
				.GetIsAtivo(ativo);

			var veiculo = veiculoBuilder.Build();
			
			ValidarVeiculo(veiculo);

			if (new VeiculosDao().DbAdd(veiculo))
			{
				MessageBox.Show("Carro Adicionado com Sucesso!", "Sucesso!");
				LimpaTela();
			}
			else
			{
				MessageBox.Show("Erro ao salvar, favor tentar novamente!", "Erro!");
			}
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
			CarregarCores();
		}

		private void CarregarCores()
		{
			foreach (var cor in Enum.GetValues(typeof(@string))) comboCor.Items.Add(cor);
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

		private void PreencherFormulario(Dll_BS_Fat.Veiculos v)
		{
			txtId.Text = v.Id.ToString();

			comboMontadora.Hide();
			txtMontadora.Text = v.Montadora;
			comboModelo.Hide();
			txtModelo.Text = v.Modelo;
			comboAno.Hide();
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

		private void AtualizarVeiculo(Dll_BS_Fat.Veiculos veiculo)
		{
			var id = veiculo.Id;
			var veiculoBuilder = new VeiculosBuilder()
				.GetMontadora(txtMontadora.Text)
				.GetModelo(txtModelo.Text)
				.GetAnoModelo(txtAnoModelo.Text)
				.GetPortas(Convert.ToInt32(numericPortas.Value))
				//.GetCor((@string)Enum.Parse(typeof(@string), comboCor.SelectedText))
				.GetCor(comboCor.Text)
				.GetPlaca(maskedTxtPlaca.Text.ToUpper())
				.GetRenavam(txtRenavam.Text)
				.GetChassi(txtChassi.Text)
				.GetLugares(Convert.ToInt32(numericLugares.Value))
				.GetQuilometragem(Convert.ToInt32(txtOdometro.Text))
				.GetStatus(comboStatus.Text)
				.GetCombustivel(txtCombustivel.Text)
				.GetValorAtual(txtValorAtualCarro.Text)
				.GetValorDiaria(Convert.ToDecimal(txtValorDiaria.Text))
				.GetObservacoes(txtObservacoes.Text)
				.GetArCondicionado(checkArCond.Checked)
				.GetDirecaoHidraulica(checkDirecaoHidraulica.Checked)
				.GetVidroEletrico(checkVidroEletrico.Checked)
				.GetAbs(checkAbs.Checked)
				.GetAirBag(checkAirBag.Checked)
				.GetIsAtivo(true);

			veiculo = veiculoBuilder.Build();
			veiculo.Id = id;

			new VeiculosDao().DbUpdate(veiculo);

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

		private void MaskedTxtPlaca_Leave(object sender, EventArgs e)
		{
			this.maskedTxtPlaca.Text.ToUpper();
		}
		
  
		private void ValidarVeiculo(object obj)
		{
			var erros = Validacao.getValidationErrors(obj);
			foreach (var erro in erros)
			{
				MessageBox.Show(erro.ErrorMessage);
			}
		}
	}
}
