using BsFat;
using DbFat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormDevolucao : Form
	{
		private Motoristas cliente;

		public Motoristas Cliente { get; private set; }
		public Locacoes Locacao { get; private set; }
		public Veiculos Veiculo { get; private set; }

		public FormDevolucao()
		{
			InitializeComponent();
		}

		private void PreencheResumo()
		{

		}

		public FormDevolucao(Motoristas cliente)
		{
			InitializeComponent();
			this.cliente = cliente;
			this.txtNomeCliente.Text = cliente.Nome;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var formCadastrarNovoVeiculo = new FormCadastrarVeiculo
			{
				ControlBox = true
			};
			formCadastrarNovoVeiculo.TabCadastroVeiculos.SelectTab(3);
			formCadastrarNovoVeiculo.Show();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var buscaLocacao = new FormBuscaLocacao();
			buscaLocacao.Show();
		}

		private void FormDevolucao_Load(object sender, EventArgs e)
		{

		}

		private void txtKmDevolucao_KeyPress(object sender, KeyPressEventArgs e)
		{
			//this.IsNumeros(e);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			BuscaOS();
			PreencheResumo();
		}

		private void BuscaOS()
		{
			MessageBox.Show("Falta Arrumar! BuscaOS");

			//using (var context = new LocadoraContext())
			//{
			//	var query = from locacao in context.Locacoes
			//				join clienteLocacao in context.ClienteLocacao on locacao.Id equals clienteLocacao.LocacaoId
			//				join cliente in context.Clientes on clienteLocacao.ClienteId equals cliente.Id
			//				join veiculo in context.Veiculos on locacao.VeiculoId equals veiculo.Id
			//				where locacao.Id == Convert.ToInt32(txtNrOS.Text)
			//				select new
			//				{
			//					locacao,
			//					cliente,
			//					veiculo
			//				};

			//	if (query.Single().locacao.Id < 0)
			//	{
			//		MessageBox.Show("Valor de OS incorreto, digite novamente.");
			//	}
			//	else
			//	{
			//		Cliente = query.SingleOrDefault().cliente;
			//		Locacao = query.SingleOrDefault().locacao;
			//		Veiculo = query.SingleOrDefault().veiculo;

			//		if (Cliente != null)
			//		{
			//			PreencherDados(Cliente, Locacao);
			//		}
			//		else
			//		{
			//			MessageBox.Show("Valor de OS incorreto, digite novamente.");
			//		}
			//	}
			//}
		}

		private void PreencherDados(Motoristas c, Locacoes l)
		{
			txtNomeCliente.Text = c.Nome;
			txtRetirada.Text = l.DataInicio.ToString();

			lblValorDiaria.Text = Veiculo.ValorDiaria.ToString("C");

			var dias = (int)Math.Ceiling((decimal)l.DataFinal.Value.Subtract(l.DataInicio.Value).Days);
			lblDias.Text = dias.ToString();

			lblSubTotal.Text = (dias * Veiculo.ValorDiaria).ToString("C");

			lblValorSeguro.Text = (Locacao.ValorSeguro + Locacao.ValorSeguroTerceiros).ToString("C");

			lblAdiantamento.Text = l.ValorAntecipado.ToString("C");

			lblValorRestante.Text = (l.ValorTotal - l.ValorAntecipado).ToString("C");

		}

		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			FinalizarDevolucao();
		}

		private void FinalizarDevolucao()
		{
			if (Cliente == null || Locacao == null)
			{
				MessageBox.Show("Favor preencher corretamente o Numero da OS.");
			}
			else
			{
				Locacao.IsAtiva = false;

				new VeiculosDao().RegistrarKmDb(Veiculo, Convert.ToInt32(txtKmDevolucao.Text));
				new PneusDao().DbUpdateKm(Locacao, Veiculo);
				new LocacoesDao().DbUpdate(Locacao);

				MessageBox.Show("Locação Finalizada com sucesso!");
			}
		}
	}
}
