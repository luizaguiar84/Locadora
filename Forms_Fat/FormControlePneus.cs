using BsFat;
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
		public FormControlePneus()
		{
			InitializeComponent();
		}

		private void FormControlePneus_Load(object sender, EventArgs e)
		{
			PreenchePlacas();
			LimpaTela();
		}

		private void LimpaTela()
		{
			this.Controls.LimparTextBoxes();
			comboEstado.SelectedIndex = 0;
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
				var pneu = new Pneus();
				var veiculo = GetVeiculo();

				pneu.VeiculoId = veiculo.Id;
				pneu.Marca = txtMarca.Text;
				pneu.Estado = comboEstado.Text;
				pneu.DataAdicao = datePneu.Value;
				pneu.Modelo = txtModelo.Text;

				if (new PneusDao().DbAdd(pneu))
				{
					MessageBox.Show($"Pneu vinculado ao veiculo {veiculo.Placa} com sucesso");
					LimpaTela();
					PreencheTabela(veiculo);
				}
				else
				{
					MessageBox.Show("Erro na adição do Pneu");
				}
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

			var lista = new PneusDao().GetPneus(veiculo.Id);

			dataGridPneus.DataSource = lista;
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