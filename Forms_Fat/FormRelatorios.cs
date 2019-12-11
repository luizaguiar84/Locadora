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
			string nomeTela;
			string lbl2 = "";

			#region Lista de veiculos
			if (radioListagemVeiculos.Checked) //Lista de Veiculos
			{
				var lista = new VeiculosDao().GetAll();
				resultado = lista;
				nomeTela = "Lista de Veiculos";
				lbl2 = $"Existem {lista.Count()} Veiculos cadastrados no sistema";

				AbreRelatorio(resultado, nomeTela, lbl2);
			} 
			#endregion

			#region Lista de Motoristas
			else if (radioListagemMotoristas.Checked) // Lista de Motoristas
			{
				var lista = new FuncionariosDao().GetMotoristas();
				resultado = lista;
				nomeTela = "Lista de Motoristas";
				lbl2 = $"Existem {lista.Count()} funcionários cadastrados no sistema.";

				AbreRelatorio(resultado, nomeTela, lbl2);
			} 
			#endregion

			#region Lista de Clientes
			else if (radioListagemClientes.Checked) // Lista de Clientes
			{
				var lista = new ClientesPjDao().GetAll();

				resultado = lista;
				nomeTela = "Lista de Clientes";
				lbl2 = $"Existem {lista.Count()} clientes cadastrados no sistema";

				AbreRelatorio(resultado, "Lista de Clientes", lbl2);
			} 
			#endregion

			#region Multas por veiculo
			else if (radioMultasPorVeiculo.Checked) // Multas por veiculo
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else if (!ConfereData())
				{

				}

				else
				{
					var veiculo = GetVeiculo();
					var lista = new MultasDao().GetAll()
								.Where(m => m.VeiculoId == veiculo.Id)
								.Where(m => m.DataMulta >= dateInicio.Value && m.DataMulta <= dateFim.Value)
								.ToList();

					resultado = lista;
					nomeTela = $"Multas de {veiculo.Placa} - {dateInicio.Value.ToShortDateString()} a {dateFim.Value.ToShortDateString()}";
					lbl2 = $"O total de multas do veiculo {veiculo.Placa} é de {lista.Sum(v => v.Valor).ToString("C")}";

					AbreRelatorio(resultado, nomeTela, lbl2);
				}
			} 
			#endregion

			#region Sinistro por veiculo
			else if (radioSinistroVeiculo.Checked) // Sinistro por veículo
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else if (!ConfereData())
				{
				}
				else
				{
					var veiculo = GetVeiculo();
					var lista = new SinistrosDao().GetAll()
						.Where(s => s.VeiculoId == veiculo.Id)
						.Where(a => a.Data >= dateInicio.Value && a.Data <= dateFim.Value)
						.ToList();

					resultado = lista;
					nomeTela = $"Sinistros do veículo {veiculo.Placa}";
					lbl2 = $"O valor gasto com sinistros do veiculo {veiculo.Placa} foi de {lista.Sum(v => v.Valor).ToString("C")}";

					AbreRelatorio(resultado, nomeTela, lbl2);
				}
			} 
			#endregion

			else if (radioMultaPorMotorista.Checked) // multa por motorista
			{

			}
			#region Abastecimento Geral
			else if (radioAbastecimentoGeral.Checked) // abastecimento geral
			{
				if (!ConfereData())
				{
				}
				else
				{
					var lista = new AbastecimentosDao().GetAll()
						.Where(a => a.Data >= dateInicio.Value && a.Data <= dateFim.Value)
						.ToList();

					resultado = lista;
					nomeTela = "Lista de Abastecimentos Geral";

					AbreRelatorio(resultado, nomeTela);
				} 
			}

			#endregion

			#region Manutenção por Veiculo
			else if (radioListaManutencaoPorVeiculo.Checked) // manutencao por veiculo
			{
				if (conferePlacaSelecionada())
				{
					MensagemPlaca();
				}
				else if (!ConfereData())
				{
				}
				else
				{
					var veiculo = GetVeiculo();
					var lista = new ManutencoesDao().GetAll()
						.Where(m => m.VeiculoId == veiculo.Id)
						.Where(m => m.Data >= dateInicio.Value && m.Data <= dateFim.Value)
						.ToList();

					resultado = lista;
					nomeTela = $"Manutenções do veiculo {veiculo.Placa}";
					lbl2 = $"O valor total gasto com manutenções do veiculo {veiculo.Placa} foi de {lista.Sum(v => v.Valor).ToString("C")}";

					AbreRelatorio(resultado, nomeTela, lbl2);
				}
			}
			#endregion

			#region Manutenção por veiculo
			else if (radioManutencoesGeral.Checked) // Manutencao por veiculo
			{
				if (!ConfereData())
				{

				}
				
				else
				{
					var lista = new ManutencoesDao().GetAll()
						.Where(m => m.Data >= dateInicio.Value && m.Data <= dateFim.Value)
						.ToList();

					resultado = lista;
					nomeTela = $"Manutenções {dateInicio.Value.ToShortDateString()} a {dateFim.Value.ToShortDateString()}";
					lbl2 = $"O total em manutenções no periodo selecionado é de {lista.Sum(l => l.Valor).ToString("C")}";
					AbreRelatorio(resultado, nomeTela, lbl2);
				}
			}
			#endregion

			else if (radioListagemEstoque.Checked)
			{

			}

			#region Manutenção Geral
			else if (radioManutencoesGeral.Checked) // Manutencoes Geral
			{
				if (!ConfereData())
				{
				}
				else
				{
					var valor = new ManutencoesDao().GetAll()
						.Where(m => m.Data >= dateInicio.Value && m.Data <= dateFim.Value)
						.ToList();

					resultado = valor;
					nomeTela = "Manutenções Geral";
					lbl2 = $"O valor gasto com manutenção no periodo de {dateInicio.Value.ToShortDateString()} a {dateFim.Value.ToShortDateString()} foi de {valor.Sum(m => m.Valor).ToString("C")}";

					AbreRelatorio(resultado, nomeTela, lbl2);
				}
			} 
			#endregion
		}



		#region Validacoes
		private bool ConfereData()
		{
			//if (dateInicio.Value == dateFim.Value)
			//{
			//	MessageBox.Show("Favor selecionar as datas ao lado.");
			//	return false;
			//}
			if (dateFim.Value < dateInicio.Value)
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

		#endregion


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
