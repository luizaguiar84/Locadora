using Classes.DAO;
using Classes.Models;
using FatCars.Desktop;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FatCars
{
	public partial class FormNovaLocacao : Form
	{
		Locacoes locacao = new Locacoes();
		DateTime Entrada = new DateTime();
		DateTime Saida = new DateTime();
		private decimal Seguro = 0;
		private decimal ValorRestante = 0;

		public FormNovaLocacao()
		{
			InitializeComponent();
		}
		

		private void Button2_Click(object sender, EventArgs e)
		{
			using (FormCadastrarCliente cadastrarCliente = new FormCadastrarCliente
			{
				ControlBox = true
			})
			{
				cadastrarCliente.Show();
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			using (FormCadastrarVeiculo formCadastrarNovoVeiculo = new FormCadastrarVeiculo
			{
				ControlBox = true
			})
			{
				formCadastrarNovoVeiculo.Show();
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			BuscaCliente(locacao);
		}

		private void BuscaCliente(Locacoes locacao)
		{
			if (locacao is null)
			{
				throw new ArgumentNullException(nameof(locacao));
			}

			using (var formBuscaCliente = new FormBuscaCliente())
			{
				formBuscaCliente.Show();
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			var formBuscaCarro = new FormBuscaCarro();
			formBuscaCarro.Show();
		}

		private void CheckSegRoubo_CheckedChanged(object sender, EventArgs e)
		{
			var dias = GetDias();

			if (Saida < Entrada)
			{
				checkSegRoubo.Checked = false;
				MessageBox.Show("Favor entrar com as datas corretamente.");
			}
			else
			{
				if (checkSegRoubo.Checked)
				{
					Seguro += (Program.Valores.ValorSeguroTerceiros * dias);
					lblValorSeguro.Text = Seguro.ToString("C");
					ValorRestante += Seguro;
					lblValorRestante.Text = ValorRestante.ToString("C");
				}
				else
				{
					Seguro -= (Program.Valores.ValorSeguro * dias);
					lblValorSeguro.Text = Seguro.ToString("C");
					ValorRestante += Seguro;
					lblValorRestante.Text = ValorRestante.ToString("C");
				}
			}
		}

		private void CheckSegTerceiros_CheckedChanged(object sender, EventArgs e)
		{
			var dias = GetDias();

			if (Saida < Entrada)
			{
				checkSegTerceiros.Checked = false;
				MessageBox.Show("Favor entrar com as datas corretamente.");
			}
			else
			{
				if (checkSegTerceiros.Checked == true)
				{
					Seguro += (Program.Valores.ValorSeguroTerceiros * dias);
					lblValorSeguro.Text = Seguro.ToString("C");
					ValorRestante += Seguro;
					lblValorRestante.Text = ValorRestante.ToString("C");

				}
				else
				{
					Seguro -= (Program.Valores.ValorSeguroTerceiros * dias);
					lblValorSeguro.Text = Seguro.ToString("C");
					ValorRestante += Seguro;
					lblValorRestante.Text = ValorRestante.ToString("C");
				}
			}
		}

		private void TxtPagoRetirada_TextChanged(object sender, EventArgs e)
		{
			if (txtPagoRetirada.Text != "")
			{
				lblValorPagoRetirada.Text = Convert.ToDecimal(txtPagoRetirada.Text).ToString("C");
				ValorRestante -= Convert.ToDecimal(txtPagoRetirada.Text);
				lblValorRestante.Text = ValorRestante.ToString("C");
			}
			
		}

		private void DateTimeDevolucao_ValueChanged(object sender, EventArgs e)
		{
			PreencheResumo();
		}

		private void PreencheResumo()
		{
			var veiculo = GetVeiculo();
			int dias = GetDias();

			lblValorDiaria.Text = veiculo.ValorDiaria.ToString("C");

			lblDias.Text = dias.ToString();

			ValorRestante = veiculo.ValorDiaria * dias;

			lblSubTotal.Text = ValorRestante.ToString("C");
			

			if (checkSegRoubo.Checked)
			{
				Seguro += dias * Program.Valores.ValorSeguro;
			}
			if (checkSegTerceiros.Checked)
			{
				Seguro += dias * Program.Valores.ValorSeguroTerceiros;
			}

			lblValorSeguro.Text = Seguro.ToString("C");

			ValorRestante += Seguro;

			lblValorRestante.Text = ValorRestante.ToString("C");
		}

		private int GetDias()
		{
			return (int)Math.Ceiling((decimal)dateTimeDevolucao.Value.Subtract(dateTimeRetirada.Value).Days);
		}

		private void FormNovaLocacao_Load(object sender, EventArgs e)
		{
			lblValorSegRoubo.Text ="(" + Program.Valores.ValorSeguro.ToString("C") +  "/dia)";
			lblValorSegTerceiros.Text ="(" + Program.Valores.ValorSeguroTerceiros.ToString("C") + "/dia)";
			PreencherComboBoxes();


		}

		private void PreencherComboBoxes()
		{
			using (var repo = new LocadoraContext())
			{

				var cliente = repo.Clientes
					.Where(c => c.IsAtivo)
					.ToList();

				var veiculo = repo.Veiculos
					.Where(v => v.IsAtivo)
					.ToList();


				comboCliente.DataSource = cliente;
				comboCliente.DisplayMember = "Nome";

				comboCarro.DataSource = veiculo;
				comboCarro.DisplayMember = "Placa";
			}
		}

		private Clientes GetCliente()
		{
			return (Clientes)comboCliente.SelectedItem;
		}

		private Veiculos GetVeiculo()
		{
			return (Veiculos)comboCarro.SelectedItem;
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			var locacao = new Locacoes();

			var cliente = GetCliente();
			var veiculo = GetVeiculo();
			var dias = GetDias();

			locacao.IsAtiva = true;

			locacao.AddCliente(cliente);
			locacao.DataContrato = DateTime.Now;
			locacao.VeiculoId = veiculo.Id;

			locacao.DataInicio = dateTimeRetirada.Value;
			locacao.HoraInicio = timeRetirada.Value.TimeOfDay;
			locacao.DataFinal = dateTimeDevolucao.Value;
			locacao.HoraFinal = timeDevolucao.Value.TimeOfDay;

			locacao.SeguroCarro = checkSegRoubo.Checked;
			locacao.SeguroTerceiros = checkSegTerceiros.Checked;
			locacao.ValorSeguro = dias * Program.Valores.ValorSeguro;
			locacao.ValorSeguroTerceiros = dias * Program.Valores.ValorSeguroTerceiros;

			locacao.KmInicial = veiculo.Quilometragem;
			locacao.NivelCombustivel = comboCombustivel.Text;
			locacao.ValorAntecipado = Convert.ToDecimal(txtPagoRetirada.Text);
			locacao.LiberadoPor = comboLiberado.Text;
			locacao.FormaDePagamento = comboFormaPagamento.Text;
			locacao.ValorTotal = locacao.CalculaValorTotal(locacao, veiculo);

			new LocacoesDao().DbAdd(locacao);
			
			MessageBox.Show("Locação gerada com sucesso!");

			this.Controls.LimparTextBoxes();
			this.groupSeguro.Controls.LimparTextBoxes();
		}
		

		private void TxtPagoRetirada_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.IsNumeros(e);
		}

		private void ComboCarro_SelectedIndexChanged(object sender, EventArgs e)
		{
			var v = GetVeiculo();
			txtKm.Text = v.Quilometragem.ToString();
			lblValorDiaria.Text = v.ValorDiaria.ToString("C");
		}
	}
}
