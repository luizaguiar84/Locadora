namespace Forms.Views.Desktop
{
	partial class FormBuscaFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaFuncionario));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.admissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tituloEleitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.demissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblConsultarFuncionarios = new System.Windows.Forms.Label();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telResidencialDataGridViewTextBoxColumn,
            this.telCelularDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.admissaoDataGridViewTextBoxColumn,
            this.ctpsDataGridViewTextBoxColumn,
            this.pisDataGridViewTextBoxColumn,
            this.tituloEleitorDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.demissaoDataGridViewTextBoxColumn,
            this.cnhDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.funcionariosBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 107);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(722, 343);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			// 
			// cpfDataGridViewTextBoxColumn
			// 
			this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
			this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
			this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
			// 
			// rgDataGridViewTextBoxColumn
			// 
			this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
			this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
			this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// telResidencialDataGridViewTextBoxColumn
			// 
			this.telResidencialDataGridViewTextBoxColumn.DataPropertyName = "TelResidencial";
			this.telResidencialDataGridViewTextBoxColumn.HeaderText = "TelResidencial";
			this.telResidencialDataGridViewTextBoxColumn.Name = "telResidencialDataGridViewTextBoxColumn";
			// 
			// telCelularDataGridViewTextBoxColumn
			// 
			this.telCelularDataGridViewTextBoxColumn.DataPropertyName = "TelCelular";
			this.telCelularDataGridViewTextBoxColumn.HeaderText = "TelCelular";
			this.telCelularDataGridViewTextBoxColumn.Name = "telCelularDataGridViewTextBoxColumn";
			// 
			// salarioDataGridViewTextBoxColumn
			// 
			this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
			this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
			this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
			// 
			// admissaoDataGridViewTextBoxColumn
			// 
			this.admissaoDataGridViewTextBoxColumn.DataPropertyName = "Admissao";
			this.admissaoDataGridViewTextBoxColumn.HeaderText = "Admissao";
			this.admissaoDataGridViewTextBoxColumn.Name = "admissaoDataGridViewTextBoxColumn";
			// 
			// ctpsDataGridViewTextBoxColumn
			// 
			this.ctpsDataGridViewTextBoxColumn.DataPropertyName = "Ctps";
			this.ctpsDataGridViewTextBoxColumn.HeaderText = "Ctps";
			this.ctpsDataGridViewTextBoxColumn.Name = "ctpsDataGridViewTextBoxColumn";
			// 
			// pisDataGridViewTextBoxColumn
			// 
			this.pisDataGridViewTextBoxColumn.DataPropertyName = "Pis";
			this.pisDataGridViewTextBoxColumn.HeaderText = "Pis";
			this.pisDataGridViewTextBoxColumn.Name = "pisDataGridViewTextBoxColumn";
			// 
			// tituloEleitorDataGridViewTextBoxColumn
			// 
			this.tituloEleitorDataGridViewTextBoxColumn.DataPropertyName = "TituloEleitor";
			this.tituloEleitorDataGridViewTextBoxColumn.HeaderText = "TituloEleitor";
			this.tituloEleitorDataGridViewTextBoxColumn.Name = "tituloEleitorDataGridViewTextBoxColumn";
			// 
			// nascimentoDataGridViewTextBoxColumn
			// 
			this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
			this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
			this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
			// 
			// demissaoDataGridViewTextBoxColumn
			// 
			this.demissaoDataGridViewTextBoxColumn.DataPropertyName = "Demissao";
			this.demissaoDataGridViewTextBoxColumn.HeaderText = "Demissao";
			this.demissaoDataGridViewTextBoxColumn.Name = "demissaoDataGridViewTextBoxColumn";
			// 
			// cnhDataGridViewTextBoxColumn
			// 
			this.cnhDataGridViewTextBoxColumn.DataPropertyName = "Cnh";
			this.cnhDataGridViewTextBoxColumn.HeaderText = "Cnh";
			this.cnhDataGridViewTextBoxColumn.Name = "cnhDataGridViewTextBoxColumn";
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			// 
			// funcionariosBindingSource
			// 
			this.funcionariosBindingSource.DataSource = typeof(Forms.Models.Funcionarios);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50443F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.05706F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84715F));
			this.tableLayoutPanel1.Controls.Add(this.lblConsultarFuncionarios, 2, 0);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 107);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// lblConsultarFuncionarios
			// 
			this.lblConsultarFuncionarios.AutoSize = true;
			this.lblConsultarFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblConsultarFuncionarios.Location = new System.Drawing.Point(226, 0);
			this.lblConsultarFuncionarios.Name = "lblConsultarFuncionarios";
			this.lblConsultarFuncionarios.Size = new System.Drawing.Size(234, 25);
			this.lblConsultarFuncionarios.TabIndex = 2;
			this.lblConsultarFuncionarios.Text = "Consultar Funcionários";
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF",
            "Nº Registro"});
			this.ComboFiltro.Location = new System.Drawing.Point(58, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 6;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(226, 48);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisa.TabIndex = 4;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(466, 48);
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
			// FormBuscaFuncionario
			// 
			this.AcceptButton = this.btnPesquisar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBuscaFuncionario";
			this.Text = "FormBuscaFuncionario";
			this.Load += new System.EventHandler(this.FormBuscaFuncionario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblConsultarFuncionarios;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.BindingSource funcionariosBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telResidencialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telCelularDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn admissaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ctpsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pisDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tituloEleitorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn demissaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cnhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
	}
}