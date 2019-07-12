namespace Forms.Views.Desktop
{
	partial class FormBuscaLocacao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaLocacao));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblConsultarLocacoes = new System.Windows.Forms.Label();
			this.ComboFiltro = new System.Windows.Forms.ComboBox();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.tableLayoutPanel1.Controls.Add(this.lblConsultarLocacoes, 2, 0);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 85);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// lblConsultarLocacoes
			// 
			this.lblConsultarLocacoes.AutoSize = true;
			this.lblConsultarLocacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblConsultarLocacoes.Location = new System.Drawing.Point(277, 0);
			this.lblConsultarLocacoes.Name = "lblConsultarLocacoes";
			this.lblConsultarLocacoes.Size = new System.Drawing.Size(203, 25);
			this.lblConsultarLocacoes.TabIndex = 2;
			this.lblConsultarLocacoes.Text = "Consultar Locações";
			// 
			// ComboFiltro
			// 
			this.ComboFiltro.FormattingEnabled = true;
			this.ComboFiltro.Items.AddRange(new object[] {
            "Nº OS",
            "Cliente",
            "Placa"});
			this.ComboFiltro.Location = new System.Drawing.Point(70, 48);
			this.ComboFiltro.Name = "ComboFiltro";
			this.ComboFiltro.Size = new System.Drawing.Size(121, 21);
			this.ComboFiltro.TabIndex = 6;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(277, 48);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(180, 20);
			this.txtPesquisa.TabIndex = 4;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(486, 48);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Text = "Pesquisar...";
			this.btnPesquisar.UseVisualStyleBackColor = true;
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
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(110, 116);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(552, 281);
			this.dataGridView1.TabIndex = 12;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "nº OS";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Cliente";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Data Inicio";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Data Final";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Valor";
			this.Column5.Name = "Column5";
			// 
			// FormBuscaLocacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBuscaLocacao";
			this.Text = "FormBuscaLocacao";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblConsultarLocacoes;
		private System.Windows.Forms.ComboBox ComboFiltro;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}