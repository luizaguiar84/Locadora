using BsFat;
using DbFat;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormControlePatio : Form
	{
		List<ControlePatio> CarrosFora = new List<ControlePatio>();

		public FormControlePatio()
		{
			InitializeComponent();
		}

		private void TxtkmRetorno_TextChanged(object sender, EventArgs e)
		{
			//lblKmRodado.Text = (int.Parse(txtkmRetorno.Text) - int.Parse(txtKmSaida.Text)).ToString();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			FormCadastrarMotorista formCadastrarMotorista = new FormCadastrarMotorista();
			formCadastrarMotorista.ControlBox = true;
			formCadastrarMotorista.Show();
		}

		private void BtnAddCarro_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo formCadastrarNovoVeiculo = new FormCadastrarVeiculo();
			formCadastrarNovoVeiculo.ControlBox = true;
			formCadastrarNovoVeiculo.Show();
		}

		private void FormControlePatio_Load(object sender, EventArgs e)
		{
			GetCarros();
			GetMotoristas();
			AtualizaTabela();
			AtualizaPlacasFora();
		}

		private void GetMotoristas()
		{

			var motoristas = new FuncionariosDao().GetMotoristas();

			comboMotorista.DataSource = motoristas;
			comboMotorista.DisplayMember = "Nome";

		}

		private void GetCarros()
		{

			var veiculos = new VeiculosDao().GetVeiculosAtivos();

			comboCarros.DataSource = veiculos;
			comboCarros.DisplayMember = "Placa";

		}

		private void TxtKmSaida_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void TxtkmRetorno_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void ComboCarros_SelectedValueChanged(object sender, EventArgs e)
		{
			Veiculos _veiculo = (Veiculos)comboCarros.SelectedItem;
			if (_veiculo != null)
			{
				txtVeiculo.Text = _veiculo.Modelo;
			}
		}

		private void BtnSalvarSaida_Click(object sender, EventArgs e)
		{
			var c = new ControlePatio();

			var veiculo = (Veiculos)comboCarros.SelectedItem;
			c.VeiculoId = veiculo.Id;

			var motorista = (Funcionarios)comboMotorista.SelectedItem;
			c.ClienteId = motorista.Id;

			c.Placa = veiculo.Placa;

			c.DataSaida = dateSaida.Value;
			c.HoraSaida = timeSaida.Value.TimeOfDay;
			c.KmSaida = Convert.ToInt32(txtKmSaida.Text);
			c.NivelCombustivelSaida = comboCombustivelSaida.Text;
			//c.LiberadoSaida = comboLiberadoSaida.Text;
			c.ObservacoesSaida = txtObservacoes.Text;
			c.Status = true;

			if (new ControlePatioDao().DbAdd(c))
			{
				MessageBox.Show("Saida Registrada com Sucesso!");
			}
			else
			{
				MessageBox.Show("Problema no registro da saida, favor tentar novamente.");
			}
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
			comboCombustivelRetorno.SelectedIndex = 0;
			comboCombustivelSaida.SelectedIndex = 0;
			

			var carrosFora = new ControlePatioDao().GetCarrosFora();

			dataGridView1.DataSource = carrosFora;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.Columns["VeiculoId"].Visible = false;
			dataGridView1.Columns["ClienteId"].Visible = false;
			dataGridView1.Columns["Status"].Visible = false;
			dataGridView1.Columns["NivelCombustivelSaida"].Visible = false;
			dataGridView1.Columns["ObservacoesSaida"].Visible = false;
			dataGridView1.Columns["DataRetorno"].Visible = false;
			dataGridView1.Columns["HoraRetorno"].Visible = false;
			dataGridView1.Columns["NivelCombustivelRetorno"].Visible = false;
			dataGridView1.Columns["KmRetorno"].Visible = false;

		CarrosFora = carrosFora;

		}

		private void BtnSalvarRetorno_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtkmRetorno.Text))
			{
				MessageBox.Show("Favor informar a Quilometragem do carro no retorno!");
			}
			else
			{
				ControlePatio controle = (ControlePatio)comboCarrosForaPlaca.SelectedItem;
				var veiculo = new VeiculosDao().GetById(controle.VeiculoId);

				if (RegistraRetorno(controle, veiculo))
				{
					MessageBox.Show("Retorno do carro registrado com êxito");

					AtualizaTabela();
					AtualizaPlacasFora();

					this.groupRetorno.Controls.LimparTextBoxes();
					this.groupSaida.Controls.LimparTextBoxes();
				}


			}
		}


			private bool RegistraRetorno(ControlePatio controle, Veiculos veiculo)
		{
			controle.DataRetorno = dateRetorno.Value.Date;
			controle.HoraRetorno = timeRetorno.Value.TimeOfDay;
			//controle.EstadoRetorno = comboEstadoRetorno.Text;
			controle.NivelCombustivelRetorno = comboCombustivelRetorno.Text;
			controle.KmRetorno = Convert.ToInt32(txtkmRetorno.Text);
			controle.Status = false;

			return new ControlePatioDao().RegistraRetorno(controle, veiculo);
		}

		private void PreencheDados(ControlePatio c)
		{
			dateSaida.Value = c.DataSaida.Value;

			txtKmSaida.Text = c.KmSaida.ToString();
			comboCombustivelSaida.Text = c.NivelCombustivelSaida;
			txtObservacoes.Text = c.ObservacoesSaida;
		}

		private void ComboCarrosForaPlaca_SelectedIndexChanged(object sender, EventArgs e)
		{
			ControlePatio controle = new ControlePatio();
			controle = (ControlePatio)comboCarrosForaPlaca.SelectedItem;

			PreencheDados(controle);
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int veiculoId = Convert.ToInt32(dataGridView1["id", e.RowIndex].Value);

			var controle = CarrosFora.Single(x => x.Id == veiculoId);

			PreencheDados(controle);
		}

		private void ComboCarros_SelectedIndexChanged(object sender, EventArgs e)
		{
			var veiculo = GetVeiculo();
			txtKmSaida.Text = veiculo.Quilometragem.ToString();
		}

		private Veiculos GetVeiculo()
		{
			return (Veiculos)comboCarros.SelectedItem;
		}

		private void TxtkmRetorno_Leave(object sender, EventArgs e)
		{
			if (Convert.ToInt32(txtkmRetorno.Text) < Convert.ToInt32(txtKmSaida.Text))
			{
				MessageBox.Show("Favor inserir o número de Quilometros rodados corretamente.");
				txtkmRetorno.Text = "";
				txtkmRetorno.Focus();
			}
		}

		private void groupSaida_Enter(object sender, EventArgs e)
		{

		}
	}
}
