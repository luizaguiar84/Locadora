namespace Forms.Views.Desktop
{
	partial class FormControlePatio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlePatio));
			this.label2 = new System.Windows.Forms.Label();
			this.groupSaida = new System.Windows.Forms.GroupBox();
			this.comboCombustivel = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.maskedDataSaida = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKmSaida = new System.Windows.Forms.TextBox();
			this.groupRetorno = new System.Windows.Forms.GroupBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.maskedDataRetorno = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblKmRodado = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtkmRetorno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupVeicFora = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupRegistro = new System.Windows.Forms.GroupBox();
			this.btnAddCarro = new System.Windows.Forms.Button();
			this.btnAddMotorista = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupSaida.SuspendLayout();
			this.groupRetorno.SuspendLayout();
			this.groupVeicFora.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupRegistro.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Data:";
			// 
			// groupSaida
			// 
			this.groupSaida.Controls.Add(this.comboCombustivel);
			this.groupSaida.Controls.Add(this.comboBox4);
			this.groupSaida.Controls.Add(this.maskedTextBox2);
			this.groupSaida.Controls.Add(this.label23);
			this.groupSaida.Controls.Add(this.maskedDataSaida);
			this.groupSaida.Controls.Add(this.label10);
			this.groupSaida.Controls.Add(this.label4);
			this.groupSaida.Controls.Add(this.richTextBox1);
			this.groupSaida.Controls.Add(this.label3);
			this.groupSaida.Controls.Add(this.label1);
			this.groupSaida.Controls.Add(this.txtKmSaida);
			this.groupSaida.Controls.Add(this.label2);
			this.groupSaida.Location = new System.Drawing.Point(12, 209);
			this.groupSaida.Name = "groupSaida";
			this.groupSaida.Size = new System.Drawing.Size(361, 235);
			this.groupSaida.TabIndex = 4;
			this.groupSaida.TabStop = false;
			this.groupSaida.Text = "Registro de Saída do pátio";
			// 
			// comboCombustivel
			// 
			this.comboCombustivel.FormattingEnabled = true;
			this.comboCombustivel.Items.AddRange(new object[] {
            "Cheio",
            "3/4",
            "1/2",
            "1/4",
            "Reserva"});
			this.comboCombustivel.Location = new System.Drawing.Point(9, 81);
			this.comboCombustivel.Name = "comboCombustivel";
			this.comboCombustivel.Size = new System.Drawing.Size(121, 21);
			this.comboCombustivel.TabIndex = 40;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(9, 118);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(332, 21);
			this.comboBox4.TabIndex = 20;
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(118, 42);
			this.maskedTextBox2.Mask = "00:00";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(73, 20);
			this.maskedTextBox2.TabIndex = 11;
			this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(6, 66);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(110, 13);
			this.label23.TabIndex = 39;
			this.label23.Text = "Nivel de combustível:";
			// 
			// maskedDataSaida
			// 
			this.maskedDataSaida.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataSaida.Location = new System.Drawing.Point(9, 42);
			this.maskedDataSaida.Mask = "00/00/0000";
			this.maskedDataSaida.Name = "maskedDataSaida";
			this.maskedDataSaida.Size = new System.Drawing.Size(83, 20);
			this.maskedDataSaida.TabIndex = 7;
			this.maskedDataSaida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataSaida.ValidatingType = typeof(System.DateTime);
			this.maskedDataSaida.Leave += new System.EventHandler(this.maskedDataSaida_Leave);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(115, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Hora:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Observações:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 159);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(332, 64);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Liberado por:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(224, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Km do carro:";
			// 
			// txtKmSaida
			// 
			this.txtKmSaida.Location = new System.Drawing.Point(227, 42);
			this.txtKmSaida.MaxLength = 8;
			this.txtKmSaida.Name = "txtKmSaida";
			this.txtKmSaida.Size = new System.Drawing.Size(114, 20);
			this.txtKmSaida.TabIndex = 4;
			this.txtKmSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmSaida_KeyPress);
			// 
			// groupRetorno
			// 
			this.groupRetorno.Controls.Add(this.comboBox6);
			this.groupRetorno.Controls.Add(this.label15);
			this.groupRetorno.Controls.Add(this.comboBox5);
			this.groupRetorno.Controls.Add(this.label9);
			this.groupRetorno.Controls.Add(this.maskedTextBox3);
			this.groupRetorno.Controls.Add(this.maskedDataRetorno);
			this.groupRetorno.Controls.Add(this.label6);
			this.groupRetorno.Controls.Add(this.label11);
			this.groupRetorno.Controls.Add(this.lblKmRodado);
			this.groupRetorno.Controls.Add(this.label8);
			this.groupRetorno.Controls.Add(this.comboBox1);
			this.groupRetorno.Controls.Add(this.label7);
			this.groupRetorno.Controls.Add(this.txtkmRetorno);
			this.groupRetorno.Controls.Add(this.label5);
			this.groupRetorno.Location = new System.Drawing.Point(379, 209);
			this.groupRetorno.Name = "groupRetorno";
			this.groupRetorno.Size = new System.Drawing.Size(341, 235);
			this.groupRetorno.TabIndex = 5;
			this.groupRetorno.TabStop = false;
			this.groupRetorno.Text = "Registro de retorno ao pátio";
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Items.AddRange(new object[] {
            "Cheio",
            "3/4",
            "1/2",
            "1/4",
            "Reserva"});
			this.comboBox6.Location = new System.Drawing.Point(9, 81);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(121, 21);
			this.comboBox6.TabIndex = 40;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 66);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 13);
			this.label15.TabIndex = 39;
			this.label15.Text = "Nivel de combustível:";
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(9, 130);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(323, 21);
			this.comboBox5.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 114);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Recolhido por:";
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Location = new System.Drawing.Point(112, 42);
			this.maskedTextBox3.Mask = "00:00";
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(73, 20);
			this.maskedTextBox3.TabIndex = 18;
			this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
			// 
			// maskedDataRetorno
			// 
			this.maskedDataRetorno.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataRetorno.Location = new System.Drawing.Point(9, 42);
			this.maskedDataRetorno.Mask = "00/00/0000";
			this.maskedDataRetorno.Name = "maskedDataRetorno";
			this.maskedDataRetorno.Size = new System.Drawing.Size(83, 20);
			this.maskedDataRetorno.TabIndex = 16;
			this.maskedDataRetorno.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataRetorno.ValidatingType = typeof(System.DateTime);
			this.maskedDataRetorno.Leave += new System.EventHandler(this.maskedDataRetorno_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(109, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Hora:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "Data:";
			// 
			// lblKmRodado
			// 
			this.lblKmRodado.AutoSize = true;
			this.lblKmRodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKmRodado.ForeColor = System.Drawing.Color.Red;
			this.lblKmRodado.Location = new System.Drawing.Point(168, 204);
			this.lblKmRodado.Name = "lblKmRodado";
			this.lblKmRodado.Size = new System.Drawing.Size(24, 25);
			this.lblKmRodado.TabIndex = 14;
			this.lblKmRodado.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(46, 159);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(238, 25);
			this.label8.TabIndex = 13;
			this.label8.Text = "Quilometragem Rodada";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "SEM INCIDENTES",
            "ACIDENTADO"});
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(211, 42);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(208, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Estado:";
			// 
			// txtkmRetorno
			// 
			this.txtkmRetorno.Location = new System.Drawing.Point(211, 82);
			this.txtkmRetorno.MaxLength = 8;
			this.txtkmRetorno.Name = "txtkmRetorno";
			this.txtkmRetorno.Size = new System.Drawing.Size(121, 20);
			this.txtkmRetorno.TabIndex = 10;
			this.txtkmRetorno.TextChanged += new System.EventHandler(this.txtkmRetorno_TextChanged);
			this.txtkmRetorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkmRetorno_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(208, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Km no retorno:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(610, 450);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupVeicFora
			// 
			this.groupVeicFora.Controls.Add(this.dataGridView1);
			this.groupVeicFora.Location = new System.Drawing.Point(402, 12);
			this.groupVeicFora.Name = "groupVeicFora";
			this.groupVeicFora.Size = new System.Drawing.Size(318, 191);
			this.groupVeicFora.TabIndex = 7;
			this.groupVeicFora.TabStop = false;
			this.groupVeicFora.Text = "Veículos fora do pátio";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dataGridView1.Location = new System.Drawing.Point(6, 20);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(300, 165);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "PLACA";
			this.Column1.Name = "Column1";
			this.Column1.Width = 60;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "DATA SAIDA";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "HORA SAIDA";
			this.Column3.Name = "Column3";
			// 
			// groupRegistro
			// 
			this.groupRegistro.Controls.Add(this.btnAddCarro);
			this.groupRegistro.Controls.Add(this.btnAddMotorista);
			this.groupRegistro.Controls.Add(this.textBox3);
			this.groupRegistro.Controls.Add(this.label14);
			this.groupRegistro.Controls.Add(this.comboBox3);
			this.groupRegistro.Controls.Add(this.label13);
			this.groupRegistro.Controls.Add(this.comboBox2);
			this.groupRegistro.Controls.Add(this.label12);
			this.groupRegistro.Location = new System.Drawing.Point(12, 12);
			this.groupRegistro.Name = "groupRegistro";
			this.groupRegistro.Size = new System.Drawing.Size(361, 159);
			this.groupRegistro.TabIndex = 8;
			this.groupRegistro.TabStop = false;
			this.groupRegistro.Text = "Registro do carro:";
			// 
			// btnAddCarro
			// 
			this.btnAddCarro.Location = new System.Drawing.Point(136, 32);
			this.btnAddCarro.Name = "btnAddCarro";
			this.btnAddCarro.Size = new System.Drawing.Size(17, 21);
			this.btnAddCarro.TabIndex = 19;
			this.btnAddCarro.Text = "+";
			this.btnAddCarro.UseVisualStyleBackColor = true;
			this.btnAddCarro.Click += new System.EventHandler(this.btnAddCarro_Click);
			// 
			// btnAddMotorista
			// 
			this.btnAddMotorista.Location = new System.Drawing.Point(338, 113);
			this.btnAddMotorista.Name = "btnAddMotorista";
			this.btnAddMotorista.Size = new System.Drawing.Size(17, 23);
			this.btnAddMotorista.TabIndex = 18;
			this.btnAddMotorista.Text = "+";
			this.btnAddMotorista.UseVisualStyleBackColor = true;
			this.btnAddMotorista.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(9, 73);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(323, 20);
			this.textBox3.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 57);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Veículo:";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(9, 113);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(323, 21);
			this.comboBox3.TabIndex = 15;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 97);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Motorista:";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(9, 32);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Placa:";
			// 
			// FormControlePatio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 505);
			this.ControlBox = false;
			this.Controls.Add(this.groupRegistro);
			this.Controls.Add(this.groupVeicFora);
			this.Controls.Add(this.groupSaida);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupRetorno);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlePatio";
			this.Text = "Controle de pátio";
			this.Load += new System.EventHandler(this.FormControlePatio_Load);
			this.groupSaida.ResumeLayout(false);
			this.groupSaida.PerformLayout();
			this.groupRetorno.ResumeLayout(false);
			this.groupRetorno.PerformLayout();
			this.groupVeicFora.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupRegistro.ResumeLayout(false);
			this.groupRegistro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupSaida;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKmSaida;
		private System.Windows.Forms.GroupBox groupRetorno;
		private System.Windows.Forms.Label lblKmRodado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtkmRetorno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.MaskedTextBox maskedDataSaida;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.MaskedTextBox maskedDataRetorno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupVeicFora;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.GroupBox groupRegistro;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnAddMotorista;
		private System.Windows.Forms.Button btnAddCarro;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboCombustivel;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.Label label15;
	}
}