using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
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
			
				var veiculos = new VeiculosDao().GetVeiculos();

				comboPlaca.DataSource = veiculos;
				comboPlaca.DisplayMember = "Placa";
				AtualizaNomeCarro();
		}

		private void AtualizaNomeCarro()
		{
			Veiculos veiculo = BuscaVeiculo();
			txtNomeCarro.Text = veiculo.Modelo;
		}

		private Veiculos BuscaVeiculo()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			using (var repo = new LocadoraContext())
			{
				var veiculo = repo.Veiculos
								.Where(v => v.Id == _veiculo.Id)
								.SingleOrDefault();
				return veiculo;
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
			var multa = new Multas
			{
				VeiculoId = veiculo.Id,
				DataMulta = dateMulta.Value,
				Descricao = txtDescricaoMulta.Text,
				Vencimento = dateMultaVencimento.Value,
				Valor = Convert.ToDecimal(txtValorMulta.Text),
				Pontos = Convert.ToInt32(txtPontosMulta.Text)
			};

			new MultasDao().DbAdd(multa);

			MessageBox.Show($"Multa no valor de {multa.Valor.ToString("C")}" +
							$" adicionada com sucesso ao veiculo com placa " +
							$"{veiculo.Placa}!");

			LimparTela();

			AtualizaTabelaMultas();
		}

		private void AtualizaTabelaMultas()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			using (var contexto = new LocadoraContext())
			{
				var dados = contexto.Multas
						.Where(o => o.VeiculoId == _veiculo.Id).ToList();

				dataGridMultas.DataSource = dados;
			}
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
			var abastecimento = new Abastecimentos
			{
				VeiculoId = veiculo.Id,
				Data = dateAbastecimento.Value,
				Km = Convert.ToInt32(txtKmAbastecimento.Text),
				Combustivel = comboCombustivelAbastecimento.Text,
				Litros = Convert.ToDecimal(txtQtdLitrosAbastecimento.Text),
				ValorUnitario = Convert.ToDecimal(txtValorUnitAbastecimento.Text)
			};

			new AbastecimentosDao().DbAdd(abastecimento);


			MessageBox.Show($"Abastecimento no veiculo de placa {veiculo.Placa} no valor de" +
				$"{(abastecimento.ValorUnitario * abastecimento.Litros).ToString("C")} Efetuado.");

			LimparTela();

			AtualizaTabelaAbastecimento();
		}

		private void AtualizaTabelaAbastecimento()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;
			using (var contexto = new LocadoraContext())
			{
				var dados = contexto.Abastecimentos.Where(a => a.VeiculoId == _veiculo.Id).ToList();
				dataAbastecimento.DataSource = dados;
			}
		}

		private void BtnAddManutencao_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var manutencao = new Manutencoes
			{
				VeiculoId = veiculo.Id,

				Data = dateManutencao.Value,
				Km = Convert.ToInt32(txtKmManutencao.Text),
				Descricao = txtDescricaoManutencao.Text,
				Valor = Convert.ToDecimal(txtValorManutencao.Text)
			};

			new ManutencoesDao().DbAdd(manutencao);

			LimparTela();
			MessageBox.Show($"Manutenção no valor de {manutencao.Valor.ToString("C")} no veiculo de placa {veiculo.Placa} Adicionada com sucesso!");
		}

		
		private void BtnAddObrigacoes_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var obrigacao = new Obrigacoes
			{
				VeiculoId = veiculo.Id,
				Data = dateObrigacoes.Value,
				Tipo = comboTipoObrigacoes.ValueMember,
				Valor = Convert.ToDecimal(txtValorObrigacoes.Text),
				Descricao = txtDescricaoObrigacoes.Text
			};

			new ObrigacoesDao().DbAdd(obrigacao);

			LimparTela();
			MessageBox.Show($"A Obrigação Financeira no valor de {obrigacao.Valor.ToString("C")} foi adicionada com sucesso!");
			AtualizaTabelaObrigacoes();
		}

		private void AtualizaTabelaObrigacoes()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			using (var contexto = new LocadoraContext())
			{
				var dados = contexto.Obrigacoes.Where(o => o.VeiculoId == _veiculo.Id).ToList();
				dataGridObrigacoes.DataSource = dados;
			}
		}

		private void BtnAddSinistros_Click(object sender, EventArgs e)
		{
			var veiculo = BuscaVeiculo();
			var sinistros = new Sinistros
			{
				VeiculoId = veiculo.Id,
				Data = dateSinistros.Value,
				Km = Convert.ToInt32(txtKmSinistro.Text),
				Descricao = txtDescricaoSinistros.Text,
				Valor = Convert.ToDecimal(txtValorSinistro.Text)
			};

			new SinistrosDao().DbAdd(sinistros);

			MessageBox.Show($"Sinistro no valor de {sinistros.Valor.ToString("C")} adicionado com sucesso!");
			LimparTela();

			AtualizaTabelaSinistros();
		}

		private void AtualizaTabelaSinistros()
		{
			var _veiculo = (Veiculos)comboPlaca.SelectedValue;

			using (var contexto = new LocadoraContext())
			{
				var dados = contexto.Sinistros.Where(s => s.VeiculoId == _veiculo.Id).ToList();
				dataGridSinistros.DataSource = dados;
			}
		}
	}
}
