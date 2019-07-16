namespace Forms.Views.Desktop
{
	partial class FormBuscaCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaCliente));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblConsultarClientes = new System.Windows.Forms.Label();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.profissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50443F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05706F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84715F));
			this.tableLayoutPanel1.Controls.Add(this.lblConsultarClientes, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPesquisa, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltro, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 107);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// lblConsultarClientes
			// 
			this.lblConsultarClientes.AutoSize = true;
			this.lblConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblConsultarClientes.Location = new System.Drawing.Point(244, 0);
			this.lblConsultarClientes.Name = "lblConsultarClientes";
			this.lblConsultarClientes.Size = new System.Drawing.Size(188, 25);
			this.lblConsultarClientes.TabIndex = 2;
			this.lblConsultarClientes.Text = "Consultar Clientes";
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF"});
			this.ComboFiltro.Location = new System.Drawing.Point(62, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 6;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(244, 48);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisa.TabIndex = 4;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(438, 48);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Text = "Pesquisar...";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFiltro.Location = new System.Drawing.Point(3, 45);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(44, 20);
			this.lblFiltro.TabIndex = 3;
			this.lblFiltro.Text = "Filtro";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.statusClienteDataGridViewTextBoxColumn,
            this.tipoClienteDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cnpjDataGridViewTextBoxColumn,
            this.profissaoDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.ieDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.telComercialDataGridViewTextBoxColumn,
            this.telResidencialDataGridViewTextBoxColumn,
            this.telCelularDataGridViewTextBoxColumn,
            this.cnhDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clienteBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 107);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(715, 287);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// statusClienteDataGridViewTextBoxColumn
			// 
			this.statusClienteDataGridViewTextBoxColumn.DataPropertyName = "StatusCliente";
			this.statusClienteDataGridViewTextBoxColumn.HeaderText = "Status Cliente";
			this.statusClienteDataGridViewTextBoxColumn.Name = "statusClienteDataGridViewTextBoxColumn";
			this.statusClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tipoClienteDataGridViewTextBoxColumn
			// 
			this.tipoClienteDataGridViewTextBoxColumn.DataPropertyName = "TipoCliente";
			this.tipoClienteDataGridViewTextBoxColumn.HeaderText = "Tipo Cliente";
			this.tipoClienteDataGridViewTextBoxColumn.Name = "tipoClienteDataGridViewTextBoxColumn";
			this.tipoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
			this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Cpf";
			this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// cnpjDataGridViewTextBoxColumn
			// 
			this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
			this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
			this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
			this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// profissaoDataGridViewTextBoxColumn
			// 
			this.profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
			this.profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
			this.profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
			this.profissaoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contatoDataGridViewTextBoxColumn
			// 
			this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
			this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
			this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
			this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Rg";
			this.dataGridViewTextBoxColumn3.HeaderText = "RG";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// ieDataGridViewTextBoxColumn
			// 
			this.ieDataGridViewTextBoxColumn.DataPropertyName = "Ie";
			this.ieDataGridViewTextBoxColumn.HeaderText = "IE";
			this.ieDataGridViewTextBoxColumn.Name = "ieDataGridViewTextBoxColumn";
			this.ieDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nascimentoDataGridViewTextBoxColumn
			// 
			this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
			this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
			this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
			this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telComercialDataGridViewTextBoxColumn
			// 
			this.telComercialDataGridViewTextBoxColumn.DataPropertyName = "TelComercial";
			this.telComercialDataGridViewTextBoxColumn.HeaderText = "Tel. Comercial";
			this.telComercialDataGridViewTextBoxColumn.Name = "telComercialDataGridViewTextBoxColumn";
			this.telComercialDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telResidencialDataGridViewTextBoxColumn
			// 
			this.telResidencialDataGridViewTextBoxColumn.DataPropertyName = "TelResidencial";
			this.telResidencialDataGridViewTextBoxColumn.HeaderText = "Tel. Residencial";
			this.telResidencialDataGridViewTextBoxColumn.Name = "telResidencialDataGridViewTextBoxColumn";
			this.telResidencialDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telCelularDataGridViewTextBoxColumn
			// 
			this.telCelularDataGridViewTextBoxColumn.DataPropertyName = "TelCelular";
			this.telCelularDataGridViewTextBoxColumn.HeaderText = "Tel. Celular";
			this.telCelularDataGridViewTextBoxColumn.Name = "telCelularDataGridViewTextBoxColumn";
			this.telCelularDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cnhDataGridViewTextBoxColumn
			// 
			this.cnhDataGridViewTextBoxColumn.DataPropertyName = "Cnh";
			this.cnhDataGridViewTextBoxColumn.HeaderText = "CNH";
			this.cnhDataGridViewTextBoxColumn.Name = "cnhDataGridViewTextBoxColumn";
			this.cnhDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataSource = typeof(Forms.Models.Cliente);
			// 
			// FormBuscaCliente
			// 
			this.AcceptButton = this.btnPesquisar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 394);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBuscaCliente";
			this.Text = "Buscar Clientes";
			this.Load += new System.EventHandler(this.FormBuscaCliente_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblConsultarClientes;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telComercialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telResidencialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telCelularDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cnhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
	}
}