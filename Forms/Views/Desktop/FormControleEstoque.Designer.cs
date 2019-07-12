namespace Forms.Views.Desktop
{
	partial class FormControleEstoque
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleEstoque));
			this.TabCotroleEstoque = new System.Windows.Forms.TabControl();
			this.tabConsultaEstoque = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboPesquisa = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tabCadEntradas = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tabCadSaidas = new System.Windows.Forms.TabPage();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TabCotroleEstoque.SuspendLayout();
			this.tabConsultaEstoque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabCadEntradas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabCadSaidas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.SuspendLayout();
			// 
			// TabCotroleEstoque
			// 
			this.TabCotroleEstoque.Controls.Add(this.tabConsultaEstoque);
			this.TabCotroleEstoque.Controls.Add(this.tabCadEntradas);
			this.TabCotroleEstoque.Controls.Add(this.tabCadSaidas);
			this.TabCotroleEstoque.Location = new System.Drawing.Point(12, 12);
			this.TabCotroleEstoque.Name = "TabCotroleEstoque";
			this.TabCotroleEstoque.SelectedIndex = 0;
			this.TabCotroleEstoque.Size = new System.Drawing.Size(669, 495);
			this.TabCotroleEstoque.TabIndex = 30;
			// 
			// tabConsultaEstoque
			// 
			this.tabConsultaEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabConsultaEstoque.Controls.Add(this.dataGridView3);
			this.tabConsultaEstoque.Controls.Add(this.comboPesquisa);
			this.tabConsultaEstoque.Controls.Add(this.label14);
			this.tabConsultaEstoque.Controls.Add(this.btnBuscar);
			this.tabConsultaEstoque.Controls.Add(this.textBox9);
			this.tabConsultaEstoque.Controls.Add(this.label13);
			this.tabConsultaEstoque.Location = new System.Drawing.Point(4, 22);
			this.tabConsultaEstoque.Name = "tabConsultaEstoque";
			this.tabConsultaEstoque.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaEstoque.Size = new System.Drawing.Size(661, 469);
			this.tabConsultaEstoque.TabIndex = 2;
			this.tabConsultaEstoque.Text = "Consulta de estoque";
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView3.Location = new System.Drawing.Point(32, 86);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(551, 338);
			this.dataGridView3.TabIndex = 5;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Código";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Peça";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Descrição";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Valor";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Data adição";
			this.Column5.Name = "Column5";
			// 
			// comboPesquisa
			// 
			this.comboPesquisa.FormattingEnabled = true;
			this.comboPesquisa.Items.AddRange(new object[] {
            "Peça",
            "Código"});
			this.comboPesquisa.Location = new System.Drawing.Point(84, 37);
			this.comboPesquisa.Name = "comboPesquisa";
			this.comboPesquisa.Size = new System.Drawing.Size(137, 21);
			this.comboPesquisa.TabIndex = 4;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(233, 21);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 13);
			this.label14.TabIndex = 3;
			this.label14.Text = "Pesquisa:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(421, 34);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar...";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(236, 37);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(167, 20);
			this.textBox9.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(81, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Filtro:";
			// 
			// tabCadEntradas
			// 
			this.tabCadEntradas.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabCadEntradas.Controls.Add(this.dataGridView1);
			this.tabCadEntradas.Controls.Add(this.textBox5);
			this.tabCadEntradas.Controls.Add(this.label1);
			this.tabCadEntradas.Controls.Add(this.label2);
			this.tabCadEntradas.Controls.Add(this.maskedTextBox1);
			this.tabCadEntradas.Controls.Add(this.richTextBox1);
			this.tabCadEntradas.Controls.Add(this.label3);
			this.tabCadEntradas.Controls.Add(this.textBox6);
			this.tabCadEntradas.Controls.Add(this.label10);
			this.tabCadEntradas.Controls.Add(this.textBox7);
			this.tabCadEntradas.Controls.Add(this.button2);
			this.tabCadEntradas.Controls.Add(this.label11);
			this.tabCadEntradas.Controls.Add(this.textBox8);
			this.tabCadEntradas.Controls.Add(this.label12);
			this.tabCadEntradas.Location = new System.Drawing.Point(4, 22);
			this.tabCadEntradas.Name = "tabCadEntradas";
			this.tabCadEntradas.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadEntradas.Size = new System.Drawing.Size(661, 469);
			this.tabCadEntradas.TabIndex = 0;
			this.tabCadEntradas.Text = "Cadastro de entradas";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView1.Location = new System.Drawing.Point(54, 229);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(547, 181);
			this.dataGridView1.TabIndex = 69;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Código";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Peça";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Data adição";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(83, 101);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(465, 20);
			this.textBox5.TabIndex = 68;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 67;
			this.label1.Text = "Incluído por:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 66;
			this.label2.Text = "Data da entrada:";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(83, 19);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 65;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(83, 155);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(476, 68);
			this.richTextBox1.TabIndex = 63;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 62;
			this.label3.Text = "Observações:";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(471, 58);
			this.textBox6.MaxLength = 4;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(77, 20);
			this.textBox6.TabIndex = 61;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(471, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 13);
			this.label10.TabIndex = 60;
			this.label10.Text = "Valor Unitário";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(404, 58);
			this.textBox7.MaxLength = 4;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(61, 20);
			this.textBox7.TabIndex = 58;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(270, 416);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 40);
			this.button2.TabIndex = 59;
			this.button2.Text = "Salvar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(403, 42);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 13);
			this.label11.TabIndex = 57;
			this.label11.Text = "Quantidade";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(83, 58);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(315, 20);
			this.textBox8.TabIndex = 56;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(80, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 13);
			this.label12.TabIndex = 55;
			this.label12.Text = "Nome da peça";
			// 
			// tabCadSaidas
			// 
			this.tabCadSaidas.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabCadSaidas.Controls.Add(this.dataGridView4);
			this.tabCadSaidas.Controls.Add(this.textBox4);
			this.tabCadSaidas.Controls.Add(this.label9);
			this.tabCadSaidas.Controls.Add(this.label4);
			this.tabCadSaidas.Controls.Add(this.maskedTextBox2);
			this.tabCadSaidas.Controls.Add(this.richTextBox2);
			this.tabCadSaidas.Controls.Add(this.label5);
			this.tabCadSaidas.Controls.Add(this.textBox1);
			this.tabCadSaidas.Controls.Add(this.label6);
			this.tabCadSaidas.Controls.Add(this.textBox2);
			this.tabCadSaidas.Controls.Add(this.button1);
			this.tabCadSaidas.Controls.Add(this.label7);
			this.tabCadSaidas.Controls.Add(this.textBox3);
			this.tabCadSaidas.Controls.Add(this.label8);
			this.tabCadSaidas.Location = new System.Drawing.Point(4, 22);
			this.tabCadSaidas.Name = "tabCadSaidas";
			this.tabCadSaidas.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadSaidas.Size = new System.Drawing.Size(661, 469);
			this.tabCadSaidas.TabIndex = 1;
			this.tabCadSaidas.Text = "Cadastro de saídas";
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
			this.dataGridView4.Location = new System.Drawing.Point(56, 229);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(547, 181);
			this.dataGridView4.TabIndex = 55;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "Código";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "Peça";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Descrição";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "Valor";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "Data adição";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(84, 101);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(465, 20);
			this.textBox4.TabIndex = 54;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(84, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 13);
			this.label9.TabIndex = 53;
			this.label9.Text = "Retirado por:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(81, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 52;
			this.label4.Text = "Data da saída:";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(84, 19);
			this.maskedTextBox2.Mask = "00/00/0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox2.TabIndex = 51;
			this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(84, 155);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(476, 68);
			this.richTextBox2.TabIndex = 49;
			this.richTextBox2.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(81, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 48;
			this.label5.Text = "Observações:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(472, 58);
			this.textBox1.MaxLength = 4;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 20);
			this.textBox1.TabIndex = 47;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(472, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 46;
			this.label6.Text = "Valor Unitário";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(405, 58);
			this.textBox2.MaxLength = 4;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(61, 20);
			this.textBox2.TabIndex = 44;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(271, 416);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 40);
			this.button1.TabIndex = 45;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(404, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Quantidade";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(84, 58);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(315, 20);
			this.textBox3.TabIndex = 42;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(81, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "Nome da peça";
			// 
			// FormControleEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 515);
			this.ControlBox = false;
			this.Controls.Add(this.TabCotroleEstoque);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControleEstoque";
			this.Text = "Controle de estoque";
			this.Load += new System.EventHandler(this.FormControleEstoque_Load);
			this.TabCotroleEstoque.ResumeLayout(false);
			this.tabConsultaEstoque.ResumeLayout(false);
			this.tabConsultaEstoque.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabCadEntradas.ResumeLayout(false);
			this.tabCadEntradas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabCadSaidas.ResumeLayout(false);
			this.tabCadSaidas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabCadEntradas;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabPage tabCadSaidas;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabConsultaEstoque;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboPesquisa;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		public System.Windows.Forms.TabControl TabCotroleEstoque;
	}
}