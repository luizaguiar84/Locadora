namespace FatCars.Desktop
{
	partial class FormBuscaCarro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaCarro));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.montadoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anoModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chassiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19588F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.80412F));
			this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPesquisar, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltro, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 81);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFiltro.Location = new System.Drawing.Point(3, 20);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(44, 20);
			this.lblFiltro.TabIndex = 9;
			this.lblFiltro.Text = "Filtro";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(447, 23);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 11;
			this.btnPesquisar.Text = "Pesquisar...";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Placa",
            "Chassi"});
			this.ComboFiltro.Location = new System.Drawing.Point(100, 23);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 12;
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(261, 23);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisar.TabIndex = 10;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.Id,
            this.placaDataGridViewTextBoxColumn,
            this.montadoraDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoModeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.chassiDataGridViewTextBoxColumn,
            this.valorDiariaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.veiculoBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(671, 313);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(190, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 42);
			this.label1.TabIndex = 15;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// placaDataGridViewTextBoxColumn
			// 
			this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
			this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
			this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
			this.placaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// montadoraDataGridViewTextBoxColumn
			// 
			this.montadoraDataGridViewTextBoxColumn.DataPropertyName = "Montadora";
			this.montadoraDataGridViewTextBoxColumn.HeaderText = "Montadora";
			this.montadoraDataGridViewTextBoxColumn.Name = "montadoraDataGridViewTextBoxColumn";
			this.montadoraDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// modeloDataGridViewTextBoxColumn
			// 
			this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
			this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
			this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
			this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// anoModeloDataGridViewTextBoxColumn
			// 
			this.anoModeloDataGridViewTextBoxColumn.DataPropertyName = "AnoModelo";
			this.anoModeloDataGridViewTextBoxColumn.HeaderText = "Ano";
			this.anoModeloDataGridViewTextBoxColumn.Name = "anoModeloDataGridViewTextBoxColumn";
			this.anoModeloDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// corDataGridViewTextBoxColumn
			// 
			this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
			this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
			this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
			this.corDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// chassiDataGridViewTextBoxColumn
			// 
			this.chassiDataGridViewTextBoxColumn.DataPropertyName = "Chassi";
			this.chassiDataGridViewTextBoxColumn.HeaderText = "Chassi";
			this.chassiDataGridViewTextBoxColumn.Name = "chassiDataGridViewTextBoxColumn";
			this.chassiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// valorDiariaDataGridViewTextBoxColumn
			// 
			this.valorDiariaDataGridViewTextBoxColumn.DataPropertyName = "ValorDiaria";
			this.valorDiariaDataGridViewTextBoxColumn.HeaderText = "Valor Diária";
			this.valorDiariaDataGridViewTextBoxColumn.Name = "valorDiariaDataGridViewTextBoxColumn";
			this.valorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// veiculoBindingSource
			// 
			this.veiculoBindingSource.DataSource = typeof(Classes.Models.Veiculos);
			// 
			// FormBuscaCarro
			// 
			this.AcceptButton = this.btnPesquisar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 401);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormBuscaCarro";
			this.Text = "Consultar Veículos";
			this.Load += new System.EventHandler(this.FormBuscaCarro_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource veiculoBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn montadoraDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn anoModeloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn chassiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorDiariaDataGridViewTextBoxColumn;
	}
}