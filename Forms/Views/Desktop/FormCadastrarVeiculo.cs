using Forms;
using Forms.Models;
using Forms.Views.Desktop;
using hbehr.FipeAPI;
using Microsoft.EntityFrameworkCore;
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
	public partial class FormCadastrarVeiculo : Form
	{
		FipeApi api = new FipeCarrosApi(); // For Cars
		private Veiculo veiculo;

		public FormCadastrarVeiculo()
		{

			InitializeComponent();
			txtMontadora.Hide();
			txtModelo.Hide();
			txtAnoModelo.Hide();

		}

		public FormCadastrarVeiculo(Veiculo veiculo)
		{
			InitializeComponent();
			this.veiculo = veiculo;
			PreencherFormulario(veiculo);
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaCarro formBuscaCarro = new Views.Desktop.FormBuscaCarro();
			formBuscaCarro.Show();
		}


		private void btnLocalizar_Click_1(object sender, EventArgs e)
		{
			var busca = new FormBuscaCarro();
			busca.MdiParent = this.MdiParent;
			busca.ControlBox = false;
			this.Close();
			busca.Show();

		}


		private void btnSalvar_Click(object sender, EventArgs e)
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
			Veiculo v = new Veiculo();

			v.Montadora = comboMontadora.Text;
			v.Modelo = comboModelo.Text;
			v.AnoModelo = comboAno.Text;
			v.Portas = Convert.ToInt32(numericPortas.Value);
			v.Cor = comboCor.Text;
			v.Placa = maskedTxtPlaca.Text;
			v.Renavam = txtRenavam.Text;
			v.Chassi = txtChassi.Text;
			v.Lugares = Convert.ToInt32(numericLugares.Value);
			v.Quilometragem = Convert.ToInt32(txtOdometro.Text);
			v.Status = comboStatus.Text;
			v.Combustivel = txtCombustivel.Text;
			v.ValorAtual = txtValorAtualCarro.Text;
			v.ValorDiaria = Convert.ToDecimal(txtValorDiaria.Text);
			v.Observacoes = txtObservacoes.Text;
			v.ArCondicionado = Convert.ToSByte(checkArCond.Checked);
			v.DirecaoHidraulica = Convert.ToSByte(checkDirecaoHidraulica.Checked);
			v.VidroEletrico = Convert.ToSByte(checkVidroEletrico.Checked);
			v.Abs = Convert.ToSByte(checkAbs.Checked);
			v.AirBag = Convert.ToSByte(checkAirBag.Checked);

			using (var contexto = new LocadoraContext())
			{
				contexto.Veiculos.Add(v);
				contexto.SaveChanges();
			}

			LimpaTela();

			MessageBox.Show("Veiculo Cadastrado com sucesso!");

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

		private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;
			IEnumerable<AnoModelo> anoModelos = api.GetAnoModelos(_marca.id, _veiculo.id); // Sync
			comboAno.DataSource = anoModelos;
			comboAno.DisplayMember = "name";
		}

		private void comboMontadora_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			CarregaModelos(_marca.id);
			hbehr.FipeAPI.Veiculos veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem; // Sync
		}

		private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;
			AnoModelo anoModelo = (AnoModelo)comboAno.SelectedItem;
			PrecoCorrente precoCorrente = api.GetPrecoCorrente(_marca.id, _veiculo.id, anoModelo.id);
			txtCombustivel.Text = precoCorrente.combustivel;
			txtValorAtualCarro.Text = precoCorrente.preco;
		}

		private void PreencherFormulario(Veiculo v)
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
			v.DirecaoHidraulica = Convert.ToSByte(checkDirecaoHidraulica.Checked);
			v.VidroEletrico = Convert.ToSByte(checkVidroEletrico.Checked);
			v.Abs = Convert.ToSByte(checkAbs.Checked);
			v.AirBag = Convert.ToSByte(checkAirBag.Checked);

			using (var contexto = new LocadoraContext())
			{
				contexto.Veiculos.Update(v);
				contexto.SaveChanges();
			}
			MessageBox.Show("Veiculo Atualizado com sucesso!");

			ReabrirForm();
		}

		private void ReabrirForm()
		{
			var form = new FormCadastrarVeiculo();
			form.MdiParent = this.MdiParent;
			form.ControlBox = false;
			this.Close();
			form.Show();
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
			txtValorAtualCarro.IsDinheiro();
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
