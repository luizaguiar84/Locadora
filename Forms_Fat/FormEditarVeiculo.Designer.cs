namespace Dll_Forms_Fat
{
    partial class FormEditarVeiculo
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
			this.txtAnoModelo = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtMontadora = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValorDiaria = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txtCombustivel = new System.Windows.Forms.TextBox();
			this.numericLugares = new System.Windows.Forms.NumericUpDown();
			this.lblLugares = new System.Windows.Forms.Label();
			this.txtValorAtualCarro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numericPortas = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtOdometro = new System.Windows.Forms.TextBox();
			this.lblOdometro = new System.Windows.Forms.Label();
			this.txtRenavam = new System.Windows.Forms.TextBox();
			this.lblRenavam = new System.Windows.Forms.Label();
			this.lblObservacoes = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.RichTextBox();
			this.lblPortas = new System.Windows.Forms.Label();
			this.comboCor = new System.Windows.Forms.ComboBox();
			this.lblAnoMod = new System.Windows.Forms.Label();
			this.lblMontadora = new System.Windows.Forms.Label();
			this.maskedTxtPlaca = new System.Windows.Forms.MaskedTextBox();
			this.lblCor = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.txtChassi = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.groupOpcionais = new System.Windows.Forms.GroupBox();
			this.checkAirBag = new System.Windows.Forms.CheckBox();
			this.checkAbs = new System.Windows.Forms.CheckBox();
			this.checkArCond = new System.Windows.Forms.CheckBox();
			this.checkVidroEletrico = new System.Windows.Forms.CheckBox();
			this.checkDirecaoHidraulica = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericLugares)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPortas)).BeginInit();
			this.groupOpcionais.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtAnoModelo
			// 
			this.txtAnoModelo.Location = new System.Drawing.Point(477, 119);
			this.txtAnoModelo.Name = "txtAnoModelo";
			this.txtAnoModelo.ReadOnly = true;
			this.txtAnoModelo.Size = new System.Drawing.Size(129, 20);
			this.txtAnoModelo.TabIndex = 161;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(220, 119);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.ReadOnly = true;
			this.txtModelo.Size = new System.Drawing.Size(251, 20);
			this.txtModelo.TabIndex = 160;
			// 
			// txtMontadora
			// 
			this.txtMontadora.Location = new System.Drawing.Point(97, 119);
			this.txtMontadora.Name = "txtMontadora";
			this.txtMontadora.ReadOnly = true;
			this.txtMontadora.Size = new System.Drawing.Size(117, 20);
			this.txtMontadora.TabIndex = 159;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(290, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 31);
			this.label5.TabIndex = 158;
			this.label5.Text = "Editar Veiculo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtValorDiaria
			// 
			this.txtValorDiaria.Location = new System.Drawing.Point(442, 204);
			this.txtValorDiaria.MaxLength = 7;
			this.txtValorDiaria.Name = "txtValorDiaria";
			this.txtValorDiaria.Size = new System.Drawing.Size(85, 20);
			this.txtValorDiaria.TabIndex = 157;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(439, 187);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 13);
			this.label29.TabIndex = 156;
			this.label29.Text = "Valor diário locação";
			// 
			// txtCombustivel
			// 
			this.txtCombustivel.Location = new System.Drawing.Point(264, 204);
			this.txtCombustivel.Name = "txtCombustivel";
			this.txtCombustivel.ReadOnly = true;
			this.txtCombustivel.Size = new System.Drawing.Size(74, 20);
			this.txtCombustivel.TabIndex = 155;
			// 
			// numericLugares
			// 
			this.numericLugares.Location = new System.Drawing.Point(35, 203);
			this.numericLugares.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numericLugares.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericLugares.Name = "numericLugares";
			this.numericLugares.Size = new System.Drawing.Size(38, 20);
			this.numericLugares.TabIndex = 154;
			this.numericLugares.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lblLugares
			// 
			this.lblLugares.AutoSize = true;
			this.lblLugares.Location = new System.Drawing.Point(31, 186);
			this.lblLugares.Name = "lblLugares";
			this.lblLugares.Size = new System.Drawing.Size(45, 13);
			this.lblLugares.TabIndex = 153;
			this.lblLugares.Text = "Lugares";
			// 
			// txtValorAtualCarro
			// 
			this.txtValorAtualCarro.Location = new System.Drawing.Point(350, 204);
			this.txtValorAtualCarro.MaxLength = 7;
			this.txtValorAtualCarro.Name = "txtValorAtualCarro";
			this.txtValorAtualCarro.ReadOnly = true;
			this.txtValorAtualCarro.Size = new System.Drawing.Size(85, 20);
			this.txtValorAtualCarro.TabIndex = 152;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(347, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 150;
			this.label4.Text = "Valor Atual Carro";
			// 
			// numericPortas
			// 
			this.numericPortas.Location = new System.Drawing.Point(36, 165);
			this.numericPortas.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numericPortas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericPortas.Name = "numericPortas";
			this.numericPortas.Size = new System.Drawing.Size(38, 20);
			this.numericPortas.TabIndex = 136;
			this.numericPortas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(264, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 149;
			this.label3.Text = "Combustível";
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "MECÂNICA"});
			this.comboStatus.Location = new System.Drawing.Point(173, 203);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(77, 21);
			this.comboStatus.TabIndex = 148;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(178, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 147;
			this.label2.Text = "Status";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(36, 120);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(47, 20);
			this.txtId.TabIndex = 146;
			this.txtId.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 145;
			this.label1.Text = "Nº na Frota";
			// 
			// txtOdometro
			// 
			this.txtOdometro.Location = new System.Drawing.Point(97, 203);
			this.txtOdometro.MaxLength = 7;
			this.txtOdometro.Name = "txtOdometro";
			this.txtOdometro.Size = new System.Drawing.Size(69, 20);
			this.txtOdometro.TabIndex = 144;
			// 
			// lblOdometro
			// 
			this.lblOdometro.AutoSize = true;
			this.lblOdometro.Location = new System.Drawing.Point(94, 187);
			this.lblOdometro.Name = "lblOdometro";
			this.lblOdometro.Size = new System.Drawing.Size(53, 13);
			this.lblOdometro.TabIndex = 143;
			this.lblOdometro.Text = "Odômetro";
			// 
			// txtRenavam
			// 
			this.txtRenavam.Location = new System.Drawing.Point(264, 164);
			this.txtRenavam.Name = "txtRenavam";
			this.txtRenavam.Size = new System.Drawing.Size(139, 20);
			this.txtRenavam.TabIndex = 140;
			// 
			// lblRenavam
			// 
			this.lblRenavam.AutoSize = true;
			this.lblRenavam.Location = new System.Drawing.Point(267, 148);
			this.lblRenavam.Name = "lblRenavam";
			this.lblRenavam.Size = new System.Drawing.Size(53, 13);
			this.lblRenavam.TabIndex = 137;
			this.lblRenavam.Text = "Renavam";
			// 
			// lblObservacoes
			// 
			this.lblObservacoes.AutoSize = true;
			this.lblObservacoes.Location = new System.Drawing.Point(32, 238);
			this.lblObservacoes.Name = "lblObservacoes";
			this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
			this.lblObservacoes.TabIndex = 139;
			this.lblObservacoes.Text = "Observações";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(35, 254);
			this.txtObservacoes.MaxLength = 250;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(533, 96);
			this.txtObservacoes.TabIndex = 138;
			this.txtObservacoes.Text = "";
			// 
			// lblPortas
			// 
			this.lblPortas.AutoSize = true;
			this.lblPortas.Location = new System.Drawing.Point(32, 148);
			this.lblPortas.Name = "lblPortas";
			this.lblPortas.Size = new System.Drawing.Size(37, 13);
			this.lblPortas.TabIndex = 135;
			this.lblPortas.Text = "Portas";
			// 
			// comboCor
			// 
			this.comboCor.FormattingEnabled = true;
			this.comboCor.Location = new System.Drawing.Point(97, 163);
			this.comboCor.Name = "comboCor";
			this.comboCor.Size = new System.Drawing.Size(92, 21);
			this.comboCor.TabIndex = 130;
			// 
			// lblAnoMod
			// 
			this.lblAnoMod.AutoSize = true;
			this.lblAnoMod.Location = new System.Drawing.Point(477, 103);
			this.lblAnoMod.Name = "lblAnoMod";
			this.lblAnoMod.Size = new System.Drawing.Size(50, 13);
			this.lblAnoMod.TabIndex = 134;
			this.lblAnoMod.Text = "Ano Mod";
			// 
			// lblMontadora
			// 
			this.lblMontadora.AutoSize = true;
			this.lblMontadora.Location = new System.Drawing.Point(97, 103);
			this.lblMontadora.Name = "lblMontadora";
			this.lblMontadora.Size = new System.Drawing.Size(58, 13);
			this.lblMontadora.TabIndex = 132;
			this.lblMontadora.Text = "Montadora";
			// 
			// maskedTxtPlaca
			// 
			this.maskedTxtPlaca.HidePromptOnLeave = true;
			this.maskedTxtPlaca.Location = new System.Drawing.Point(203, 164);
			this.maskedTxtPlaca.Mask = "???-0000";
			this.maskedTxtPlaca.Name = "maskedTxtPlaca";
			this.maskedTxtPlaca.Size = new System.Drawing.Size(55, 20);
			this.maskedTxtPlaca.TabIndex = 129;
			this.maskedTxtPlaca.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblCor
			// 
			this.lblCor.AutoSize = true;
			this.lblCor.Location = new System.Drawing.Point(97, 148);
			this.lblCor.Name = "lblCor";
			this.lblCor.Size = new System.Drawing.Size(23, 13);
			this.lblCor.TabIndex = 125;
			this.lblCor.Text = "Cor";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(217, 103);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(42, 13);
			this.lblModelo.TabIndex = 128;
			this.lblModelo.Text = "Modelo";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(203, 148);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(34, 13);
			this.lblPlaca.TabIndex = 127;
			this.lblPlaca.Text = "Placa";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(406, 147);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(38, 13);
			this.lblChassi.TabIndex = 133;
			this.lblChassi.Text = "Chassi";
			// 
			// txtChassi
			// 
			this.txtChassi.Location = new System.Drawing.Point(409, 163);
			this.txtChassi.MaxLength = 15;
			this.txtChassi.Name = "txtChassi";
			this.txtChassi.Size = new System.Drawing.Size(197, 20);
			this.txtChassi.TabIndex = 126;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(648, 310);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 131;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// groupOpcionais
			// 
			this.groupOpcionais.Controls.Add(this.checkAirBag);
			this.groupOpcionais.Controls.Add(this.checkAbs);
			this.groupOpcionais.Controls.Add(this.checkArCond);
			this.groupOpcionais.Controls.Add(this.checkVidroEletrico);
			this.groupOpcionais.Controls.Add(this.checkDirecaoHidraulica);
			this.groupOpcionais.Location = new System.Drawing.Point(637, 103);
			this.groupOpcionais.Name = "groupOpcionais";
			this.groupOpcionais.Size = new System.Drawing.Size(132, 139);
			this.groupOpcionais.TabIndex = 162;
			this.groupOpcionais.TabStop = false;
			this.groupOpcionais.Text = "Opcionais";
			// 
			// checkAirBag
			// 
			this.checkAirBag.AutoSize = true;
			this.checkAirBag.Location = new System.Drawing.Point(6, 110);
			this.checkAirBag.Name = "checkAirBag";
			this.checkAirBag.Size = new System.Drawing.Size(60, 17);
			this.checkAirBag.TabIndex = 89;
			this.checkAirBag.Text = "Air Bag";
			this.checkAirBag.UseVisualStyleBackColor = true;
			// 
			// checkAbs
			// 
			this.checkAbs.AutoSize = true;
			this.checkAbs.Location = new System.Drawing.Point(6, 88);
			this.checkAbs.Name = "checkAbs";
			this.checkAbs.Size = new System.Drawing.Size(47, 17);
			this.checkAbs.TabIndex = 88;
			this.checkAbs.Text = "ABS";
			this.checkAbs.UseVisualStyleBackColor = true;
			// 
			// checkArCond
			// 
			this.checkArCond.AutoSize = true;
			this.checkArCond.Location = new System.Drawing.Point(6, 22);
			this.checkArCond.Name = "checkArCond";
			this.checkArCond.Size = new System.Drawing.Size(104, 17);
			this.checkArCond.TabIndex = 85;
			this.checkArCond.Text = "Ar Condicionado";
			this.checkArCond.UseVisualStyleBackColor = true;
			// 
			// checkVidroEletrico
			// 
			this.checkVidroEletrico.AutoSize = true;
			this.checkVidroEletrico.Location = new System.Drawing.Point(6, 65);
			this.checkVidroEletrico.Name = "checkVidroEletrico";
			this.checkVidroEletrico.Size = new System.Drawing.Size(88, 17);
			this.checkVidroEletrico.TabIndex = 87;
			this.checkVidroEletrico.Text = "Vidro Elétrico";
			this.checkVidroEletrico.UseVisualStyleBackColor = true;
			// 
			// checkDirecaoHidraulica
			// 
			this.checkDirecaoHidraulica.AutoSize = true;
			this.checkDirecaoHidraulica.Location = new System.Drawing.Point(6, 44);
			this.checkDirecaoHidraulica.Name = "checkDirecaoHidraulica";
			this.checkDirecaoHidraulica.Size = new System.Drawing.Size(113, 17);
			this.checkDirecaoHidraulica.TabIndex = 86;
			this.checkDirecaoHidraulica.Text = "Direção Hidraulica";
			this.checkDirecaoHidraulica.UseVisualStyleBackColor = true;
			// 
			// FormEditarVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupOpcionais);
			this.Controls.Add(this.txtAnoModelo);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.txtMontadora);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtValorDiaria);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.txtCombustivel);
			this.Controls.Add(this.numericLugares);
			this.Controls.Add(this.lblLugares);
			this.Controls.Add(this.txtValorAtualCarro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericPortas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOdometro);
			this.Controls.Add(this.lblOdometro);
			this.Controls.Add(this.txtRenavam);
			this.Controls.Add(this.lblRenavam);
			this.Controls.Add(this.lblObservacoes);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.lblPortas);
			this.Controls.Add(this.comboCor);
			this.Controls.Add(this.lblAnoMod);
			this.Controls.Add(this.lblMontadora);
			this.Controls.Add(this.maskedTxtPlaca);
			this.Controls.Add(this.lblCor);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblChassi);
			this.Controls.Add(this.txtChassi);
			this.Controls.Add(this.btnSalvar);
			this.Name = "FormEditarVeiculo";
			this.Text = "Editar Veiculo";
			this.Load += new System.EventHandler(this.FormEditarVeiculo_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericLugares)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPortas)).EndInit();
			this.groupOpcionais.ResumeLayout(false);
			this.groupOpcionais.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox txtAnoModelo;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtMontadora;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtValorDiaria;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox txtCombustivel;
		private System.Windows.Forms.NumericUpDown numericLugares;
		private System.Windows.Forms.Label lblLugares;
		private System.Windows.Forms.TextBox txtValorAtualCarro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericPortas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOdometro;
		private System.Windows.Forms.Label lblOdometro;
		private System.Windows.Forms.TextBox txtRenavam;
		private System.Windows.Forms.Label lblRenavam;
		private System.Windows.Forms.Label lblObservacoes;
		private System.Windows.Forms.RichTextBox txtObservacoes;
		private System.Windows.Forms.Label lblPortas;
		private System.Windows.Forms.ComboBox comboCor;
		private System.Windows.Forms.Label lblAnoMod;
		private System.Windows.Forms.Label lblMontadora;
		private System.Windows.Forms.MaskedTextBox maskedTxtPlaca;
		private System.Windows.Forms.Label lblCor;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblChassi;
		private System.Windows.Forms.TextBox txtChassi;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.GroupBox groupOpcionais;
		private System.Windows.Forms.CheckBox checkAirBag;
		private System.Windows.Forms.CheckBox checkAbs;
		private System.Windows.Forms.CheckBox checkArCond;
		private System.Windows.Forms.CheckBox checkVidroEletrico;
		private System.Windows.Forms.CheckBox checkDirecaoHidraulica;
	}
}