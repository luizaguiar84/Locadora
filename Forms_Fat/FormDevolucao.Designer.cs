namespace Dll_Forms_Fat
{
	partial class FormDevolucao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevolucao));
			this.txtNrOS = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.lblOs = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRetirada = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboSinistros = new System.Windows.Forms.ComboBox();
			this.btnAdicionarSinistro = new System.Windows.Forms.Button();
			this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblValorRestante = new System.Windows.Forms.Label();
			this.lblValorDiaria = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblAdiantamento = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.lblDias = new System.Windows.Forms.Label();
			this.lblValorSeguro = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtKmDevolucao = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.comboCombustivel = new System.Windows.Forms.ComboBox();
			this.lblRecebidoPor = new System.Windows.Forms.Label();
			this.comboRecebido = new System.Windows.Forms.ComboBox();
			this.btnFinalizar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNrOS
			// 
			this.txtNrOS.Location = new System.Drawing.Point(103, 25);
			this.txtNrOS.Name = "txtNrOS";
			this.txtNrOS.Size = new System.Drawing.Size(100, 20);
			this.txtNrOS.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(281, 25);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(66, 20);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lblOs
			// 
			this.lblOs.AutoSize = true;
			this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.lblOs.Location = new System.Drawing.Point(100, 9);
			this.lblOs.Name = "lblOs";
			this.lblOs.Size = new System.Drawing.Size(92, 13);
			this.lblOs.TabIndex = 3;
			this.lblOs.Text = "Digite o nº da OS:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(209, 25);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(66, 20);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Location = new System.Drawing.Point(31, 71);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.ReadOnly = true;
			this.txtNomeCliente.Size = new System.Drawing.Size(400, 20);
			this.txtNomeCliente.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(28, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(28, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Data da retirada:";
			// 
			// txtRetirada
			// 
			this.txtRetirada.Location = new System.Drawing.Point(31, 110);
			this.txtRetirada.Name = "txtRetirada";
			this.txtRetirada.ReadOnly = true;
			this.txtRetirada.Size = new System.Drawing.Size(163, 20);
			this.txtRetirada.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.Location = new System.Drawing.Point(228, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Data da devolução:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.Location = new System.Drawing.Point(28, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Sinistros:";
			// 
			// comboSinistros
			// 
			this.comboSinistros.FormattingEnabled = true;
			this.comboSinistros.Location = new System.Drawing.Point(31, 150);
			this.comboSinistros.Name = "comboSinistros";
			this.comboSinistros.Size = new System.Drawing.Size(373, 21);
			this.comboSinistros.TabIndex = 17;
			// 
			// btnAdicionarSinistro
			// 
			this.btnAdicionarSinistro.Location = new System.Drawing.Point(410, 149);
			this.btnAdicionarSinistro.Name = "btnAdicionarSinistro";
			this.btnAdicionarSinistro.Size = new System.Drawing.Size(21, 21);
			this.btnAdicionarSinistro.TabIndex = 18;
			this.btnAdicionarSinistro.Text = "+";
			this.btnAdicionarSinistro.UseVisualStyleBackColor = true;
			this.btnAdicionarSinistro.Click += new System.EventHandler(this.button3_Click);
			// 
			// dateDevolucao
			// 
			this.dateDevolucao.Location = new System.Drawing.Point(200, 110);
			this.dateDevolucao.Name = "dateDevolucao";
			this.dateDevolucao.Size = new System.Drawing.Size(231, 20);
			this.dateDevolucao.TabIndex = 19;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblValorRestante);
			this.groupBox2.Controls.Add(this.lblValorDiaria);
			this.groupBox2.Controls.Add(this.lblSubTotal);
			this.groupBox2.Controls.Add(this.lblAdiantamento);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.lblDias);
			this.groupBox2.Controls.Add(this.lblValorSeguro);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Location = new System.Drawing.Point(447, 9);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(247, 333);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Resumo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(141, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 24);
			this.label6.TabIndex = 50;
			this.label6.Text = "0,00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 49;
			this.label3.Text = "(+) Adicionais:";
			// 
			// lblValorRestante
			// 
			this.lblValorRestante.AutoSize = true;
			this.lblValorRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorRestante.ForeColor = System.Drawing.Color.Red;
			this.lblValorRestante.Location = new System.Drawing.Point(141, 285);
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
			this.lblValorDiaria.Location = new System.Drawing.Point(141, 26);
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
			this.lblSubTotal.Location = new System.Drawing.Point(141, 120);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(45, 24);
			this.lblSubTotal.TabIndex = 46;
			this.lblSubTotal.Text = "0,00";
			// 
			// lblAdiantamento
			// 
			this.lblAdiantamento.AutoSize = true;
			this.lblAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdiantamento.ForeColor = System.Drawing.Color.Red;
			this.lblAdiantamento.Location = new System.Drawing.Point(141, 225);
			this.lblAdiantamento.Name = "lblAdiantamento";
			this.lblAdiantamento.Size = new System.Drawing.Size(45, 24);
			this.lblAdiantamento.TabIndex = 45;
			this.lblAdiantamento.Text = "0,00";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(142, 255);
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
			this.lblDias.Location = new System.Drawing.Point(141, 62);
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
			this.lblValorSeguro.Location = new System.Drawing.Point(141, 164);
			this.lblValorSeguro.Name = "lblValorSeguro";
			this.lblValorSeguro.Size = new System.Drawing.Size(45, 24);
			this.lblValorSeguro.TabIndex = 32;
			this.lblValorSeguro.Text = "0,00";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(23, 233);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(113, 13);
			this.label13.TabIndex = 28;
			this.label13.Text = "(-) Valor adiantamento:";
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
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(23, 37);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(79, 13);
			this.label18.TabIndex = 28;
			this.label18.Text = "(=) Valor Diária:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(23, 293);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(95, 13);
			this.label22.TabIndex = 14;
			this.label22.Text = "(=) Valor Restante:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 175);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 13);
			this.label7.TabIndex = 29;
			this.label7.Text = "Km na Devolução:";
			// 
			// txtKmDevolucao
			// 
			this.txtKmDevolucao.Location = new System.Drawing.Point(31, 191);
			this.txtKmDevolucao.MaxLength = 7;
			this.txtKmDevolucao.Name = "txtKmDevolucao";
			this.txtKmDevolucao.Size = new System.Drawing.Size(100, 20);
			this.txtKmDevolucao.TabIndex = 30;
			this.txtKmDevolucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmDevolucao_KeyPress);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(161, 175);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(110, 13);
			this.label23.TabIndex = 31;
			this.label23.Text = "Nivel de combustível:";
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
			this.comboCombustivel.Location = new System.Drawing.Point(164, 190);
			this.comboCombustivel.Name = "comboCombustivel";
			this.comboCombustivel.Size = new System.Drawing.Size(121, 21);
			this.comboCombustivel.TabIndex = 32;
			// 
			// lblRecebidoPor
			// 
			this.lblRecebidoPor.AutoSize = true;
			this.lblRecebidoPor.Location = new System.Drawing.Point(28, 214);
			this.lblRecebidoPor.Name = "lblRecebidoPor";
			this.lblRecebidoPor.Size = new System.Drawing.Size(75, 13);
			this.lblRecebidoPor.TabIndex = 33;
			this.lblRecebidoPor.Text = "Recebido Por:";
			// 
			// comboRecebido
			// 
			this.comboRecebido.FormattingEnabled = true;
			this.comboRecebido.Location = new System.Drawing.Point(31, 231);
			this.comboRecebido.Name = "comboRecebido";
			this.comboRecebido.Size = new System.Drawing.Size(254, 21);
			this.comboRecebido.TabIndex = 34;
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Location = new System.Drawing.Point(187, 297);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(133, 45);
			this.btnFinalizar.TabIndex = 35;
			this.btnFinalizar.Text = "Finalizar devolução";
			this.btnFinalizar.UseVisualStyleBackColor = true;
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// FormDevolucao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 368);
			this.ControlBox = false;
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.comboRecebido);
			this.Controls.Add(this.lblRecebidoPor);
			this.Controls.Add(this.comboCombustivel);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.txtKmDevolucao);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dateDevolucao);
			this.Controls.Add(this.btnAdicionarSinistro);
			this.Controls.Add(this.comboSinistros);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtRetirada);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNomeCliente);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.lblOs);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtNrOS);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormDevolucao";
			this.Text = "Devolução";
			this.Load += new System.EventHandler(this.FormDevolucao_Load);
			this.Enter += new System.EventHandler(this.FormDevolucao_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtNrOS;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lblOs;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRetirada;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboSinistros;
		private System.Windows.Forms.Button btnAdicionarSinistro;
		private System.Windows.Forms.DateTimePicker dateDevolucao;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblValorRestante;
		private System.Windows.Forms.Label lblValorDiaria;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label lblAdiantamento;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lblDias;
		private System.Windows.Forms.Label lblValorSeguro;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtKmDevolucao;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox comboCombustivel;
		private System.Windows.Forms.Label lblRecebidoPor;
		private System.Windows.Forms.ComboBox comboRecebido;
		private System.Windows.Forms.Button btnFinalizar;
	}
}