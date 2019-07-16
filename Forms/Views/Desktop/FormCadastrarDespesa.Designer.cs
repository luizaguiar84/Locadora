namespace Forms.Views.Desktop
{
	partial class FormCadastrarDespesa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarDespesa));
			this.label27 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.maskedDataDespesa = new System.Windows.Forms.MaskedTextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupCadastrarDespesas = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.groupCadastrarDespesas.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(17, 58);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(58, 13);
			this.label27.TabIndex = 19;
			this.label27.Text = "Descrição:";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(107, 32);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(381, 21);
			this.comboBox3.TabIndex = 3;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(494, 33);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(26, 21);
			this.button8.TabIndex = 4;
			this.button8.Text = "+";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(623, 33);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 21);
			this.button7.TabIndex = 6;
			this.button7.Text = "Adicionar";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(530, 33);
			this.txtValor.MaxLength = 8;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(87, 20);
			this.txtValor.TabIndex = 5;
			this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
			this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
			this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(527, 18);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(34, 13);
			this.label26.TabIndex = 14;
			this.label26.Text = "Valor:";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(18, 74);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(470, 20);
			this.textBox9.TabIndex = 7;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(104, 18);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(31, 13);
			this.label25.TabIndex = 12;
			this.label25.Text = "Tipo:";
			// 
			// maskedDataDespesa
			// 
			this.maskedDataDespesa.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataDespesa.HidePromptOnLeave = true;
			this.maskedDataDespesa.Location = new System.Drawing.Point(18, 34);
			this.maskedDataDespesa.Mask = "00/00/0000";
			this.maskedDataDespesa.Name = "maskedDataDespesa";
			this.maskedDataDespesa.Size = new System.Drawing.Size(83, 20);
			this.maskedDataDespesa.TabIndex = 2;
			this.maskedDataDespesa.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataDespesa.ValidatingType = typeof(System.DateTime);
			this.maskedDataDespesa.Leave += new System.EventHandler(this.maskedDataDespesa_Leave);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(15, 18);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(33, 13);
			this.label24.TabIndex = 10;
			this.label24.Text = "Data:";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.dataGridView4);
			this.groupBox10.Location = new System.Drawing.Point(40, 212);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(680, 189);
			this.groupBox10.TabIndex = 20;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Despesas Registradas:";
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.dataGridView4.Location = new System.Drawing.Point(6, 19);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(652, 150);
			this.dataGridView4.TabIndex = 12;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Vencimento";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Tipo";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Descrição";
			this.Column9.Name = "Column9";
			this.Column9.Width = 300;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Valor";
			this.Column10.Name = "Column10";
			// 
			// groupCadastrarDespesas
			// 
			this.groupCadastrarDespesas.Controls.Add(this.textBox9);
			this.groupCadastrarDespesas.Controls.Add(this.label24);
			this.groupCadastrarDespesas.Controls.Add(this.label27);
			this.groupCadastrarDespesas.Controls.Add(this.maskedDataDespesa);
			this.groupCadastrarDespesas.Controls.Add(this.comboBox3);
			this.groupCadastrarDespesas.Controls.Add(this.label25);
			this.groupCadastrarDespesas.Controls.Add(this.button8);
			this.groupCadastrarDespesas.Controls.Add(this.label26);
			this.groupCadastrarDespesas.Controls.Add(this.button7);
			this.groupCadastrarDespesas.Controls.Add(this.txtValor);
			this.groupCadastrarDespesas.Location = new System.Drawing.Point(20, 12);
			this.groupCadastrarDespesas.Name = "groupCadastrarDespesas";
			this.groupCadastrarDespesas.Size = new System.Drawing.Size(710, 100);
			this.groupCadastrarDespesas.TabIndex = 1;
			this.groupCadastrarDespesas.TabStop = false;
			this.groupCadastrarDespesas.Text = "Cadastrar Despesas";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Location = new System.Drawing.Point(248, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 88);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(273, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(53, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Até:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "De:";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(38, 58);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(227, 20);
			this.dateTimePicker2.TabIndex = 10;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(38, 22);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// FormCadastrarDespesa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupCadastrarDespesas);
			this.Controls.Add(this.groupBox10);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarDespesa";
			this.Text = "Despesas";
			this.Load += new System.EventHandler(this.FormCadastrarDespesa_Load);
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.groupCadastrarDespesas.ResumeLayout(false);
			this.groupCadastrarDespesas.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.MaskedTextBox maskedDataDespesa;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.GroupBox groupCadastrarDespesas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
	}
}