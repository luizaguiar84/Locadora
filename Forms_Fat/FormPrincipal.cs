using BsFat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormPrincipal : Form
	{
		private Usuarios usuario;

		public FormPrincipal(BsFat.Usuarios usuario)
		{
			InitializeComponent();
			this.usuario = usuario;
			controleDeAcesso(usuario);
		}

		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void controleDeAcesso(Usuarios usuario)
		{
			cadastrarToolStripMenuItem.Visible = true;
			sobreToolStripMenuItem.Visible = true;

			cadastrarNovoUsuárioToolStripMenuItem1.Visible = false; // cadastrar novo usuario
			cadastrarNovoVeículoToolStripMenuItem.Visible = false; // Cadastrar Novo Veiculo
			funcionáriosToolStripMenuItem.Visible = false; // Cadastrar Funcionário
			cadastrarClienteToolStripMenuItem.Visible = false; // Cadastrar Cliente
			controleDePreçosToolStripMenuItem.Visible = false; // Adicionar ou Editar Cargos
			editarUsuáriosToolStripMenuItem.Visible = false; // Editar Usuários

			clientesToolStripMenuItem1.Visible = false; // Busca Cliente
			veiculosToolStripMenuItem.Visible = false; // Busca Veiculos
			consultarEditarUsuáriosToolStripMenuItem.Visible = false; // consultar / editar usuarios
			consultarEditarMotoristasToolStripMenuItem.Visible = false; // consultar e editar motoristas
			monitorarVeículosAtivosToolStripMenuItem.Visible = false; // Monitorar Veiculos

			consultarComprovantesToolStripMenuItem.Visible = false; // Consultar Comprovantes
			relatóriosToolStripMenuItem2.Visible = false; //Relatorios
			controleDePátioToolStripMenuItem.Visible = false; // controle de patio
			controleDePneusToolStripMenuItem.Visible = false; // controle de pneus
			estoqueToolStripMenuItem1.Visible = false; // controle de estoque
			consultarEditarEstoqueDePeçasToolStripMenuItem.Visible = false; // controle de estoque
			registrarAlertaToolStripMenuItem.Visible = false; // registrar alerta
			despesasToolStripMenuItem.Visible = false; // registrar despesas
			despesasDeCarrosToolStripMenuItem.Visible = false; // despesas de carros

			if (usuario.Nivel == 3)
			{
				// Acesso Total
				cadastrarNovoUsuárioToolStripMenuItem1.Visible = true; // cadastrar novo usuario
				cadastrarNovoVeículoToolStripMenuItem.Visible = true; // Cadastrar Novo Veiculo
				funcionáriosToolStripMenuItem.Visible = true; // Cadastrar Funcionário
				cadastrarClienteToolStripMenuItem.Visible = true; // Cadastrar Cliente
				controleDePreçosToolStripMenuItem.Visible = true; // Adicionar ou Editar Cargos
				editarUsuáriosToolStripMenuItem.Visible = true; // Editar Usuários

				cadastrarNovoVeículoToolStripMenuItem.Visible = true; // Cadastrar Novo Veiculo
				clientesToolStripMenuItem1.Visible = true; // Busca Cliente
				veiculosToolStripMenuItem.Visible = true; // Busca Veiculos
				cadastrarClienteToolStripMenuItem.Visible = true; // Cadastrar Cliente
				monitorarVeículosAtivosToolStripMenuItem.Visible = true; // Monitorar Veiculos
				consultarComprovantesToolStripMenuItem.Visible = true; // Consultar Comprovantes
				relatóriosToolStripMenuItem2.Visible = true; //Relatorios
				cadastrarNovoUsuárioToolStripMenuItem1.Visible = true; // cadastrar novo usuario
				controleDePátioToolStripMenuItem.Visible = true; // controle de patio
				controleDePneusToolStripMenuItem.Visible = true; // controle de pneus
				estoqueToolStripMenuItem1.Visible = true; // controle de estoque
				controleDePreçosToolStripMenuItem.Visible = true; // Editar Cargos
				consultarEditarEstoqueDePeçasToolStripMenuItem.Visible = true; // controle de estoque
				consultarEditarUsuáriosToolStripMenuItem.Visible = true; // consultar / editar usuarios
				consultarEditarMotoristasToolStripMenuItem.Visible = true; // consultar e editar motoristas
				registrarAlertaToolStripMenuItem.Visible = true; // registrar alerta
				despesasToolStripMenuItem.Visible = true; // registrar despesas
				despesasDeCarrosToolStripMenuItem.Visible = true; // despesas de carros
			}
			else if (usuario.Nivel == 2)
			{
				//Pode editar mas nao cadastrar

				clientesToolStripMenuItem1.Visible = true; // Busca Cliente
				veiculosToolStripMenuItem.Visible = true; // Busca Veiculos
				editarUsuáriosToolStripMenuItem.Visible = true; // Editar Usuários

				monitorarVeículosAtivosToolStripMenuItem.Visible = true; // Monitorar Veiculos
				consultarComprovantesToolStripMenuItem.Visible = true; // Consultar Comprovantes
				controleDePátioToolStripMenuItem.Visible = true; // controle de patio
				controleDePneusToolStripMenuItem.Visible = true; // controle de pneus
				estoqueToolStripMenuItem1.Visible = true; // controle de estoque
				consultarEditarEstoqueDePeçasToolStripMenuItem.Visible = true; // controle de estoque
				consultarEditarUsuáriosToolStripMenuItem.Visible = true; // consultar / editar usuarios
				consultarEditarMotoristasToolStripMenuItem.Visible = true; // consultar e editar motoristas
				registrarAlertaToolStripMenuItem.Visible = true; // registrar alerta
				despesasToolStripMenuItem.Visible = true; // registrar despesas
				despesasDeCarrosToolStripMenuItem.Visible = true; // despesas de carros
			}
			else
			{
				manutençãoToolStripMenuItem.Visible = false;
				controleDePátioToolStripMenuItem.Visible = true; // controle de patio
				controleDePneusToolStripMenuItem.Visible = true; // controle de pneus
				estoqueToolStripMenuItem1.Visible = true; // controle de estoque
				consultarEditarEstoqueDePeçasToolStripMenuItem.Visible = true; // controle de estoque
				despesasToolStripMenuItem.Visible = true; // registrar despesas
				despesasDeCarrosToolStripMenuItem.Visible = true; // despesas de carros
			}

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
				this.Dispose();
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
				this.Dispose();
				Environment.Exit(0);
			}

		}

		private void efetuarLogoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				var login = new FormLogin();
				this.Dispose();
				login.Show();
			}
		}

		private void cadastrarNovoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormCadastrarVeiculo>("CadastrarVeiculos");
		}

		private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormBuscaCliente>("BuscarCliente");
		}

		private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormBuscaCarro>("BuscarCarro");

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

			AbrirNovoForm<FormCadastrarCliente>("CadastrarCliente");


		}

		private void monitorarVeículosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormMonitoramentoVeiculo>("MonitoramentoVeiculo");

		}

		private void consultarComprovantesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormConsultarComprovantes>("ConsultaComprovantes");

		}
		private void RelatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormRelatorios>("Relatorios");
		}

		private void cadastrarNovoUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormCadastrarUsuario>("CadastroUsuarios");
		}

		private void controleDePátioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControlePatio>("ControlePatio");

		}

		private void controleDePneusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControlePneus>("ControlePneus");
		}

		private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControleEstoque>("ControleEstoque");
		}

		private void controleDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormDefinicoes>("Definicoes");
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
			AbrirNovoForm<FormCadastrarFuncionario>("CadastrarFuncionario");
		}

		private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormCadastrarDespesa>("CadastrarDespesa");
		}

		private void despesasDeCarrosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormDespesasCarro>("DespesasCarro");
		}


		private void editarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirNovoForm<FormControleUsuarios>("EditarUsuarios");
		}
		private void AbrirNovoForm<T>(string TAG) where T : Form, new()
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
				ControlBox = false,
				ShowIcon = false,
				WindowState = FormWindowState.Maximized,
				Tag = TAG
			};
			form.Update();
			//form.Refresh();
			form.Focus();
			form.Show();
		}

	}
}
