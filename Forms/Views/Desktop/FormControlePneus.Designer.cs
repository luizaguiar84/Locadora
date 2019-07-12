namespace Forms.Views.Desktop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlePneus));
			this.lblPlaca = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.maskedDataPneu = new System.Windows.Forms.MaskedTextBox();
			this.lblData = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.comboEstado = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(20, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// maskedDataPneu
			// 
			this.maskedDataPneu.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataPneu.Location = new System.Drawing.Point(216, 25);
			this.maskedDataPneu.Mask = "00/00/0000";
			this.maskedDataPneu.Name = "maskedDataPneu";
			this.maskedDataPneu.Size = new System.Drawing.Size(100, 20);
			this.maskedDataPneu.TabIndex = 4;
			this.maskedDataPneu.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataPneu.ValidatingType = typeof(System.DateTime);
			this.maskedDataPneu.Leave += new System.EventHandler(this.maskedDataPneu_Leave);
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
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(20, 65);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(177, 20);
			this.textBox2.TabIndex = 7;
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
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(216, 65);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(173, 20);
			this.textBox3.TabIndex = 9;
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(20, 155);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(550, 150);
			this.dataGridView1.TabIndex = 12;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "PLACA";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "KM";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "MARCA";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "MODELO";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "ESTADO";
			this.Column5.Name = "Column5";
			// 
			// FormControlePneus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 363);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.comboEstado);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.maskedDataPneu);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblPlaca);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlePneus";
			this.Text = "Controle de Pneus";
			this.Load += new System.EventHandler(this.FormControlePneus_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.MaskedTextBox maskedDataPneu;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.ComboBox comboEstado;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}