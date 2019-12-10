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
			FormCadastrarMotorista formCadastrarMotorista = new FormCadastrarMotorista
			{
				ControlBox = false,
				ShowIcon = false
			};
			formCadastrarMotorista.MdiParent = this.MdiParent;
			formCadastrarMotorista.Show();
		}

		private void BtnAddCarro_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo formCadastrarNovoVeiculo = new FormCadastrarVeiculo();
			formCadastrarNovoVeiculo.MdiParent = this.MdiParent;
			formCadastrarNovoVeiculo.Show();
		}

		private void FormControlePatio_Load(object sender, EventArgs e)
		{
			ResetTela();
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
			if (validaSaida())
			{
				var controle = new ControlePatio();

				var veiculo = (Veiculos)comboCarros.SelectedItem;
				controle.VeiculoId = veiculo.Id;

				var motorista = (Funcionarios)comboMotorista.SelectedItem;
				controle.ClienteId = motorista.Id;

				controle.Placa = veiculo.Placa;

				controle.DataSaida = dateSaida.Value.Date;
				controle.HoraSaida = timeSaida.Value.TimeOfDay;
				controle.KmSaida = Convert.ToInt32(txtKmSaida.Text);
				controle.NivelCombustivelSaida = comboCombustivelSaida.Text;
				//c.LiberadoSaida = comboLiberadoSaida.Text;
				controle.ObservacoesSaida = txtObservacoes.Text;
				controle.Status = true;

				if (new ControlePatioDao().DbAdd(controle))
				{
					MessageBox.Show("Saida Registrada com Sucesso!");
					ResetTela();
				}
				else
				{
					MessageBox.Show("Veiculo já se encontra fora do pátio, favor selecionar outro.");
				}
				
			}
		}

		private void ResetTela()
		{
			GetCarros();
			GetMotoristas();
			AtualizaTabela();
			AtualizaPlacasFora();
			this.groupSaida.Controls.LimparTextBoxes();
			this.groupRetorno.Controls.LimparTextBoxes();
			dateRetorno.Value = DateTime.Now;
			dateSaida.Value = DateTime.Now;
			timeSaida.Value = DateTime.Now;
			timeRetorno.Value = DateTime.Now;
		}

		private bool validaSaida()
		{
			bool ret = false;

			if (String.IsNullOrWhiteSpace(txtKmSaida.Text))
			{
				MessageBox.Show("Favor selecionar um veiculo na lista!");
			}
			else
			{
				ret = true;
			}

			return ret;
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
			if (validaRetorno())
			{
				ControlePatio controle = (ControlePatio)comboCarrosForaPlaca.SelectedItem;
				var veiculo = new VeiculosDao().GetById(controle.VeiculoId);

				if (RegistraRetorno(controle, veiculo))
				{
					MessageBox.Show("Retorno do carro registrado com êxito");

					ResetTela();
				}
			}
		
		}

		private bool validaRetorno()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtKmSaida.Text))
			{
				MessageBox.Show("Favor selecionar o carro na lista");
			}
			else if (String.IsNullOrWhiteSpace(txtkmRetorno.Text))
			{
				MessageBox.Show("Favor informar a Quilometragem do carro no retorno!");
			}
			else if (!String.IsNullOrWhiteSpace(txtkmRetorno.Text))
			{
				if (Convert.ToInt32(txtkmRetorno.Text) < Convert.ToInt32(txtKmSaida.Text))
				{
					MessageBox.Show("Favor informar a quilometragem de retorno correta!");
				}
				else
				{
					ret = true;
				}
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private bool RegistraRetorno(ControlePatio controle, Veiculos veiculo)
		{
			controle.DataRetorno = dateRetorno.Value.Date;
			controle.HoraRetorno = timeRetorno.Value.TimeOfDay;
			//controle.EstadoRetorno = comboEstadoRetorno.Text;
			controle.NivelCombustivelRetorno = comboCombustivelRetorno.Text;
			controle.KmRetorno = Convert.ToInt32(txtkmRetorno.Text);
			controle.Status = false;
			veiculo.Disponivel = true;

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
			//if (Convert.ToInt32(txtkmRetorno.Text) < Convert.ToInt32(txtKmSaida.Text))
			//{
			//	MessageBox.Show("Favor inserir o número de Quilometros rodados corretamente.");
			//	txtkmRetorno.Text = "";
			//	txtkmRetorno.Focus();
			//}
		}

		private void groupSaida_Enter(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FormControlePatio_Activated(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void FormControlePatio_Enter(object sender, EventArgs e)
		{
			this.Refresh();
		}

	}
}
