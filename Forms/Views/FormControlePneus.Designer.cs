namespace FatCars.Desktop
{
	partial class FormControlePneus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlePneus));
			this.lblPlaca = new System.Windows.Forms.Label();
			this.comboPlaca = new System.Windows.Forms.ComboBox();
			this.lblData = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.comboEstado = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.dataGridPneus = new System.Windows.Forms.DataGridView();
			this.btnAddPneu = new System.Windows.Forms.Button();
			this.datePneu = new System.Windows.Forms.DateTimePicker();
			this.pneusBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kmInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kmAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPneus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pneusBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(17, 9);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(34, 13);
			this.lblPlaca.TabIndex = 0;
			this.lblPlaca.Text = "Placa";
			// 
			// comboPlaca
			// 
			this.comboPlaca.FormattingEnabled = true;
			this.comboPlaca.Location = new System.Drawing.Point(20, 25);
			this.comboPlaca.Name = "comboPlaca";
			this.comboPlaca.Size = new System.Drawing.Size(121, 21);
			this.comboPlaca.TabIndex = 1;
			this.comboPlaca.SelectedIndexChanged += new System.EventHandler(this.ComboPlaca_SelectedIndexChanged);
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(213, 9);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(30, 13);
			this.lblData.TabIndex = 5;
			this.lblData.Text = "Data";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(20, 65);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(177, 20);
			this.txtMarca.TabIndex = 7;
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(17, 49);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(37, 13);
			this.lblMarca.TabIndex = 6;
			this.lblMarca.Text = "Marca";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(216, 65);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(173, 20);
			this.txtModelo.TabIndex = 9;
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(213, 49);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(42, 13);
			this.lblModelo.TabIndex = 8;
			this.lblModelo.Text = "Modelo";
			// 
			// comboEstado
			// 
			this.comboEstado.FormattingEnabled = true;
			this.comboEstado.Items.AddRange(new object[] {
            "NOVO",
            "SEMI NOVO",
            "1/2 VIDA",
            "DESCARTE"});
			this.comboEstado.Location = new System.Drawing.Point(20, 104);
			this.comboEstado.Name = "comboEstado";
			this.comboEstado.Size = new System.Drawing.Size(177, 21);
			this.comboEstado.TabIndex = 10;
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(17, 88);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(40, 13);
			this.lblEstado.TabIndex = 11;
			this.lblEstado.Text = "Estado";
			// 
			// dataGridPneus
			// 
			this.dataGridPneus.AutoGenerateColumns = false;
			this.dataGridPneus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPneus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.kmInicialDataGridViewTextBoxColumn,
            this.kmAtualDataGridViewTextBoxColumn});
			this.dataGridPneus.DataSource = this.pneusBindingSource;
			this.dataGridPneus.Location = new System.Drawing.Point(20, 155);
			this.dataGridPneus.Name = "dataGridPneus";
			this.dataGridPneus.Size = new System.Drawing.Size(550, 150);
			this.dataGridPneus.TabIndex = 12;
			// 
			// btnAddPneu
			// 
			this.btnAddPneu.Location = new System.Drawing.Point(216, 101);
			this.btnAddPneu.Name = "btnAddPneu";
			this.btnAddPneu.Size = new System.Drawing.Size(75, 23);
			this.btnAddPneu.TabIndex = 13;
			this.btnAddPneu.Text = "Adicionar";
			this.btnAddPneu.UseVisualStyleBackColor = true;
			this.btnAddPneu.Click += new System.EventHandler(this.BtnAddPneu_Click);
			// 
			// datePneu
			// 
			this.datePneu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePneu.Location = new System.Drawing.Point(216, 26);
			this.datePneu.Name = "datePneu";
			this.datePneu.Size = new System.Drawing.Size(96, 20);
			this.datePneu.TabIndex = 14;
			// 
			// pneusBindingSource
			// 
			this.pneusBindingSource.DataSource = typeof(Classes.Models.Pneus);
			// 
			// marcaDataGridViewTextBoxColumn
			// 
			this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
			this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
			this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
			// 
			// modeloDataGridViewTextBoxColumn
			// 
			this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
			this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
			this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
			// 
			// estadoDataGridViewTextBoxColumn
			// 
			this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
			this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
			this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
			// 
			// kmInicialDataGridViewTextBoxColumn
			// 
			this.kmInicialDataGridViewTextBoxColumn.DataPropertyName = "KmInicial";
			this.kmInicialDataGridViewTextBoxColumn.HeaderText = "KmInicial";
			this.kmInicialDataGridViewTextBoxColumn.Name = "kmInicialDataGridViewTextBoxColumn";
			// 
			// kmAtualDataGridViewTextBoxColumn
			// 
			this.kmAtualDataGridViewTextBoxColumn.DataPropertyName = "KmAtual";
			this.kmAtualDataGridViewTextBoxColumn.HeaderText = "KmAtual";
			this.kmAtualDataGridViewTextBoxColumn.Name = "kmAtualDataGridViewTextBoxColumn";
			// 
			// FormControlePneus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 363);
			this.ControlBox = false;
			this.Controls.Add(this.datePneu);
			this.Controls.Add(this.btnAddPneu);
			this.Controls.Add(this.dataGridPneus);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.comboEstado);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.comboPlaca);
			this.Controls.Add(this.lblPlaca);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlePneus";
			this.Text = "Controle de Pneus";
			this.Load += new System.EventHandler(this.FormControlePneus_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridPneus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pneusBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.ComboBox comboPlaca;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.ComboBox comboEstado;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.DataGridView dataGridPneus;
		private System.Windows.Forms.Button btnAddPneu;
		private System.Windows.Forms.DateTimePicker datePneu;
		private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kmInicialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kmAtualDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource pneusBindingSource;
	}
}