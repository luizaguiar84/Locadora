using BsFat;
using DbFat;
using Utilidades;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormDespesasCarro : Form
	{
		public FormDespesasCarro()
		{
			InitializeComponent();
		}

		private void FormDespesasCarro_Load(object sender, EventArgs e)
		{
			PreenchePlacas();
			AtualizarTabelas();
		}

		private void AtualizarTabelas()
		{
			AtualizaTabelaAbastecimento();
			AtualizaTabelaMultas();
			AtualizaTabelaObrigacoes();
			AtualizaTabelaSinistros();
		}

		private void PreenchePlacas()
		{
			var veiculos = new VeiculosDao().GetAll();

			comboPlaca.DataSource = veiculos;
			comboPlaca.DisplayMember = "Placa";
			AtualizaNomeCarro();
		}

		private void AtualizaNomeCarro()
		{
			Veiculos veiculo = BuscaVeiculo();
			// Operador null - condicional?
			txtNomeCarro.Text = veiculo?.Modelo;
		}

		private Veiculos BuscaVeiculo()
		{
			try
			{
				return new VeiculosDao().GetAll()
						.Where(v => v.Id == ((Veiculos)comboPlaca.SelectedValue).Id)
						.SingleOrDefault();
			}
			catch (Exception)
			{
				MessageBox.Show("Não Existem Veiculos cadastrados!");
				return null;
			}
			
		}

		private void ComboPlaca_SelectedIndexChanged(object sender, EventArgs e)
		{
			AtualizaNomeCarro();
			AtualizarTabelas();
		}

		private void BtnSalvarMulta_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var multasBuilder = new MultasBuilder()
				.getVeiculoId(veiculo.Id)
				.GetDataMulta(dateMulta.Value)
				.GetDescricao(txtDescricaoMulta.Text)
				.GetVencimento(dateMultaVencimento.Value)
				.GetValor(Convert.ToDecimal(txtValorMulta.Text))
				.GetPontos(Convert.ToInt32(txtPontosMulta.Text));

			var multa = multasBuilder.Build();

			new MultasDao().DbAdd(multa);

			MessageBox.Show($"Multa no valor de {multa.Valor.ToString("C")} adicionada com sucesso ao veiculo com placa {veiculo.Placa}!");
			LimparTela();
			AtualizaTabelaMultas();
		}

		private void AtualizaTabelaMultas()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			var dados = new MultasDao().GetAll()
					.Where(o => o.VeiculoId == _veiculo.Id)
					.ToList();
			dataGridMultas.DataSource = dados;
		}

		private void LimparTela()
		{
			this.groupAbastecimento.Controls.LimparTextBoxes();
			this.groupManutencao.Controls.LimparTextBoxes();
			this.groupSinistros.Controls.LimparTextBoxes();
			this.tabObrigacoes.Controls.LimparTextBoxes();
			this.tabMultas.Controls.LimparTextBoxes();
		}

		private void BtnAddAbastecimento_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();

			var abastecimentoBuilder = new AbastecimentosBuilder()
				.GetVeiculoId(veiculo.Id)
				.GetData(dateAbastecimento.Value)
				.GetKm(Convert.ToInt32(txtKmAbastecimento.Text))
				.GetCombustivel(comboCombustivelAbastecimento.Text)
				.GetLitros(Convert.ToDecimal(txtQtdLitrosAbastecimento.Text))
				.GetValorUnitario(Convert.ToDecimal(txtValorUnitAbastecimento.Text));

			var abastecimento = abastecimentoBuilder.Build();

			if (new AbastecimentosDao().DbAdd(abastecimento))
			{
				MessageBox.Show($"Abastecimento no veiculo de placa {veiculo.Placa} no valor de" +
				$"{(abastecimento.ValorUnitario * abastecimento.Litros).ToString("C")} Efetuado.");

				LimparTela();
				AtualizaTabelaAbastecimento();
			}
			else
			{
				MessageBox.Show("Erro no salvamento.");
			}

		}

		private void AtualizaTabelaAbastecimento()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			var dados = new AbastecimentosDao().GetAll()
				.Where(a => a.VeiculoId == _veiculo.Id).ToList();
			dataAbastecimento.DataSource = dados;
		}

		private void BtnAddManutencao_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var manutencoesBuilder = new ManutencoesBuilder()
				.GetData(dateManutencao.Value)
				.GetKm(Convert.ToInt32(txtKmManutencao.Text))
				.GetDescricao(txtDescricaoManutencao.Text)
				.GetValor(Convert.ToDecimal(txtValorManutencao.Text))
				.GetVeiculoId(veiculo.Id);

			Manutencoes manutencao = manutencoesBuilder.Build();

			new ManutencoesDao().DbAdd(manutencao);
			LimparTela();
			MessageBox.Show($"Manutenção no valor de {manutencao.Valor.ToString("C")} no veiculo de placa {veiculo.Placa} Adicionada com sucesso!");
		}


		private void BtnAddObrigacoes_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var obrigacoesBuilder = new ObrigacoesBuilder()
				.GetVeiculoId(veiculo.Id)
				.GetData(dateObrigacoes.Value)
				.GetTipo(comboTipoObrigacoes.ValueMember)
				.GetValor(Convert.ToDecimal(txtValorObrigacoes.Text))
				.GetDescricao(txtDescricaoObrigacoes.Text);

			var obrigacao = obrigacoesBuilder.Build();

			new ObrigacoesDao().DbAdd(obrigacao);

			LimparTela();
			MessageBox.Show($"A Obrigação Financeira no valor de {obrigacao.Valor.ToString("C")} foi adicionada com sucesso!");
			AtualizaTabelaObrigacoes();
		}

		private void AtualizaTabelaObrigacoes()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			var dados = new AbastecimentosDao().GetAll()
				.Where(o => o.VeiculoId == _veiculo.Id).ToList();
			dataGridObrigacoes.DataSource = dados;
		}

		private void BtnAddSinistros_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();

			var sinistrosBuilder = new SinistrosBuilder()
				.GetData(dateSinistros.Value)
				.GetKm(Convert.ToInt32(txtKmSinistro))
				.GetDescricao(txtDescricaoSinistros.Text)
				.GetValor(Convert.ToDecimal(txtValorSinistro.Text))
				.GetVeiculoId(veiculo.Id);

			var sinistros = sinistrosBuilder.Build();

			new SinistrosDao().DbAdd(sinistros);

			MessageBox.Show($"Sinistro no valor de {sinistros.Valor.ToString("C")} adicionado com sucesso!");
			LimparTela();

			AtualizaTabelaSinistros();
		}

		private void AtualizaTabelaSinistros()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;


			var dados = new SinistrosDao().GetAll()
				.Where(s => s.VeiculoId == _veiculo.Id).ToList();
			dataGridSinistros.DataSource = dados;

		}
	}
}
