using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
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
		}

		private void PreenchePlacas()
		{
			var lista = new VeiculosDao().GetVeiculos();

				comboPlaca.DataSource = lista;
				comboPlaca.ValueMember = "Placa";
		}

		private void BtnAddPneu_Click(object sender, EventArgs e)
		{
			var pneu = new Pneus();
			var veiculo = GetVeiculo();

			pneu.VeiculoId = veiculo.Id;
			pneu.Marca = txtMarca.Text;
			pneu.Estado = comboEstado.Text;
			pneu.DataAdicao = datePneu.Value;
			pneu.Modelo = txtModelo.Text;

			new PneusDao().DbAdd(pneu);

			MessageBox.Show($"Pneu vinculado ao veiculo com sucesso");

			PreencheTabela(veiculo);
		}



		private void PreencheTabela(Veiculos veiculo)
		{
			using (var context = new LocadoraContext())
			{
				var lista = context.Pneus
							 .Where(p => p.VeiculoId == veiculo.Id)
							 .ToList();

				dataGridPneus.DataSource = veiculo;

			}
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