namespace FatCars
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.administraçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novaLocaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controleDePátioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cadastrarNovoUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.controleDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.efetuarLogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.despesasDeCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monitorarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controleDePneusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monitorarVeículosAtivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarMotoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarEditarEstoqueDePeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarReservasAtivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarComprovantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarNovoCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçaoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.monitorarToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.relatóriosToolStripMenuItem2,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(804, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// administraçaoToolStripMenuItem
			// 
			this.administraçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaLocaçaoToolStripMenuItem,
            this.devoluçãoToolStripMenuItem,
            this.controleDePátioToolStripMenuItem,
            this.toolStripSeparator2,
            this.cadastrarNovoUsuárioToolStripMenuItem1,
            this.toolStripSeparator3,
            this.controleDePreçosToolStripMenuItem,
            this.toolStripSeparator4,
            this.efetuarLogoffToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.administraçaoToolStripMenuItem.Name = "administraçaoToolStripMenuItem";
			this.administraçaoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.administraçaoToolStripMenuItem.Text = "Administração";
			// 
			// novaLocaçaoToolStripMenuItem
			// 
			this.novaLocaçaoToolStripMenuItem.Name = "novaLocaçaoToolStripMenuItem";
			this.novaLocaçaoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.novaLocaçaoToolStripMenuItem.Text = "Nova Locação...";
			this.novaLocaçaoToolStripMenuItem.Click += new System.EventHandler(this.NovaLocaçaoToolStripMenuItem_Click);
			// 
			// devoluçãoToolStripMenuItem
			// 
			this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
			this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.devoluçãoToolStripMenuItem.Text = "Devolução...";
			this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
			// 
			// controleDePátioToolStripMenuItem
			// 
			this.controleDePátioToolStripMenuItem.Name = "controleDePátioToolStripMenuItem";
			this.controleDePátioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.controleDePátioToolStripMenuItem.Text = "Controle de pátio...";
			this.controleDePátioToolStripMenuItem.Click += new System.EventHandler(this.controleDePátioToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
			// 
			// cadastrarNovoUsuárioToolStripMenuItem1
			// 
			this.cadastrarNovoUsuárioToolStripMenuItem1.Name = "cadastrarNovoUsuárioToolStripMenuItem1";
			this.cadastrarNovoUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
			this.cadastrarNovoUsuárioToolStripMenuItem1.Text = "Cadastrar Novo Usuário...";
			this.cadastrarNovoUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoUsuárioToolStripMenuItem1_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
			// 
			// controleDePreçosToolStripMenuItem
			// 
			this.controleDePreçosToolStripMenuItem.Name = "controleDePreçosToolStripMenuItem";
			this.controleDePreçosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.controleDePreçosToolStripMenuItem.Text = "Definições do sistema...";
			this.controleDePreçosToolStripMenuItem.Click += new System.EventHandler(this.controleDePreçosToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
			// 
			// efetuarLogoffToolStripMenuItem
			// 
			this.efetuarLogoffToolStripMenuItem.Name = "efetuarLogoffToolStripMenuItem";
			this.efetuarLogoffToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.efetuarLogoffToolStripMenuItem.Text = "Efetuar Logoff...";
			this.efetuarLogoffToolStripMenuItem.Click += new System.EventHandler(this.efetuarLogoffToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarNovoVeículoToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.despesasDeCarrosToolStripMenuItem});
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.cadastrarToolStripMenuItem.Text = "Cadastros";
			// 
			// cadastrarClienteToolStripMenuItem
			// 
			this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
			this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cadastrarClienteToolStripMenuItem.Text = "Clientes...";
			this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
			// 
			// cadastrarNovoVeículoToolStripMenuItem
			// 
			this.cadastrarNovoVeículoToolStripMenuItem.Name = "cadastrarNovoVeículoToolStripMenuItem";
			this.cadastrarNovoVeículoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cadastrarNovoVeículoToolStripMenuItem.Text = "Veículos...";
			this.cadastrarNovoVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoVeículoToolStripMenuItem_Click);
			// 
			// funcionáriosToolStripMenuItem
			// 
			this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
			this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.funcionáriosToolStripMenuItem.Text = "Funcionários...";
			this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
			// 
			// despesasToolStripMenuItem
			// 
			this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
			this.despesasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.despesasToolStripMenuItem.Text = "Despesas...";
			this.despesasToolStripMenuItem.Click += new System.EventHandler(this.despesasToolStripMenuItem_Click);
			// 
			// despesasDeCarrosToolStripMenuItem
			// 
			this.despesasDeCarrosToolStripMenuItem.Name = "despesasDeCarrosToolStripMenuItem";
			this.despesasDeCarrosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.despesasDeCarrosToolStripMenuItem.Text = "Despesas de Carros..";
			this.despesasDeCarrosToolStripMenuItem.Click += new System.EventHandler(this.despesasDeCarrosToolStripMenuItem_Click);
			// 
			// monitorarToolStripMenuItem
			// 
			this.monitorarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1,
            this.controleDePneusToolStripMenuItem,
            this.monitorarVeículosAtivosToolStripMenuItem});
			this.monitorarToolStripMenuItem.Name = "monitorarToolStripMenuItem";
			this.monitorarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.monitorarToolStripMenuItem.Text = "Monitorar";
			// 
			// estoqueToolStripMenuItem1
			// 
			this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
			this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
			this.estoqueToolStripMenuItem1.Text = "Estoque...";
			this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
			// 
			// controleDePneusToolStripMenuItem
			// 
			this.controleDePneusToolStripMenuItem.Name = "controleDePneusToolStripMenuItem";
			this.controleDePneusToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.controleDePneusToolStripMenuItem.Text = "Controle de Pneus";
			this.controleDePneusToolStripMenuItem.Click += new System.EventHandler(this.controleDePneusToolStripMenuItem_Click);
			// 
			// monitorarVeículosAtivosToolStripMenuItem
			// 
			this.monitorarVeículosAtivosToolStripMenuItem.Name = "monitorarVeículosAtivosToolStripMenuItem";
			this.monitorarVeículosAtivosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.monitorarVeículosAtivosToolStripMenuItem.Text = "Rastrear Motoristas";
			this.monitorarVeículosAtivosToolStripMenuItem.Click += new System.EventHandler(this.monitorarVeículosAtivosToolStripMenuItem_Click);
			// 
			// manutençãoToolStripMenuItem
			// 
			this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlertaToolStripMenuItem});
			this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
			this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.manutençãoToolStripMenuItem.Text = "Manutenção";
			// 
			// registrarAlertaToolStripMenuItem
			// 
			this.registrarAlertaToolStripMenuItem.Name = "registrarAlertaToolStripMenuItem";
			this.registrarAlertaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.registrarAlertaToolStripMenuItem.Text = "Registrar Manutenção...";
			this.registrarAlertaToolStripMenuItem.Click += new System.EventHandler(this.registrarAlertaToolStripMenuItem_Click);
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.veiculosToolStripMenuItem,
            this.consultarEditarUsuáriosToolStripMenuItem,
            this.consultarEditarMotoristasToolStripMenuItem,
            this.consultarEditarEstoqueDePeçasToolStripMenuItem,
            this.consultarReservasAtivasToolStripMenuItem,
            this.consultarComprovantesToolStripMenuItem});
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.consultarToolStripMenuItem.Text = "Consultar";
			// 
			// clientesToolStripMenuItem1
			// 
			this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
			this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
			this.clientesToolStripMenuItem1.Text = "Consultar/Editar Clientes...";
			this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
			// 
			// veiculosToolStripMenuItem
			// 
			this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
			this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.veiculosToolStripMenuItem.Text = "Consultar/Editar Veículos...";
			this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
			// 
			// consultarEditarUsuáriosToolStripMenuItem
			// 
			this.consultarEditarUsuáriosToolStripMenuItem.Name = "consultarEditarUsuáriosToolStripMenuItem";
			this.consultarEditarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarUsuáriosToolStripMenuItem.Text = "Consultar/Editar Usuários...";
			this.consultarEditarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarEditarUsuáriosToolStripMenuItem_Click);
			// 
			// consultarEditarMotoristasToolStripMenuItem
			// 
			this.consultarEditarMotoristasToolStripMenuItem.Name = "consultarEditarMotoristasToolStripMenuItem";
			this.consultarEditarMotoristasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarMotoristasToolStripMenuItem.Text = "Consultar/Editar Motoristas...";
			this.consultarEditarMotoristasToolStripMenuItem.Click += new System.EventHandler(this.consultarEditarMotoristasToolStripMenuItem_Click);
			// 
			// consultarEditarEstoqueDePeçasToolStripMenuItem
			// 
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Name = "consultarEditarEstoqueDePeçasToolStripMenuItem";
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Text = "Consultar/Editar Estoque de peças...";
			this.consultarEditarEstoqueDePeçasToolStripMenuItem.Click += new System.EventHandler(this.consultarEditarEstoqueDePeçasToolStripMenuItem_Click);
			// 
			// consultarReservasAtivasToolStripMenuItem
			// 
			this.consultarReservasAtivasToolStripMenuItem.Name = "consultarReservasAtivasToolStripMenuItem";
			this.consultarReservasAtivasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarReservasAtivasToolStripMenuItem.Text = "Consultar locações ativas...";
			this.consultarReservasAtivasToolStripMenuItem.Click += new System.EventHandler(this.consultarReservasAtivasToolStripMenuItem_Click);
			// 
			// consultarComprovantesToolStripMenuItem
			// 
			this.consultarComprovantesToolStripMenuItem.Name = "consultarComprovantesToolStripMenuItem";
			this.consultarComprovantesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.consultarComprovantesToolStripMenuItem.Text = "Consultar Comprovantes...";
			this.consultarComprovantesToolStripMenuItem.Click += new System.EventHandler(this.consultarComprovantesToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem2
			// 
			this.relatóriosToolStripMenuItem2.Name = "relatóriosToolStripMenuItem2";
			this.relatóriosToolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
			this.relatóriosToolStripMenuItem2.Text = "Relatórios";
			this.relatóriosToolStripMenuItem2.Click += new System.EventHandler(this.RelatóriosToolStripMenuItem2_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.toolStripSeparator1,
            this.sobreToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
			this.toolStripMenuItem1.Text = "?";
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.sobreToolStripMenuItem.Text = "Sobre...";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// cadastrarNovoCarroToolStripMenuItem
			// 
			this.cadastrarNovoCarroToolStripMenuItem.Name = "cadastrarNovoCarroToolStripMenuItem";
			this.cadastrarNovoCarroToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cadastrarNovoCarroToolStripMenuItem.Text = "Cadastrar novo veículo...";
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 571);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fat Car\'s";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem administraçaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoCarroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoVeículoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem efetuarLogoffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarUsuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarEstoqueDePeçasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem monitorarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monitorarVeículosAtivosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarReservasAtivasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarComprovantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem novaLocaçaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarAlertaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem controleDePátioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controleDePneusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem controleDePreçosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarEditarMotoristasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem despesasDeCarrosToolStripMenuItem;
	}
}

