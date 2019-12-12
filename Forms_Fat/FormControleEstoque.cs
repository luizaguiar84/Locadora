using BsFat;
using DbFat;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace Dll_Forms_Fat
{
	public partial class FormControleEstoque : Form
	{
		private Estoque peca;

		public FormControleEstoque()
		{
			InitializeComponent();
		}

		private void FormControleEstoque_Load(object sender, EventArgs e)
		{
			AtualizaTabela();
		}

		private void btnSalvarEntrada_Click(object sender, EventArgs e)
		{
			if (validaEntrada())
			{
				Estoque estoque = new Estoque();

				estoque.DataAdicao = DateTime.Now.Date;
				estoque.Peca = txtNomeEntrada.Text;
				estoque.Quantidade = Convert.ToInt32(txtQuantidadeEntrada.Text);
				estoque.ValorUnitario = Convert.ToDecimal(txtValorUnitEntrada.Text);
				estoque.Descricao = txtIncluidoPor.Text;

				if (new EstoqueDao().DbAdd(estoque))
				{
					MessageBox.Show("Produto adicionado com sucesso ao estoque!");
					AtualizaTabela();
				}
				else
				{
					MessageBox.Show("Erro ao adicionar entrada no estoque!");
				}
			}
		}

		private bool validaEntrada()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtNomeEntrada.Text))
			{
				MessageBox.Show("Favor informar o nome da peça.");
			}
			else if (String.IsNullOrWhiteSpace(txtQuantidadeEntrada.Text))
			{
				MessageBox.Show("Favor informar a quantidade de peças incluidas no estoque.");
			}
			else if (String.IsNullOrWhiteSpace(txtValorUnitEntrada.Text))
			{
				MessageBox.Show("Favor informar o valor unitário das peças incluidas no estoque.");
			}
			else if (String.IsNullOrWhiteSpace(txtIncluidoPor.Text))
			{
				MessageBox.Show("Favor informar o nome de quem incluiu as peças no estoque.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void AtualizaTabela()
		{

			var estoque = new EstoqueDao().GetAll();

			dataGridConsulta.DataSource = estoque;
		}

		private void btnSalvarSaida_Click(object sender, EventArgs e)
		{
			if (validaSaida())
			{
				peca.Quantidade -= Convert.ToInt32(txtQuantidadeSaida.Text);
				txrDescricaoSaida.Text = peca.Descricao;
				peca.DataSaida = DateTime.Now.Date;

				if (new EstoqueDao().DbUpdate(peca))
				{
					MessageBox.Show("Saida registrada com sucesso!");
					AtualizaTabela();
					this.txtQuantidadeSaida.Text = "";
					this.txtQuantidadeSaida.Text = "";
				}
			}

		}

		private bool validaSaida()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtNomeSaida.Text))
			{
				MessageBox.Show("Favor selecionar a peça na lista.");
			}
			else if (String.IsNullOrWhiteSpace(txtQuantidadeSaida.Text))
			{
				MessageBox.Show("Favor informar a quantidade de peças retiradas do estoque.");
			}
			else if ((Convert.ToInt32(txtQuantidadeSaida.Text)) > peca.Quantidade)
			{
				MessageBox.Show($"Quantidade inválida, {peca.Peca} tem {peca.Quantidade} unidades no estoque.");
			}
			else if (String.IsNullOrWhiteSpace(txtValorUnitSaida.Text))
			{
				MessageBox.Show("Favor informar o valor unitário das peças retiradas do estoque.");
			}
			else if (String.IsNullOrWhiteSpace(txrDescricaoSaida.Text))
			{
				MessageBox.Show("Favor informar o nome de quem retirou as peças do estoque.");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
				if (dateBuscaFinal.Value < dateBuscaInicial.Value)
				{
					MessageBox.Show("Favor selecionar as datas corretamente.");
				}
				else if (dateBuscaFinal.Value > DateTime.Now)
				{
					MessageBox.Show("Não selecionar data final futura.");
				}
				else
				{
				var busca = new EstoqueDao().PesquisaItem(txtPesquisar.Text)
														.Where(es => es.DataAdicao >= dateBuscaInicial.Value && es.DataAdicao <= dateBuscaFinal.Value)
														.ToList();
				dataGridConsulta.DataSource = busca;
			}
			
			
		}

		private void dataGridConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int pecaId = Convert.ToInt32(dataGridConsulta["id", e.RowIndex].Value);
			txtIdSaida.Text = pecaId.ToString();
		}

		private void dataGridConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int pecaId = Convert.ToInt32(dataGridConsulta["id", e.RowIndex].Value);
			txtIdSaida.Text = pecaId.ToString();
		}

		private void txtIdSaida_TextChanged(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtIdSaida.Text);
			var peca = new EstoqueDao().GetById(id);
			txtNomeSaida.Text = peca.Peca;
			txtValorUnitSaida.Text = peca.ValorUnitario.ToString();
			this.peca = peca;
		}

		private void txtQuantidadeEntrada_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtQuantidadeEntrada.IsNumeros(e);
		}

		private void txtValorUnitEntrada_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtValorUnitEntrada.IsNumeros(e);
		}

		private void txtQuantidadeSaida_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtQuantidadeSaida.IsNumeros(e);
		}
	}
}
