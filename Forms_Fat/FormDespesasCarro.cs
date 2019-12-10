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
			comboCombustivelAbastecimento.SelectedIndex = 0;
			LimparTela();
		}

		private void AtualizarTabelas()
		{
			AtualizaTabelaAbastecimento();
			AtualizaTabelaMultas();
			AtualizaTabelaObrigacoes();
			AtualizaTabelaSinistros();
			AtualizaTabelaManutencao();
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
			if (validacaoMulta())
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

				if (new MultasDao().DbAdd(multa))
				{
					MessageBox.Show($"Multa no valor de {multa.Valor.ToString("C")} adicionada com sucesso ao veiculo com placa {veiculo.Placa}!");
					LimparTela();
					AtualizaTabelaMultas();
				}
				else
				{
					MessageBox.Show("Erro na gravação da multa, tente novamente.");
				}
			}
		}

		private bool validacaoMulta()
		{
			bool ret = false;

			if (String.IsNullOrWhiteSpace(txtPontosMulta.Text))
			{
				MessageBox.Show("Favor preencher os pontos da multa!");
			}
			else if (String.IsNullOrWhiteSpace(txtValorMulta.Text))
			{
				MessageBox.Show("Favor preencher o valor da multa!");
			}
			else if ((Convert.ToInt32(txtPontosMulta.Text)) > 10)
			{
				MessageBox.Show("Numero de pontos de multa inválidos.");
			}
			else if (String.IsNullOrWhiteSpace(txtDescricaoMulta.Text))
			{
				MessageBox.Show("Favor informar a descrição da multa!");
			}
			else
			{
				ret = true;
			}
			return ret;
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
			if (validaAbastecimento())
			{
				var veiculo = BuscaVeiculo();

				var abastecimentoBuilder = new AbastecimentosBuilder()
					.GetVeiculoId(veiculo.Id)
					.GetData(dateAbastecimento.Value)
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

		}

		private bool validaAbastecimento()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtQtdLitrosAbastecimento.Text))
			{
				MessageBox.Show("Favor informar a quantidade de litros abastecidos.");
			}
			else if (string.IsNullOrWhiteSpace(txtValorUnitAbastecimento.Text))
			{
				MessageBox.Show("Favor informar o valor do litro no abastecimento.");
			}
			else
			{
				ret = true;
			}
			return ret;
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
			if (validaManutencao())
			{
				var veiculo = BuscaVeiculo();
				var manutencoesBuilder = new ManutencoesBuilder()
					.GetData(dateManutencao.Value)
					.GetKm(Convert.ToInt32(txtKmManutencao.Text))
					.GetDescricao(txtDescricaoManutencao.Text)
					.GetValor(Convert.ToDecimal(txtValorManutencao.Text))
					.GetVeiculoId(veiculo.Id);

				Manutencoes manutencao = manutencoesBuilder.Build();

				if (new ManutencoesDao().DbAdd(manutencao))
				{
					LimparTela();
					MessageBox.Show($"Manutenção no valor de {manutencao.Valor.ToString("C")} no veiculo de placa {veiculo.Placa} Adicionada com sucesso!");
					AtualizaTabelaManutencao();
				}
				else
				{
					MessageBox.Show("Erro ao adicinar a manutenção, favor tentar novamente.");
				}
			}
		}

		private void AtualizaTabelaManutencao()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			var dados = new ManutencoesDao().GetAll()
				.Where(o => o.VeiculoId == _veiculo.Id).ToList();
			dataGridManutencao.DataSource = dados;
		}

		private bool validaManutencao()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtDescricaoManutencao.Text))
			{
				MessageBox.Show("Favor informar a descrição da manutenção.");
			}
			else if (String.IsNullOrWhiteSpace(txtKmManutencao.Text))
			{
				MessageBox.Show("Favor informar a km em que ocorreu a manutenção.");
			}
			else if (String.IsNullOrWhiteSpace(txtValorManutencao.Text))
			{
				MessageBox.Show("Favor informar o valor da manutenção.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void BtnAddObrigacoes_Click(object sender, EventArgs e)
		{
			if (validarObrigacoes())
			{
				var veiculo = BuscaVeiculo();
				var obrigacoesBuilder = new ObrigacoesBuilder()
					.GetVeiculoId(veiculo.Id)
					.GetData(dateObrigacoes.Value)
					.GetTipo(txtTipoObrigacao.Text)
					.GetValor(Convert.ToDecimal(txtValorObrigacoes.Text))
					.GetDescricao(txtDescricaoObrigacoes.Text);

				var obrigacao = obrigacoesBuilder.Build();

				if (new ObrigacoesDao().DbAdd(obrigacao))
				{
					LimparTela();
					MessageBox.Show($"A Obrigação Financeira no valor de {obrigacao.Valor.ToString("C")} foi adicionada com sucesso!");
					AtualizaTabelaObrigacoes();
				}
				else
				{
					MessageBox.Show("Erro na gravação da obrigação, favor tentar novamente.");
				}


			}

		}

		private bool validarObrigacoes()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtValorObrigacoes.Text))
			{
				MessageBox.Show("Favor preencher o valor da obrigação;");
			}
			else if (String.IsNullOrWhiteSpace(txtTipoObrigacao.Text))
			{
				MessageBox.Show("Favor informar o tipo de Obrigação.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void AtualizaTabelaObrigacoes()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			var dados = new ObrigacoesDao().GetAll()
				.Where(o => o.VeiculoId == _veiculo.Id).ToList();
			dataGridObrigacoes.DataSource = dados;
		}

		private void BtnAddSinistros_Click(object sender, EventArgs e)
		{
			if (validaSinistros())
			{
				var veiculo = BuscaVeiculo();

				var sinistrosBuilder = new SinistrosBuilder()
					.GetData(dateSinistros.Value)
					.GetKm(Convert.ToInt32(txtKmSinistro.Text))
					.GetDescricao(txtDescricaoSinistros.Text)
					.GetValor(Convert.ToDecimal(txtValorSinistro.Text))
					.GetVeiculoId(veiculo.Id);

				var sinistros = sinistrosBuilder.Build();

				if (new SinistrosDao().DbAdd(sinistros))
				{
					MessageBox.Show($"Sinistro no valor de {sinistros.Valor.ToString("C")} adicionado com sucesso!");
					LimparTela();

					AtualizaTabelaSinistros();
				}
				else
				{
					MessageBox.Show("Erro na gravação do sinistro, tente novamente.");
				}
			}
		}

		private bool validaSinistros()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtKmSinistro.Text))
			{
				MessageBox.Show("Favor informar a Km onde o sinistro ocorreu");
			}
			else if (String.IsNullOrWhiteSpace(txtValorSinistro.Text))
			{
				MessageBox.Show("Favor informar o valor do sinistro");
			}
			else if (String.IsNullOrWhiteSpace(txtDescricaoSinistros.Text))
			{
				MessageBox.Show("Favor informar a descrição do sinistro");
			}
			else
			{
				ret = true;
			}
			return ret;

		}

		private void AtualizaTabelaSinistros()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;


			var dados = new SinistrosDao().GetAll()
				.Where(s => s.VeiculoId == _veiculo.Id).ToList();
			dataGridSinistros.DataSource = dados;

		}

		private void txtValorUnitAbastecimento_TextChanged(object sender, EventArgs e)
		{
			txtTotalAbastecimento.Text = AtualizaValorAbastecimento().ToString("C");
		}

		private double AtualizaValorAbastecimento()
		{
			if (!String.IsNullOrWhiteSpace(txtQtdLitrosAbastecimento.Text))
			{
				if (!String.IsNullOrWhiteSpace(txtValorUnitAbastecimento.Text))
				{
					return (Convert.ToDouble(txtQtdLitrosAbastecimento.Text) * Convert.ToDouble(txtValorUnitAbastecimento.Text));
				}
			}
			return 0;
		}

		private void txtQtdLitrosAbastecimento_TextChanged(object sender, EventArgs e)
		{
			txtTotalAbastecimento.Text = AtualizaValorAbastecimento().ToString("C");
		}

		private void txtQtdLitrosAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorUnitAbastecimento_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtKmManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorManutencao_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtKmSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorSinistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorObrigacoes_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtValorMulta_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void txtPontosMulta_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		
	}
}
