using Forms;
using Forms.Models;
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
	public partial class FormCadastrarNovoVeiculo : Form
	{
		FipeApi api = new FipeCarrosApi(); // For Cars

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
			CarregaMontadoras();

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

		private void comboMontadora_Leave(object sender, EventArgs e)
		{
		}

		private void comboMontadora_TextChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			CarregaModelos(_marca.id);

			hbehr.FipeAPI.Veiculos veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem; // Sync

		}

		

		private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void comboModelo_TextChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;

			
			IEnumerable<AnoModelo> anoModelos = api.GetAnoModelos(_marca.id, _veiculo.id); // Sync

			comboAno.DataSource = anoModelos;
			comboAno.DisplayMember = "name";

			
		}
		
		private void comboAno_TextChanged(object sender, EventArgs e)
		{
			Marcas _marca = (Marcas)comboMontadora.SelectedItem;
			hbehr.FipeAPI.Veiculos _veiculo = (hbehr.FipeAPI.Veiculos)comboModelo.SelectedItem;
			AnoModelo anoModelo = (AnoModelo)comboAno.SelectedItem;

			PrecoCorrente precoCorrente = api.GetPrecoCorrente(_marca.id, _veiculo.id, anoModelo.id);

			txtCombustivel.Text = precoCorrente.combustivel;
			txtValorAtualCarro.Text = precoCorrente.preco;
		}

		private void lblModelo_Click(object sender, EventArgs e)
		{

		}
	}
}
