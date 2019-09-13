using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormPrincipal : Form
	{

		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sobre = new FormSobre();
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
				var login = new FormLogin();
				login.Show();
				this.Hide();
			}
		}

		private void cadastrarNovoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cadastrarNovoVeiculo = new FormCadastrarVeiculo
			{
				ControlBox = false,
				MdiParent = this
			};
			cadastrarNovoVeiculo.Show();

		}

		private void editarExcluirVeículosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var editarVeiculo = new FormEditarVeiculo
			{
				ControlBox = false,
				MdiParent = this
			};
			editarVeiculo.Show();
		}

		private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var consultarCliente = new FormBuscaCliente()
			{
				ControlBox = false,
				MdiParent = this
			};
			consultarCliente.Show();
		}

		private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var consultarVeiculo = new FormBuscaCarro()
			{
				ControlBox = false,
				MdiParent = this
			};
			consultarVeiculo.Show();
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{

			var principal1 = new FormPrincipal1
			{
				MdiParent = this
			};
			principal1.Show();
		}

		private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{

			var cadastrarCliente = new FormCadastrarCliente
			{
				ControlBox = false,
				MdiParent = this
			};
			cadastrarCliente.Show();

		}


		private void monitorarVeículosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var formMonitoramentoVeiculo = new FormMonitoramentoVeiculo
			{
				ControlBox = false,
				MdiParent = this
			};
			formMonitoramentoVeiculo.Show();
		}

		private void consultarComprovantesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var formConsultarComprovantes = new FormConsultarComprovantes
			{
				ControlBox = false,
				MdiParent = this
			};
			formConsultarComprovantes.Show();
		}

		private void RelatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var formRelatorios = new FormRelatorios();
			formRelatorios.Show();
		}

		private void NovaLocaçaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var formNovaLocacao = new FormNovaLocacao
			{
				ControlBox = false,
				MdiParent = this
			};
			formNovaLocacao.Show();
		}

		private void cadastrarNovoUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var cadastrarUsuario = new FormCadastrarUsuario();
			cadastrarUsuario.Show();
		}

		private void controleDePátioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControlePatio>("ControlePatio");
			
		}

		private void controleDePneusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm <FormControlePneus>("ControlePneus");
		}

		private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControleEstoque>("ControleEstoque");
		}

		private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormDevolucao>("Devolucao");
		}

		private void controleDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var definicoes = new FormDefinicoes
			{
				ControlBox = true
			};
			definicoes.Show();

		}

		private void consultarEditarEstoqueDePeçasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var controleEstoque = new FormControleEstoque
			{
				ControlBox = false,
				MdiParent = this
			};
			controleEstoque.TabCotroleEstoque.SelectTab(0);
			controleEstoque.Show();
		}

		private void consultarEditarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControleUsuarios>("ControleUsuarios");
		}

		private void consultarEditarMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormCadastrarMotorista>("CadastrarMotorista");
		}

		private void registrarAlertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new FormDespesasCarro
			{
				MdiParent = this,
				ControlBox = true
			};
			form.TabCadastroVeiculos.SelectTab(1);
			form.Show();
		}

		private void consultarReservasAtivasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormBuscaLocacao>("BuscaLocacao");
		}

		private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cadastrarFuncionario = new FormCadastrarFuncionario
			{
				ControlBox = false,
				MdiParent = this
			};
			cadastrarFuncionario.Show();

		}

		private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cadastrarDespesa = new FormCadastrarDespesa
			{
				ControlBox = false,
				MdiParent = this
			};
			cadastrarDespesa.Show();
		}

		private void despesasDeCarrosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var despesaCarro = new FormDespesasCarro
			{
				MdiParent = this,
				ControlBox = false
			};
			despesaCarro.Show();
		}

		void AbrirNovoForm<T>(string TAG) where T : Form, new()
		{
			foreach (Form f in MdiChildren)
			{
				if (f.GetType() == typeof(T))
				{
					f.Activate();
					return;
				}
			}

			Form form = new T
			{
				MdiParent = this,
				Tag = TAG
			};
			form.Show();
		}
	}
}

