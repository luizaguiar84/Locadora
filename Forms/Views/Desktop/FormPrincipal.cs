using Forms.Views.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public partial class FormPrincipal : Form
	{

		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSobre sobre = new FormSobre();
			sobre.Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Environment.Exit(0);
			}

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0);
			}

		}

		private void efetuarLogoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FormLogin login = new FormLogin();
				login.Show();
				this.Hide();
			}
		}

		private void cadastrarNovoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo cadastrarNovoVeiculo = new FormCadastrarVeiculo();
			cadastrarNovoVeiculo.MdiParent = this;
			cadastrarNovoVeiculo.Show();

		}

		private void editarExcluirVeículosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var editarVeiculo = new FormEditarVeiculo();
			editarVeiculo.MdiParent = this;
			editarVeiculo.Show();
		}

		private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente consultarCliente = new FormCadastrarCliente();
			consultarCliente.MdiParent = this;
			consultarCliente.Show();
		}

		private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo consultarVeiculo = new FormCadastrarVeiculo();
			consultarVeiculo.MdiParent = this;
			consultarVeiculo.Show();
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{

			FormPrincipal1 principal1 = new FormPrincipal1();
			principal1.MdiParent = this;
			principal1.Show();
		}

		private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
			FormCadastrarCliente cadastrarCliente = new FormCadastrarCliente();
			cadastrarCliente.MdiParent = this;
			cadastrarCliente.Show();
			
		}


		private void monitorarVeículosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMonitoramentoVeiculo formMonitoramentoVeiculo = new FormMonitoramentoVeiculo();
			formMonitoramentoVeiculo.MdiParent = this;
			formMonitoramentoVeiculo.Show();
		}

		private void consultarComprovantesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormConsultarComprovantes formConsultarComprovantes = new FormConsultarComprovantes();
			formConsultarComprovantes.MdiParent = this;
			formConsultarComprovantes.Show();
		}

		private void RelatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormRelatorios formRelatorios = new Views.Desktop.FormRelatorios();
			formRelatorios.Show();
		}

		private void NovaLocaçaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormNovaLocacao formNovaLocacao = new FormNovaLocacao();
			formNovaLocacao.MdiParent = this;
			formNovaLocacao.Show();
		}

		private void cadastrarNovoUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FormCadastrarUsuario cadastrarUsuario = new FormCadastrarUsuario();
			cadastrarUsuario.Show();
		}

		private void controleDePátioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormControlePatio formControlePatio = new Views.Desktop.FormControlePatio();
			formControlePatio.MdiParent = this;
			formControlePatio.Show();
		}

		private void controleDePneusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormControlePneus formControlePneus = new Views.Desktop.FormControlePneus();
			formControlePneus.MdiParent = this;
			formControlePneus.Show();
		}

		private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormControleEstoque controleEstoque = new Views.Desktop.FormControleEstoque();
			controleEstoque.MdiParent = this;
			controleEstoque.Show();
		}

		private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormDevolucao devolucao = new Views.Desktop.FormDevolucao();
			devolucao.MdiParent = this;
			devolucao.Show();
		}

		private void controleDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormDefinicoes definicoes = new Views.Desktop.FormDefinicoes();
			definicoes.ControlBox = true;
			definicoes.Show();

		}

		private void consultarEditarEstoqueDePeçasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormControleEstoque controleEstoque = new Views.Desktop.FormControleEstoque();
			controleEstoque.TabCotroleEstoque.SelectTab(0);
			controleEstoque.MdiParent = this;
			controleEstoque.Show();
		}

		private void consultarEditarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormControleUsuarios controleUsuarios = new Views.Desktop.FormControleUsuarios();
			controleUsuarios.MdiParent = this;
			controleUsuarios.Show();
		}

		private void consultarEditarMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista formCadastrarMotorista = new Views.Desktop.FormCadastrarMotorista();
			formCadastrarMotorista.MdiParent = this;
			formCadastrarMotorista.ControlBox = false;
			formCadastrarMotorista.Show();
		}

		private void registrarAlertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCadastrarVeiculo cadastrarNovoVeiculo = new FormCadastrarVeiculo();
			cadastrarNovoVeiculo.MdiParent = this;
			cadastrarNovoVeiculo.TabCadastroVeiculos.SelectTab(2);
			cadastrarNovoVeiculo.ControlBox = true;
			cadastrarNovoVeiculo.Show();
		}

		private void consultarReservasAtivasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormBuscaLocacao buscaLocacao = new Views.Desktop.FormBuscaLocacao();
			buscaLocacao.ControlBox = false;
			buscaLocacao.MdiParent = this;
			buscaLocacao.Show();
		}

		private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarFuncionario cadastrarFuncionario = new Views.Desktop.FormCadastrarFuncionario();
			cadastrarFuncionario.MdiParent = this;
			cadastrarFuncionario.Show();

		}

		private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarDespesa cadastrarDespesa = new Views.Desktop.FormCadastrarDespesa();
			cadastrarDespesa.MdiParent = this;
			cadastrarDespesa.Show();
		}
	}
	}

