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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarDespesa));
			this.label27 = new System.Windows.Forms.Label();
			this.comboTipo = new System.Windows.Forms.ComboBox();
			this.button8 = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupCadastrarDespesas = new System.Windows.Forms.GroupBox();
			this.dataDespesa = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoDespesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupCadastrarDespesas.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
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
			// comboTipo
			// 
			this.comboTipo.FormattingEnabled = true;
			this.comboTipo.Location = new System.Drawing.Point(179, 32);
			this.comboTipo.Name = "comboTipo";
			this.comboTipo.Size = new System.Drawing.Size(309, 21);
			this.comboTipo.TabIndex = 3;
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
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(623, 33);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 21);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Adicionar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(18, 74);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(680, 20);
			this.txtDescricao.TabIndex = 7;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(176, 18);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(31, 13);
			this.label25.TabIndex = 12;
			this.label25.Text = "Tipo:";
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
			this.groupBox10.Controls.Add(this.dataGridView1);
			this.groupBox10.Location = new System.Drawing.Point(0, 212);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(788, 226);
			this.groupBox10.TabIndex = 20;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Despesas Registradas:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.tipoDespesaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.despesasBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(782, 207);
			this.dataGridView1.TabIndex = 12;
			// 
			// groupCadastrarDespesas
			// 
			this.groupCadastrarDespesas.Controls.Add(this.dataDespesa);
			this.groupCadastrarDespesas.Controls.Add(this.txtDescricao);
			this.groupCadastrarDespesas.Controls.Add(this.label24);
			this.groupCadastrarDespesas.Controls.Add(this.label27);
			this.groupCadastrarDespesas.Controls.Add(this.comboTipo);
			this.groupCadastrarDespesas.Controls.Add(this.label25);
			this.groupCadastrarDespesas.Controls.Add(this.button8);
			this.groupCadastrarDespesas.Controls.Add(this.label26);
			this.groupCadastrarDespesas.Controls.Add(this.btnSalvar);
			this.groupCadastrarDespesas.Controls.Add(this.txtValor);
			this.groupCadastrarDespesas.Location = new System.Drawing.Point(20, 12);
			this.groupCadastrarDespesas.Name = "groupCadastrarDespesas";
			this.groupCadastrarDespesas.Size = new System.Drawing.Size(710, 100);
			this.groupCadastrarDespesas.TabIndex = 1;
			this.groupCadastrarDespesas.TabStop = false;
			this.groupCadastrarDespesas.Text = "Cadastrar Despesas";
			// 
			// dataDespesa
			// 
			this.dataDespesa.Location = new System.Drawing.Point(18, 32);
			this.dataDespesa.Name = "dataDespesa";
			this.dataDespesa.Size = new System.Drawing.Size(155, 20);
			this.dataDespesa.TabIndex = 21;
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
			// despesasBindingSource
			// 
			this.despesasBindingSource.DataSource = typeof(Forms.Models.Despesas);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataDataGridViewTextBoxColumn
			// 
			this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
			this.dataDataGridViewTextBoxColumn.HeaderText = "Data Vencimento";
			this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
			this.dataDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tipoDespesaDataGridViewTextBoxColumn
			// 
			this.tipoDespesaDataGridViewTextBoxColumn.DataPropertyName = "TipoDespesa";
			this.tipoDespesaDataGridViewTextBoxColumn.HeaderText = "Tipo";
			this.tipoDespesaDataGridViewTextBoxColumn.Name = "tipoDespesaDataGridViewTextBoxColumn";
			this.tipoDespesaDataGridViewTextBoxColumn.ReadOnly = true;
			this.tipoDespesaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// valorDataGridViewTextBoxColumn
			// 
			this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
			this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
			this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
			this.valorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupCadastrarDespesas.ResumeLayout(false);
			this.groupCadastrarDespesas.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ComboBox comboTipo;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupCadastrarDespesas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dataDespesa;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoDespesaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource despesasBindingSource;
	}
}