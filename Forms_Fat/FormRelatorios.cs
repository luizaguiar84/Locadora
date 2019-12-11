using BsFat;
using DbFat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Utilidades;
using System.Linq;

namespace Dll_Forms_Fat
{
	public partial class FormRelatorios : Form
	{
		public FormRelatorios()
		{
			InitializeComponent();
		}

		private void FormRelatorios_Load(object sender, EventArgs e)
		{
			LimparTela();
			GetPlacas();
		}

		private void GetPlacas()
		{
			var placas = new VeiculosDao().GetAll();
			comboPlacas.DataSource = placas;
			comboPlacas.DisplayMember = "Placa";
		}

		private void LimparTela()
		{
			this.Controls.LimparTextBoxes();
			this.groupPesquisa.Controls.LimparTextBoxes();
			this.groupPesquisaPeriodo.Controls.LimparTextBoxes();
			this.groupPesquisaPeriodo.Controls.LimparTextBoxes();
			this.groupPlacas.Controls.LimparTextBoxes();
			this.groupRelatorios.Controls.LimparTextBoxes();
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			var cliente = new FuncionariosDao();
			var listaClientes = cliente.GetMotoristas();

		}

		private void brnConsultar_Click(object sender, EventArgs e)
		{
			ICollection resultado;

			if (radioListagemVeiculos.Checked) //Lista de Veiculos
			{
				resultado = new VeiculosDao().GetAll();
				AbreRelatorio(resultado, "Lista de Veiculos");
			}
			else if (radioListagemMotoristas.Checked) // Lista de Motoristas
			{
				resultado = new FuncionariosDao().GetMotoristas();
				AbreRelatorio(resultado, "Lista de Motoristas");
			}
			else if (radioListagemClientes.Checked) // Lista de Clientes
			{
				resultado = new ClientesPjDao().GetAll();
				AbreRelatorio(resultado, "Lista de Clientes");
			}
			else if (radioMultasPorVeiculo.Checked) // Multas por veiculo
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else
				{
					var veiculo = GetVeiculo();
					var lista = new MultasDao().GetAll()
								.Where(m => m.VeiculoId == veiculo.Id)
								.ToList();
					resultado = lista;
					AbreRelatorio(resultado, $"Multas do veiculo {veiculo.Placa}",
						$"O total de multas do veiculo {veiculo.Placa} é de {lista.Sum(v=> v.Valor).ToString("C")}");
				}
			}
			else if (radioSinistroVeiculo.Checked) // Sinistro por veículo
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else
				{
					var veiculo = GetVeiculo();
					var lista = new SinistrosDao().GetAll()
						.Where(s => s.VeiculoId == veiculo.Id)
						.ToList();
					resultado = lista;
					AbreRelatorio(resultado, $"Sinistros do veículo {veiculo.Placa}", $"O valor gasto com sinistros do veiculo {veiculo.Placa} foi de {lista.Sum(v => v.Valor).ToString("C")}");
				}
			}
			else if (radioMultaPorMotorista.Checked)
			{

			}
			else if (radioAbastecimentoGeral.Checked)
			{
				resultado = new AbastecimentosDao().GetAll();
				AbreRelatorio(resultado, "Lista de Abastecimentos Geral");
			}
			else if (radioListaManutencaoPorVeiculo.Checked)
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else
				{
					var veiculo = GetVeiculo();
					var lista = new ManutencoesDao().GetAll()
						.Where(m => m.VeiculoId == veiculo.Id)
						.ToList();
					resultado = lista;
					AbreRelatorio(resultado, $"Manutenções do veiculo {veiculo.Placa}", 
						$"O valor total gasto com manutenções do veiculo {veiculo.Placa} foi de {lista.Sum(v => v.Valor).ToString("C")}" );
				}
			}
			else if (radioManutencoesGeral.Checked) // Manutencoes Geral
			{
				if (!ChecaDataValida())
				{
				}
				else
				{
					var valor = new ManutencoesDao().GetAll();
					resultado = valor;
					string lbl2 = $"O valor gasto com manutenção no periodo de {dateInicio.Value.ToShortDateString()} a {dateFim.Value.ToShortDateString()} foi de {valor.Sum(m => m.Valor).ToString("C")}";
					AbreRelatorio(resultado, "Manutenções Geral", lbl2);
				}
			}
		}

		

		private bool ChecaDataValida()
		{
			if (dateInicio.Value == dateFim.Value)
			{
				MessageBox.Show("Favor selecionar as datas ao lado.");
				return false;
			}
			else if (dateFim.Value < dateInicio.Value)
			{
				MessageBox.Show("Favor selecionar as datas corretamente.");
				return false;
			}
			else if (dateFim.Value > DateTime.Now)
			{
				MessageBox.Show("Não selecionar data final futura.");
				return false;
			}
			else
			{
				return true;
			}
		}

		private bool conferePlacaSelecionada()
		{
			if (comboPlacas.SelectedIndex < 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void MensagemPlaca()
		{
			MessageBox.Show("Favor escolher a placa do veiculo na lista ao lado.");
		}

		private Veiculos GetVeiculo()
		{
			return (Veiculos)comboPlacas.SelectedItem;
		}

		private void AbreRelatorio(ICollection resultado, string label)
		{
			var relatorio = new FormResultadoRelatorio(resultado, label)
			{
				MdiParent = this.MdiParent,
				ControlBox = false,
				WindowState = FormWindowState.Maximized
			};
			relatorio.Show();
		}
		private void AbreRelatorio(ICollection resultado, string label, string labelInferior)
		{
			var relatorio = new FormResultadoRelatorio(resultado, label, labelInferior)
			{
				MdiParent = this.MdiParent,
				ControlBox = false,
				WindowState = FormWindowState.Maximized
			};
			relatorio.Show();
		}
	}
}
