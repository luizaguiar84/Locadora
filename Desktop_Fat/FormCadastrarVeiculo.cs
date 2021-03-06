﻿using BsFat;
using DbFat;
using Utilidades;
using hbehr.FipeAPI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarVeiculo : Form
	{
		readonly FipeApi api = new FipeCarrosApi(); // For Cars
		private readonly BsFat.Veiculos veiculo;

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
		public FormCadastrarVeiculo(BsFat.Veiculos veiculo)
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
			if (validaVeiculo())
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
		}

		private bool validaVeiculo()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(maskedTxtPlaca.Text))
			{
				MessageBox.Show("Favor preencher a placa do veículo");
			}
			else if (String.IsNullOrWhiteSpace(txtRenavam.Text))
			{
				MessageBox.Show("Favor preencher o numero do renavam do veículo.");
			}
			else if (String.IsNullOrWhiteSpace(txtChassi.Text))
			{
				MessageBox.Show("Favor preencher o numero do Chassi do veículo.");
			}
			else
			{
				ret = true;
			}
			return ret;
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
				.GetCor(comboCor.Text)
				.GetPlaca(maskedTxtPlaca.Text.ToUpper())
				.GetRenavam(txtRenavam.Text)
				.GetChassi(txtChassi.Text)
				.GetLugares(Convert.ToInt32(numericLugares.Value))
				.GetQuilometragem(Convert.ToInt32(txtOdometro.Text))
				.GetStatus(comboStatus.Text)
				.GetCombustivel(txtCombustivel.Text)
				.GetValorAtual(txtValorAtualCarro.Text)
				.GetObservacoes(txtObservacoes.Text)
				.GetArCondicionado(checkArCond.Checked)
				.GetDirecaoHidraulica(checkDirecaoHidraulica.Checked)
				.GetVidroEletrico(checkVidroEletrico.Checked)
				.GetAbs(checkAbs.Checked)
				.GetAirBag(checkAirBag.Checked)
				.GetClientePj(Desktop_Fat.Program.clienteAtivo)
				.GetIsAtivo(ativo);

			var veiculo = veiculoBuilder.Build();
			veiculo.DataAquisicao = DateTime.Now;
			//ValidarVeiculo(veiculo);

			if (new VeiculosDao().DbAdd(veiculo))
			{
				MessageBox.Show("Carro Adicionado com Sucesso!", "Sucesso!");
				ConfirmaSaida();
			}
			else
			{
				MessageBox.Show("Erro ao salvar, favor tentar novamente!", "Erro!");
			}
		}

		private void ConfirmaSaida()
		{
			if (MessageBox.Show("Gostaria de Adicionar outro veiculo?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				LimpaTela();
			}
			else
			{
				this.Close();
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
			comboStatus.SelectedIndex = 0;
			comboCor.SelectedIndex = 0;
		}

		private void CarregarCores()
		{
			foreach (var cor in Enum.GetValues(typeof(Cor))) comboCor.Items.Add(cor);
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

		private void PreencherFormulario(BsFat.Veiculos v)
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
			//txtValorDiaria.Text = v.ValorDiaria.ToString();
			txtObservacoes.Text = v.Observacoes;
			checkArCond.Checked = Convert.ToBoolean(v.ArCondicionado);
			checkDirecaoHidraulica.Checked = Convert.ToBoolean(v.DirecaoHidraulica);
			checkVidroEletrico.Checked = Convert.ToBoolean(v.VidroEletrico);
			checkAbs.Checked = Convert.ToBoolean(v.Abs);
			checkAirBag.Checked = Convert.ToBoolean(v.AirBag);
		}

		private void AtualizarVeiculo(BsFat.Veiculos veiculo)
		{
			veiculo.Portas = Convert.ToInt32(numericPortas.Value);
			veiculo.Cor = comboCor.Text;
			veiculo.Placa = maskedTxtPlaca.Text.ToUpper();
			veiculo.Renavam = txtRenavam.Text;
			veiculo.Chassi = txtChassi.Text;
			veiculo.Lugares = Convert.ToInt32(numericLugares.Value);
			veiculo.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			veiculo.Status = comboStatus.Text;
			veiculo.Combustivel = txtCombustivel.Text;
			veiculo.ArCondicionado = checkArCond.Checked;
			veiculo.DirecaoHidraulica = checkDirecaoHidraulica.Checked;
			veiculo.VidroEletrico = checkVidroEletrico.Checked;
			veiculo.Abs = checkAbs.Checked;
			veiculo.AirBag = checkAirBag.Checked;

			if (new VeiculosDao().DbUpdate(veiculo))
			{
				MessageBox.Show("Veiculo Atualizado com sucesso!");
				ConfirmaSaida();
			}
			else
			{
				MessageBox.Show("Erro na atualização do veiculo, tente novamente!");
			}
			//ReabrirForm();
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


		//private void ValidarVeiculo(object obj)
		//{
		//	var erros = Validacao.getValidationErrors(obj);
		//	foreach (var erro in erros)
		//	{
		//		MessageBox.Show(erro.ErrorMessage);
		//	}
		//}
	}
}
