using Forms;
using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{
	public partial class FormControlePatio : Form
	{
		List<ControlePatio> CarrosFora = new List<ControlePatio>();


		public FormControlePatio()
		{
			InitializeComponent();
		}

		private void txtkmRetorno_TextChanged(object sender, EventArgs e)
		{
			//lblKmRodado.Text = (int.Parse(txtkmRetorno.Text) - int.Parse(txtKmSaida.Text)).ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista formCadastrarMotorista = new FormCadastrarMotorista();
			formCadastrarMotorista.ControlBox = true;
			formCadastrarMotorista.Show();
		}

		private void btnAddCarro_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo formCadastrarNovoVeiculo = new FormCadastrarVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.Show();
		}

		private void FormControlePatio_Load(object sender, EventArgs e)
		{
			CarregaCarros();
			CarregaMotoristas();
			AtualizaTabela();
			AtualizaPlacasFora();

		}


		private void CarregaMotoristas()
		{
			using (var contexto = new LocadoraContext())
			{
				var motorista = contexto.Cliente
								.Where(c => c.Cnh.Numero != null)
								.ToList();

				comboMotorista.DataSource = motorista;
				comboMotorista.DisplayMember = "Nome";
			}
		}

		private void CarregaCarros()
		{
			using (var contexto = new LocadoraContext())
			{
				var veiculos = contexto.Veiculos
								.Where(v => v.Status == "ATIVO")
								.ToList();

				comboCarros.DataSource = veiculos;
				comboCarros.DisplayMember = "Placa";
			}
		}

		private void txtKmSaida_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void maskedDataSaida_Leave(object sender, EventArgs e)
		{
		}

		private void maskedDataRetorno_Leave(object sender, EventArgs e)
		{
		}

		private void txtkmRetorno_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void comboCarros_SelectedValueChanged(object sender, EventArgs e)
		{
			Veiculo _veiculo = (Veiculo)comboCarros.SelectedItem;
			txtVeiculo.Text = _veiculo.Modelo;
		}

		private void brnSalvarSaida_Click(object sender, EventArgs e)
		{
			RegistrarSaida();
		}

		private void RegistrarSaida()
		{
			var c = new ControlePatio();

			var veiculo = (Veiculo)comboCarros.SelectedItem;
			c.VeiculoId = veiculo.Id;

			var motorista = (Cliente)comboMotorista.SelectedItem;
			c.ClienteId = motorista.Id;

			c.Placa = veiculo.Placa;

			c.SaidaPatio = Convert.ToDateTime(dateTimeSaida.Value);
			c.KmSaida = Convert.ToInt32(txtKmSaida.Text);
			c.NivelCombustivelSaida = comboCombustivelSaida.Text;
			c.LiberadoSaida = comboLiberadoSaida.Text;
			c.ObservacoesSaida = txtObservacoes.Text;
			c.Status = 1;

			using (var repo = new LocadoraContext())
			{
				repo.ControlePatio.Add(c);
				repo.SaveChanges();
			}

			MessageBox.Show("Saida Registrada com Sucesso!");

			AtualizaTabela();
			AtualizaPlacasFora();

			this.groupSaida.Controls.LimparTextBoxes();

		}

		private void AtualizaPlacasFora()
		{
			
			comboCarrosForaPlaca.DataSource = CarrosFora;
			comboCarrosForaPlaca.DisplayMember = "Placa";
		
		}


		private void AtualizaTabela()
		{
			using (var repo = new LocadoraContext())
			{
				var carrosFora = repo.ControlePatio
									.Where(c => c.Status == 1)
									.ToList();
								

				dataGridView1.DataSource = carrosFora;

				CarrosFora = carrosFora;

				
			}
		}
						
		

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnSalvarRetorno_Click(object sender, EventArgs e)
		{
			ControlePatio controle = (ControlePatio)comboCarrosForaPlaca.SelectedItem;
			RegistraRetorno(controle);
		}

		private void RegistraRetorno(ControlePatio controle)
		{
			controle.RetornoPatio = dateTimeRetorno.Value;
			controle.EstadoRetorno = comboEstadoRetorno.ValueMember;
			controle.NivelCombustivelRetorno = comboCombustivelRetorno.ValueMember;
			controle.KmRetorno = Convert.ToInt32(txtkmRetorno.Text);
			controle.Status = 0;

			using (var repo = new LocadoraContext())
			{
				repo.ControlePatio.Update(controle);
				repo.SaveChanges();
			}

			MessageBox.Show("Retorno do carro registrado com êxito");

			AtualizaTabela();
			AtualizaPlacasFora();

			this.groupRetorno.Controls.LimparTextBoxes();
			this.groupSaida.Controls.LimparTextBoxes();
		}

		

		private void PreencheDados(ControlePatio c)
		{
			txtKmSaida.Text = c.KmSaida.ToString();
			comboCombustivelSaida.ValueMember = c.NivelCombustivelSaida;
			txtObservacoes.Text = c.ObservacoesSaida;
		}

		private void comboCarrosForaPlaca_SelectedIndexChanged(object sender, EventArgs e)
		{
			ControlePatio controle = new ControlePatio();
			controle = (ControlePatio)comboCarrosForaPlaca.SelectedItem;

			PreencheDados(controle);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int veiculoId = Convert.ToInt32(dataGridView1["id", e.RowIndex].Value);

			var controle = CarrosFora.Single(x => x.Id == veiculoId);

			PreencheDados(controle);
		}
	}
}
