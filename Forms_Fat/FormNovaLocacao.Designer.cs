namespace Dll_Forms_Fat
{
	partial class FormNovaLocacao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaLocacao));
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimeDevolucao = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAddLocacao = new System.Windows.Forms.Button();
			this.lblHoraDevolucao = new System.Windows.Forms.Label();
			this.checkSegRoubo = new System.Windows.Forms.CheckBox();
			this.groupSeguro = new System.Windows.Forms.GroupBox();
			this.lblValorSegTerceiros = new System.Windows.Forms.Label();
			this.lblValorSegRoubo = new System.Windows.Forms.Label();
			this.checkSegTerceiros = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPagoRetirada = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblValorRestante = new System.Windows.Forms.Label();
			this.lblValorDiaria = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblValorPagoRetirada = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.lblDias = new System.Windows.Forms.Label();
			this.lblValorSeguro = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.comboCarro = new System.Windows.Forms.ComboBox();
			this.comboCliente = new System.Windows.Forms.ComboBox();
			this.timeDevolucao = new System.Windows.Forms.DateTimePicker();
			this.groupSeguro.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cliente";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cadastrar...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(322, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Cadastrar...";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Carro";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Data da devoluçao:";
			// 
			// dateTimeDevolucao
			// 
			this.dateTimeDevolucao.Location = new System.Drawing.Point(17, 154);
			this.dateTimeDevolucao.Name = "dateTimeDevolucao";
			this.dateTimeDevolucao.Size = new System.Drawing.Size(231, 20);
			this.dateTimeDevolucao.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "(=) Valor Restante:";
			// 
			// btnAddLocacao
			// 
			this.btnAddLocacao.Location = new System.Drawing.Point(296, 388);
			this.btnAddLocacao.Name = "btnAddLocacao";
			this.btnAddLocacao.Size = new System.Drawing.Size(133, 44);
			this.btnAddLocacao.TabIndex = 17;
			this.btnAddLocacao.Text = "Concluir locação";
			this.btnAddLocacao.UseVisualStyleBackColor = true;
			this.btnAddLocacao.Click += new System.EventHandler(this.Button5_Click);
			// 
			// lblHoraDevolucao
			// 
			this.lblHoraDevolucao.AutoSize = true;
			this.lblHoraDevolucao.Location = new System.Drawing.Point(262, 138);
			this.lblHoraDevolucao.Name = "lblHoraDevolucao";
			this.lblHoraDevolucao.Size = new System.Drawing.Size(101, 13);
			this.lblHoraDevolucao.TabIndex = 19;
			this.lblHoraDevolucao.Text = "Hora da devolução:";
			// 
			// checkSegRoubo
			// 
			this.checkSegRoubo.AutoSize = true;
			this.checkSegRoubo.Location = new System.Drawing.Point(25, 19);
			this.checkSegRoubo.Name = "checkSegRoubo";
			this.checkSegRoubo.Size = new System.Drawing.Size(164, 17);
			this.checkSegRoubo.TabIndex = 22;
			this.checkSegRoubo.Text = "Seguro contra roubo e batida";
			this.checkSegRoubo.UseVisualStyleBackColor = true;
			this.checkSegRoubo.CheckedChanged += new System.EventHandler(this.CheckSegRoubo_CheckedChanged);
			// 
			// groupSeguro
			// 
			this.groupSeguro.Controls.Add(this.lblValorSegTerceiros);
			this.groupSeguro.Controls.Add(this.lblValorSegRoubo);
			this.groupSeguro.Controls.Add(this.checkSegTerceiros);
			this.groupSeguro.Controls.Add(this.checkSegRoubo);
			this.groupSeguro.Location = new System.Drawing.Point(17, 192);
			this.groupSeguro.Name = "groupSeguro";
			this.groupSeguro.Size = new System.Drawing.Size(380, 70);
			this.groupSeguro.TabIndex = 23;
			this.groupSeguro.TabStop = false;
			this.groupSeguro.Text = "Seguros";
			// 
			// lblValorSegTerceiros
			// 
			this.lblValorSegTerceiros.AutoSize = true;
			this.lblValorSegTerceiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorSegTerceiros.Location = new System.Drawing.Point(234, 39);
			this.lblValorSegTerceiros.Name = "lblValorSegTerceiros";
			this.lblValorSegTerceiros.Size = new System.Drawing.Size(10, 12);
			this.lblValorSegTerceiros.TabIndex = 25;
			this.lblValorSegTerceiros.Text = "0";
			// 
			// lblValorSegRoubo
			// 
			this.lblValorSegRoubo.AutoSize = true;
			this.lblValorSegRoubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorSegRoubo.Location = new System.Drawing.Point(42, 39);
			this.lblValorSegRoubo.Name = "lblValorSegRoubo";
			this.lblValorSegRoubo.Size = new System.Drawing.Size(10, 12);
			this.lblValorSegRoubo.TabIndex = 24;
			this.lblValorSegRoubo.Text = "0";
			// 
			// checkSegTerceiros
			// 
			this.checkSegTerceiros.AutoSize = true;
			this.checkSegTerceiros.Location = new System.Drawing.Point(210, 19);
			this.checkSegTerceiros.Name = "checkSegTerceiros";
			this.checkSegTerceiros.Size = new System.Drawing.Size(136, 17);
			this.checkSegTerceiros.TabIndex = 23;
			this.checkSegTerceiros.Text = "Seguro contra terceiros";
			this.checkSegTerceiros.UseVisualStyleBackColor = true;
			this.checkSegTerceiros.CheckedChanged += new System.EventHandler(this.CheckSegTerceiros_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(145, 265);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Valor pago antecipado:";
			// 
			// txtPagoRetirada
			// 
			this.txtPagoRetirada.Location = new System.Drawing.Point(148, 281);
			this.txtPagoRetirada.Name = "txtPagoRetirada";
			this.txtPagoRetirada.Size = new System.Drawing.Size(100, 20);
			this.txtPagoRetirada.TabIndex = 26;
			this.txtPagoRetirada.TextChanged += new System.EventHandler(this.TxtPagoRetirada_TextChanged);
			this.txtPagoRetirada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagoRetirada_KeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblValorRestante);
			this.groupBox2.Controls.Add(this.lblValorDiaria);
			this.groupBox2.Controls.Add(this.lblSubTotal);
			this.groupBox2.Controls.Add(this.lblValorPagoRetirada);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.lblDias);
			this.groupBox2.Controls.Add(this.lblValorSeguro);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(446, 17);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(247, 307);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Resumo";
			// 
			// lblValorRestante
			// 
			this.lblValorRestante.AutoSize = true;
			this.lblValorRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorRestante.ForeColor = System.Drawing.Color.Red;
			this.lblValorRestante.Location = new System.Drawing.Point(156, 255);
			this.lblValorRestante.Name = "lblValorRestante";
			this.lblValorRestante.Size = new System.Drawing.Size(45, 24);
			this.lblValorRestante.TabIndex = 48;
			this.lblValorRestante.Text = "0,00";
			// 
			// lblValorDiaria
			// 
			this.lblValorDiaria.AutoSize = true;
			this.lblValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorDiaria.ForeColor = System.Drawing.Color.Red;
			this.lblValorDiaria.Location = new System.Drawing.Point(156, 29);
			this.lblValorDiaria.Name = "lblValorDiaria";
			this.lblValorDiaria.Size = new System.Drawing.Size(45, 24);
			this.lblValorDiaria.TabIndex = 47;
			this.lblValorDiaria.Text = "0,00";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTotal.ForeColor = System.Drawing.Color.Red;
			this.lblSubTotal.Location = new System.Drawing.Point(156, 120);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(45, 24);
			this.lblSubTotal.TabIndex = 46;
			this.lblSubTotal.Text = "0,00";
			// 
			// lblValorPagoRetirada
			// 
			this.lblValorPagoRetirada.AutoSize = true;
			this.lblValorPagoRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorPagoRetirada.ForeColor = System.Drawing.Color.Red;
			this.lblValorPagoRetirada.Location = new System.Drawing.Point(156, 195);
			this.lblValorPagoRetirada.Name = "lblValorPagoRetirada";
			this.lblValorPagoRetirada.Size = new System.Drawing.Size(45, 24);
			this.lblValorPagoRetirada.TabIndex = 45;
			this.lblValorPagoRetirada.Text = "0,00";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(142, 225);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(103, 13);
			this.label21.TabIndex = 39;
			this.label21.Text = "________________";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(142, 144);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(103, 13);
			this.label19.TabIndex = 38;
			this.label19.Text = "________________";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(142, 94);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(103, 13);
			this.label20.TabIndex = 37;
			this.label20.Text = "________________";
			// 
			// lblDias
			// 
			this.lblDias.AutoSize = true;
			this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDias.ForeColor = System.Drawing.Color.Red;
			this.lblDias.Location = new System.Drawing.Point(156, 62);
			this.lblDias.Name = "lblDias";
			this.lblDias.Size = new System.Drawing.Size(20, 24);
			this.lblDias.TabIndex = 34;
			this.lblDias.Text = "0";
			// 
			// lblValorSeguro
			// 
			this.lblValorSeguro.AutoSize = true;
			this.lblValorSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorSeguro.ForeColor = System.Drawing.Color.Red;
			this.lblValorSeguro.Location = new System.Drawing.Point(156, 164);
			this.lblValorSeguro.Name = "lblValorSeguro";
			this.lblValorSeguro.Size = new System.Drawing.Size(45, 24);
			this.lblValorSeguro.TabIndex = 32;
			this.lblValorSeguro.Text = "0,00";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(23, 203);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(126, 13);
			this.label13.TabIndex = 28;
			this.label13.Text = "(-) Valor pago na retirada:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(23, 175);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 13);
			this.label12.TabIndex = 30;
			this.label12.Text = "(+) Seguros:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(23, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 13);
			this.label11.TabIndex = 29;
			this.label11.Text = "(=) SubTotal:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(23, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 13);
			this.label10.TabIndex = 28;
			this.label10.Text = "(x) Dias alugados:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 13);
			this.label9.TabIndex = 28;
			this.label9.Text = "(=) Valor Diária:";
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(17, 281);
			this.txtKm.Name = "txtKm";
			this.txtKm.ReadOnly = true;
			this.txtKm.Size = new System.Drawing.Size(100, 20);
			this.txtKm.TabIndex = 32;
			this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(14, 265);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(67, 13);
			this.label18.TabIndex = 31;
			this.label18.Text = "Km do carro:";
			// 
			// comboCarro
			// 
			this.comboCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCarro.FormattingEnabled = true;
			this.comboCarro.Location = new System.Drawing.Point(17, 80);
			this.comboCarro.Name = "comboCarro";
			this.comboCarro.Size = new System.Drawing.Size(299, 21);
			this.comboCarro.TabIndex = 40;
			// 
			// comboCliente
			// 
			this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCliente.FormattingEnabled = true;
			this.comboCliente.Location = new System.Drawing.Point(17, 30);
			this.comboCliente.Name = "comboCliente";
			this.comboCliente.Size = new System.Drawing.Size(299, 21);
			this.comboCliente.TabIndex = 41;
			// 
			// timeDevolucao
			// 
			this.timeDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.timeDevolucao.Location = new System.Drawing.Point(259, 155);
			this.timeDevolucao.Name = "timeDevolucao";
			this.timeDevolucao.ShowUpDown = true;
			this.timeDevolucao.Size = new System.Drawing.Size(89, 20);
			this.timeDevolucao.TabIndex = 43;
			// 
			// FormNovaLocacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 444);
			this.ControlBox = false;
			this.Controls.Add(this.timeDevolucao);
			this.Controls.Add(this.comboCliente);
			this.Controls.Add(this.comboCarro);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.txtPagoRetirada);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupSeguro);
			this.Controls.Add(this.lblHoraDevolucao);
			this.Controls.Add(this.btnAddLocacao);
			this.Controls.Add(this.dateTimeDevolucao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormNovaLocacao";
			this.Text = "Nova Locação";
			this.Load += new System.EventHandler(this.FormNovaLocacao_Load);
			this.Enter += new System.EventHandler(this.FormNovaLocacao_Load);
			this.groupSeguro.ResumeLayout(false);
			this.groupSeguro.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimeDevolucao;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddLocacao;
		private System.Windows.Forms.Label lblHoraDevolucao;
		private System.Windows.Forms.CheckBox checkSegRoubo;
		private System.Windows.Forms.GroupBox groupSeguro;
		private System.Windows.Forms.CheckBox checkSegTerceiros;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPagoRetirada;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lblDias;
		private System.Windows.Forms.Label lblValorSeguro;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblValorRestante;
		private System.Windows.Forms.Label lblValorDiaria;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label lblValorPagoRetirada;
		private System.Windows.Forms.Label lblValorSegTerceiros;
		private System.Windows.Forms.Label lblValorSegRoubo;
		private System.Windows.Forms.TextBox txtKm;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox comboCarro;
		private System.Windows.Forms.ComboBox comboCliente;
		private System.Windows.Forms.DateTimePicker timeDevolucao;
	}
}