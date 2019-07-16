namespace Forms
{
	partial class FormConsultarVeiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarVeiculo));
			this.label1 = new System.Windows.Forms.Label();
			this.lblConsultarVeiculos = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tBCarrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pIM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCarrosBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(190, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 42);
			this.label1.TabIndex = 2;
			// 
			// lblConsultarVeiculos
			// 
			this.lblConsultarVeiculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblConsultarVeiculos.AutoSize = true;
			this.lblConsultarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblConsultarVeiculos.Location = new System.Drawing.Point(257, 0);
			this.lblConsultarVeiculos.Name = "lblConsultarVeiculos";
			this.lblConsultarVeiculos.Size = new System.Drawing.Size(192, 25);
			this.lblConsultarVeiculos.TabIndex = 3;
			this.lblConsultarVeiculos.Text = "Consultar Veiculos";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.tBCarrosBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 113);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(654, 337);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.Visible = false;
			// 
			// tBCarrosBindingSource
			// 
			this.tBCarrosBindingSource.DataMember = "TB_Carros";
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFiltro.Location = new System.Drawing.Point(3, 45);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(44, 20);
			this.lblFiltro.TabIndex = 9;
			this.lblFiltro.Text = "Filtro";
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(257, 48);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisar.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(455, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Pesquisar...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Placa",
            "Chassi"});
			this.ComboFiltro.Location = new System.Drawing.Point(84, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 12;
			this.ComboFiltro.SelectedIndexChanged += new System.EventHandler(this.ComboFiltro_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49481F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83507F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83506F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83506F));
			this.tableLayoutPanel1.Controls.Add(this.lblConsultarVeiculos, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblFiltro, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button1, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.ComboFiltro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPesquisar, 2, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 106);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// FormConsultarVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(654, 450);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormConsultarVeiculo";
			this.Text = "Consultar Veículo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormConsultarVeiculo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBCarrosBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pIM1DataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblConsultarVeiculos;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.BindingSource pIM1DataSetBindingSource;
		private System.Windows.Forms.BindingSource tBCarrosBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCarroDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn chassiDataGridViewTextBoxColumn;
	}
}