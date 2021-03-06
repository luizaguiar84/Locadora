﻿using BsFat;
using DbFat;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Dll_Forms_Fat
{
	public partial class FormControlePneus : Form
	{
		private Veiculos veiculo;

		public FormControlePneus()
		{
			InitializeComponent();
		}

		public FormControlePneus(Veiculos veiculo)
		{
			InitializeComponent();
			this.veiculo = veiculo;
			comboPlaca.SelectedItem = veiculo;

		}

		private void FormControlePneus_Load(object sender, EventArgs e)
		{
			PreenchePlacas();
			LimpaTela();
		}

		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
		}

		private void PreenchePlacas()
		{
			var lista = new VeiculosDao().GetAll();

			comboPlaca.DataSource = lista;
			comboPlaca.ValueMember = "Placa";
		
		}

		private void BtnAddPneu_Click(object sender, EventArgs e)
		{
			if (validacao())
			{
				var veiculo = GetVeiculo();
				veiculo.Pneus = new VeiculosPneusDao().GetAll().Where(v => v.VeiculosId == veiculo.Id).ToList();

				var pneu = new Pneus
				{
					DataAdicao = datePneu.Value.Date,
					Marca = txtMarca.Text,
					Modelo = txtModelo.Text,
					KmAtual = 0
				};

				if (veiculo.Pneus.Count != 0)
				{
					if (MessageBox.Show("Veiculo já possui pneus cadastrados, trocar eles?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						while (veiculo.Pneus.Count != 0)
						{
							var _pneu = veiculo.Pneus.First();
							var sefoi = new VeiculosPneusDao().DeleteRegistro(_pneu);
							veiculo.Pneus.Remove(_pneu);

						}
						CadastrarPneus(veiculo, pneu);
					}
				}
				else
				{
					CadastrarPneus(veiculo, pneu);
				}
			}
		}

		private void CadastrarPneus(Veiculos veiculo, Pneus pneu)
		{
			for (int i = 0; i < 4; i++)
			{
				veiculo.AddPneu(pneu);
			}

			if (new VeiculosDao().DbUpdate(veiculo))
			{
				MessageBox.Show($"Pneus vinculado ao veiculo {veiculo.Placa} com sucesso");
				LimpaTela();
				PreencheTabela(veiculo);
			}
			else
			{
				MessageBox.Show("Erro na adição do Pneu");
			}
		}

		private bool validacao()
		{
			bool retorno = false;
			if (String.IsNullOrWhiteSpace(txtMarca.Text))
			{
				MessageBox.Show("Favor preencher a marca do pneu.");
			}
			else if (String.IsNullOrWhiteSpace(txtModelo.Text))
			{
				MessageBox.Show("Favor preencher o modelo do pneu");
			}
			else
			{
				retorno = true;
			}
			
			return retorno;
		}

		private void PreencheTabela(Veiculos veiculo)
		{

			var lista = new VeiculosPneusDao().GetAll().Where(v => v.VeiculosId == veiculo.Id).ToList();
			var listaPneus = new PneusDao().GetAll();

			var source = from pneu in listaPneus
						 join item in lista on pneu.Id equals item.PneusId
						 select new
						 {
							 Marca = pneu.Marca,
							 Modelo = pneu.Modelo,
							 Km = pneu.KmAtual
						 };

			dataGridPneus.DataSource = source.ToList();
		}

		private Veiculos GetVeiculo()
		{
			var veiculo = (Veiculos)comboPlaca.SelectedItem;
			return veiculo;
		}

		private void ComboPlaca_SelectedIndexChanged(object sender, EventArgs e)
		{
			var veiculo = GetVeiculo();
			PreencheTabela(veiculo);
		}
	}
}