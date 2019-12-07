namespace Dll_Forms_Fat
{
	partial class FormCadastrarVeiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarVeiculo));
			this.TabCadastroVeiculos = new System.Windows.Forms.TabControl();
			this.tabInformacoes = new System.Windows.Forms.TabPage();
			this.txtAnoModelo = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtMontadora = new System.Windows.Forms.TextBox();
			this.groupOpcionais = new System.Windows.Forms.GroupBox();
			this.checkAirBag = new System.Windows.Forms.CheckBox();
			this.checkAbs = new System.Windows.Forms.CheckBox();
			this.checkArCond = new System.Windows.Forms.CheckBox();
			this.checkVidroEletrico = new System.Windows.Forms.CheckBox();
			this.checkDirecaoHidraulica = new System.Windows.Forms.CheckBox();
			this.comboAno = new System.Windows.Forms.ComboBox();
			this.txtCombustivel = new System.Windows.Forms.TextBox();
			this.numericLugares = new System.Windows.Forms.NumericUpDown();
			this.lblLugares = new System.Windows.Forms.Label();
			this.txtValorAtualCarro = new System.Windows.Forms.TextBox();
			this.btnLocalizar = new System.Windows.Forms.Button();
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
			this.comboMontadora = new System.Windows.Forms.ComboBox();
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
			this.comboModelo = new System.Windows.Forms.ComboBox();
			this.TabCadastroVeiculos.SuspendLayout();
			this.tabInformacoes.SuspendLayout();
			this.groupOpcionais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLugares)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPortas)).BeginInit();
			this.SuspendLayout();
			// 
			// TabCadastroVeiculos
			// 
			this.TabCadastroVeiculos.Controls.Add(this.tabInformacoes);
			this.TabCadastroVeiculos.Location = new System.Drawing.Point(12, 12);
			this.TabCadastroVeiculos.Name = "TabCadastroVeiculos";
			this.TabCadastroVeiculos.SelectedIndex = 0;
			this.TabCadastroVeiculos.Size = new System.Drawing.Size(760, 380);
			this.TabCadastroVeiculos.TabIndex = 17;
			this.TabCadastroVeiculos.TabStop = false;
			// 
			// tabInformacoes
			// 
			this.tabInformacoes.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabInformacoes.Controls.Add(this.txtAnoModelo);
			this.tabInformacoes.Controls.Add(this.txtModelo);
			this.tabInformacoes.Controls.Add(this.txtMontadora);
			this.tabInformacoes.Controls.Add(this.groupOpcionais);
			this.tabInformacoes.Controls.Add(this.comboAno);
			this.tabInformacoes.Controls.Add(this.txtCombustivel);
			this.tabInformacoes.Controls.Add(this.numericLugares);
			this.tabInformacoes.Controls.Add(this.lblLugares);
			this.tabInformacoes.Controls.Add(this.txtValorAtualCarro);
			this.tabInformacoes.Controls.Add(this.btnLocalizar);
			this.tabInformacoes.Controls.Add(this.label4);
			this.tabInformacoes.Controls.Add(this.numericPortas);
			this.tabInformacoes.Controls.Add(this.label3);
			this.tabInformacoes.Controls.Add(this.comboStatus);
			this.tabInformacoes.Controls.Add(this.label2);
			this.tabInformacoes.Controls.Add(this.txtId);
			this.tabInformacoes.Controls.Add(this.label1);
			this.tabInformacoes.Controls.Add(this.txtOdometro);
			this.tabInformacoes.Controls.Add(this.lblOdometro);
			this.tabInformacoes.Controls.Add(this.txtRenavam);
			this.tabInformacoes.Controls.Add(this.lblRenavam);
			this.tabInformacoes.Controls.Add(this.lblObservacoes);
			this.tabInformacoes.Controls.Add(this.txtObservacoes);
			this.tabInformacoes.Controls.Add(this.lblPortas);
			this.tabInformacoes.Controls.Add(this.comboMontadora);
			this.tabInformacoes.Controls.Add(this.comboCor);
			this.tabInformacoes.Controls.Add(this.lblAnoMod);
			this.tabInformacoes.Controls.Add(this.lblMontadora);
			this.tabInformacoes.Controls.Add(this.maskedTxtPlaca);
			this.tabInformacoes.Controls.Add(this.lblCor);
			this.tabInformacoes.Controls.Add(this.lblModelo);
			this.tabInformacoes.Controls.Add(this.lblPlaca);
			this.tabInformacoes.Controls.Add(this.lblChassi);
			this.tabInformacoes.Controls.Add(this.txtChassi);
			this.tabInformacoes.Controls.Add(this.btnSalvar);
			this.tabInformacoes.Controls.Add(this.comboModelo);
			this.tabInformacoes.Location = new System.Drawing.Point(4, 22);
			this.tabInformacoes.Name = "tabInformacoes";
			this.tabInformacoes.Padding = new System.Windows.Forms.Padding(3);
			this.tabInformacoes.Size = new System.Drawing.Size(752, 354);
			this.tabInformacoes.TabIndex = 0;
			this.tabInformacoes.Text = "Informações do veículo";
			// 
			// txtAnoModelo
			// 
			this.txtAnoModelo.Location = new System.Drawing.Point(467, 59);
			this.txtAnoModelo.Name = "txtAnoModelo";
			this.txtAnoModelo.ReadOnly = true;
			this.txtAnoModelo.Size = new System.Drawing.Size(121, 20);
			this.txtAnoModelo.TabIndex = 164;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(214, 59);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.ReadOnly = true;
			this.txtModelo.Size = new System.Drawing.Size(247, 20);
			this.txtModelo.TabIndex = 163;
			// 
			// txtMontadora
			// 
			this.txtMontadora.Location = new System.Drawing.Point(79, 59);
			this.txtMontadora.Name = "txtMontadora";
			this.txtMontadora.ReadOnly = true;
			this.txtMontadora.Size = new System.Drawing.Size(129, 20);
			this.txtMontadora.TabIndex = 162;
			// 
			// groupOpcionais
			// 
			this.groupOpcionais.Controls.Add(this.checkAirBag);
			this.groupOpcionais.Controls.Add(this.checkAbs);
			this.groupOpcionais.Controls.Add(this.checkArCond);
			this.groupOpcionais.Controls.Add(this.checkVidroEletrico);
			this.groupOpcionais.Controls.Add(this.checkDirecaoHidraulica);
			this.groupOpcionais.Location = new System.Drawing.Point(603, 43);
			this.groupOpcionais.Name = "groupOpcionais";
			this.groupOpcionais.Size = new System.Drawing.Size(132, 139);
			this.groupOpcionais.TabIndex = 13;
			this.groupOpcionais.TabStop = false;
			this.groupOpcionais.Text = "Opcionais";
			// 
			// checkAirBag
			// 
			this.checkAirBag.AutoSize = true;
			this.checkAirBag.Location = new System.Drawing.Point(6, 110);
			this.checkAirBag.Name = "checkAirBag";
			this.checkAirBag.Size = new System.Drawing.Size(60, 17);
			this.checkAirBag.TabIndex = 17;
			this.checkAirBag.Text = "Air Bag";
			this.checkAirBag.UseVisualStyleBackColor = true;
			// 
			// checkAbs
			// 
			this.checkAbs.AutoSize = true;
			this.checkAbs.Location = new System.Drawing.Point(6, 88);
			this.checkAbs.Name = "checkAbs";
			this.checkAbs.Size = new System.Drawing.Size(47, 17);
			this.checkAbs.TabIndex = 16;
			this.checkAbs.Text = "ABS";
			this.checkAbs.UseVisualStyleBackColor = true;
			// 
			// checkArCond
			// 
			this.checkArCond.AutoSize = true;
			this.checkArCond.Location = new System.Drawing.Point(6, 22);
			this.checkArCond.Name = "checkArCond";
			this.checkArCond.Size = new System.Drawing.Size(104, 17);
			this.checkArCond.TabIndex = 13;
			this.checkArCond.Text = "Ar Condicionado";
			this.checkArCond.UseVisualStyleBackColor = true;
			// 
			// checkVidroEletrico
			// 
			this.checkVidroEletrico.AutoSize = true;
			this.checkVidroEletrico.Location = new System.Drawing.Point(6, 65);
			this.checkVidroEletrico.Name = "checkVidroEletrico";
			this.checkVidroEletrico.Size = new System.Drawing.Size(88, 17);
			this.checkVidroEletrico.TabIndex = 15;
			this.checkVidroEletrico.Text = "Vidro Elétrico";
			this.checkVidroEletrico.UseVisualStyleBackColor = true;
			// 
			// checkDirecaoHidraulica
			// 
			this.checkDirecaoHidraulica.AutoSize = true;
			this.checkDirecaoHidraulica.Location = new System.Drawing.Point(6, 44);
			this.checkDirecaoHidraulica.Name = "checkDirecaoHidraulica";
			this.checkDirecaoHidraulica.Size = new System.Drawing.Size(113, 17);
			this.checkDirecaoHidraulica.TabIndex = 14;
			this.checkDirecaoHidraulica.Text = "Direção Hidraulica";
			this.checkDirecaoHidraulica.UseVisualStyleBackColor = true;
			// 
			// comboAno
			// 
			this.comboAno.FormattingEnabled = true;
			this.comboAno.Location = new System.Drawing.Point(467, 59);
			this.comboAno.Name = "comboAno";
			this.comboAno.Size = new System.Drawing.Size(121, 21);
			this.comboAno.TabIndex = 3;
			this.comboAno.SelectedIndexChanged += new System.EventHandler(this.ComboAno_SelectedIndexChanged);
			// 
			// txtCombustivel
			// 
			this.txtCombustivel.Location = new System.Drawing.Point(246, 144);
			this.txtCombustivel.Name = "txtCombustivel";
			this.txtCombustivel.ReadOnly = true;
			this.txtCombustivel.Size = new System.Drawing.Size(74, 20);
			this.txtCombustivel.TabIndex = 81;
			this.txtCombustivel.TabStop = false;
			// 
			// numericLugares
			// 
			this.numericLugares.Location = new System.Drawing.Point(17, 143);
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
			this.numericLugares.TabIndex = 9;
			this.numericLugares.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lblLugares
			// 
			this.lblLugares.AutoSize = true;
			this.lblLugares.Location = new System.Drawing.Point(13, 126);
			this.lblLugares.Name = "lblLugares";
			this.lblLugares.Size = new System.Drawing.Size(45, 13);
			this.lblLugares.TabIndex = 79;
			this.lblLugares.Text = "Lugares";
			// 
			// txtValorAtualCarro
			// 
			this.txtValorAtualCarro.Location = new System.Drawing.Point(332, 144);
			this.txtValorAtualCarro.MaxLength = 7;
			this.txtValorAtualCarro.Name = "txtValorAtualCarro";
			this.txtValorAtualCarro.ReadOnly = true;
			this.txtValorAtualCarro.Size = new System.Drawing.Size(85, 20);
			this.txtValorAtualCarro.TabIndex = 78;
			this.txtValorAtualCarro.TabStop = false;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.Location = new System.Drawing.Point(630, 195);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(105, 40);
			this.btnLocalizar.TabIndex = 77;
			this.btnLocalizar.Text = "Localizar...";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(329, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 75;
			this.label4.Text = "Valor Atual Carro";
			// 
			// numericPortas
			// 
			this.numericPortas.Location = new System.Drawing.Point(18, 105);
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
			this.numericPortas.TabIndex = 4;
			this.numericPortas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(246, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 71;
			this.label3.Text = "Combustível";
			// 
			// comboStatus
			// 
			this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "MECÂNICA"});
			this.comboStatus.Location = new System.Drawing.Point(155, 143);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(77, 21);
			this.comboStatus.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 69;
			this.label2.Text = "Status";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(18, 60);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(47, 20);
			this.txtId.TabIndex = 68;
			this.txtId.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 67;
			this.label1.Text = "Nº na Frota";
			// 
			// txtOdometro
			// 
			this.txtOdometro.Location = new System.Drawing.Point(79, 143);
			this.txtOdometro.MaxLength = 7;
			this.txtOdometro.Name = "txtOdometro";
			this.txtOdometro.Size = new System.Drawing.Size(69, 20);
			this.txtOdometro.TabIndex = 10;
			this.txtOdometro.Text = "0";
			this.txtOdometro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOdometro_KeyPress);
			// 
			// lblOdometro
			// 
			this.lblOdometro.AutoSize = true;
			this.lblOdometro.Location = new System.Drawing.Point(76, 127);
			this.lblOdometro.Name = "lblOdometro";
			this.lblOdometro.Size = new System.Drawing.Size(53, 13);
			this.lblOdometro.TabIndex = 65;
			this.lblOdometro.Text = "Odômetro";
			// 
			// txtRenavam
			// 
			this.txtRenavam.Location = new System.Drawing.Point(246, 104);
			this.txtRenavam.Name = "txtRenavam";
			this.txtRenavam.Size = new System.Drawing.Size(139, 20);
			this.txtRenavam.TabIndex = 7;
			// 
			// lblRenavam
			// 
			this.lblRenavam.AutoSize = true;
			this.lblRenavam.Location = new System.Drawing.Point(249, 88);
			this.lblRenavam.Name = "lblRenavam";
			this.lblRenavam.Size = new System.Drawing.Size(53, 13);
			this.lblRenavam.TabIndex = 59;
			this.lblRenavam.Text = "Renavam";
			// 
			// lblObservacoes
			// 
			this.lblObservacoes.AutoSize = true;
			this.lblObservacoes.Location = new System.Drawing.Point(14, 178);
			this.lblObservacoes.Name = "lblObservacoes";
			this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
			this.lblObservacoes.TabIndex = 61;
			this.lblObservacoes.Text = "Observações";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(17, 194);
			this.txtObservacoes.MaxLength = 250;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(533, 96);
			this.txtObservacoes.TabIndex = 60;
			this.txtObservacoes.Text = "";
			// 
			// lblPortas
			// 
			this.lblPortas.AutoSize = true;
			this.lblPortas.Location = new System.Drawing.Point(14, 88);
			this.lblPortas.Name = "lblPortas";
			this.lblPortas.Size = new System.Drawing.Size(37, 13);
			this.lblPortas.TabIndex = 57;
			this.lblPortas.Text = "Portas";
			// 
			// comboMontadora
			// 
			this.comboMontadora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboMontadora.FormattingEnabled = true;
			this.comboMontadora.Location = new System.Drawing.Point(79, 59);
			this.comboMontadora.Name = "comboMontadora";
			this.comboMontadora.Size = new System.Drawing.Size(129, 21);
			this.comboMontadora.Sorted = true;
			this.comboMontadora.TabIndex = 1;
			this.comboMontadora.SelectedIndexChanged += new System.EventHandler(this.ComboMontadora_SelectedIndexChanged);
			// 
			// comboCor
			// 
			this.comboCor.FormattingEnabled = true;
			this.comboCor.Location = new System.Drawing.Point(79, 103);
			this.comboCor.Name = "comboCor";
			this.comboCor.Size = new System.Drawing.Size(92, 21);
			this.comboCor.Sorted = true;
			this.comboCor.TabIndex = 5;
			// 
			// lblAnoMod
			// 
			this.lblAnoMod.AutoSize = true;
			this.lblAnoMod.Location = new System.Drawing.Point(464, 43);
			this.lblAnoMod.Name = "lblAnoMod";
			this.lblAnoMod.Size = new System.Drawing.Size(50, 13);
			this.lblAnoMod.TabIndex = 55;
			this.lblAnoMod.Text = "Ano Mod";
			// 
			// lblMontadora
			// 
			this.lblMontadora.AutoSize = true;
			this.lblMontadora.Location = new System.Drawing.Point(79, 43);
			this.lblMontadora.Name = "lblMontadora";
			this.lblMontadora.Size = new System.Drawing.Size(58, 13);
			this.lblMontadora.TabIndex = 53;
			this.lblMontadora.Text = "Montadora";
			// 
			// maskedTxtPlaca
			// 
			this.maskedTxtPlaca.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedTxtPlaca.HidePromptOnLeave = true;
			this.maskedTxtPlaca.Location = new System.Drawing.Point(185, 104);
			this.maskedTxtPlaca.Mask = "???-0000";
			this.maskedTxtPlaca.Name = "maskedTxtPlaca";
			this.maskedTxtPlaca.PromptChar = ' ';
			this.maskedTxtPlaca.Size = new System.Drawing.Size(55, 20);
			this.maskedTxtPlaca.TabIndex = 6;
			this.maskedTxtPlaca.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedTxtPlaca.Leave += new System.EventHandler(this.MaskedTxtPlaca_Leave);
			// 
			// lblCor
			// 
			this.lblCor.AutoSize = true;
			this.lblCor.Location = new System.Drawing.Point(79, 88);
			this.lblCor.Name = "lblCor";
			this.lblCor.Size = new System.Drawing.Size(23, 13);
			this.lblCor.TabIndex = 45;
			this.lblCor.Text = "Cor";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(211, 43);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(42, 13);
			this.lblModelo.TabIndex = 48;
			this.lblModelo.Text = "Modelo";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(185, 88);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(34, 13);
			this.lblPlaca.TabIndex = 47;
			this.lblPlaca.Text = "Placa";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(388, 87);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(38, 13);
			this.lblChassi.TabIndex = 54;
			this.lblChassi.Text = "Chassi";
			// 
			// txtChassi
			// 
			this.txtChassi.Location = new System.Drawing.Point(391, 103);
			this.txtChassi.MaxLength = 15;
			this.txtChassi.Name = "txtChassi";
			this.txtChassi.Size = new System.Drawing.Size(197, 20);
			this.txtChassi.TabIndex = 8;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(630, 250);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 18;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
			// 
			// comboModelo
			// 
			this.comboModelo.FormattingEnabled = true;
			this.comboModelo.Location = new System.Drawing.Point(214, 59);
			this.comboModelo.Name = "comboModelo";
			this.comboModelo.Size = new System.Drawing.Size(247, 21);
			this.comboModelo.TabIndex = 2;
			this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
			// 
			// FormCadastrarVeiculo
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 418);
			this.ControlBox = false;
			this.Controls.Add(this.TabCadastroVeiculos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Cadastro de Veículos";
			this.Load += new System.EventHandler(this.FormCadastrarNovoVeiculo_Load);
			this.TabCadastroVeiculos.ResumeLayout(false);
			this.tabInformacoes.ResumeLayout(false);
			this.tabInformacoes.PerformLayout();
			this.groupOpcionais.ResumeLayout(false);
			this.groupOpcionais.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLugares)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPortas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabInformacoes;
		private System.Windows.Forms.Button btnLocalizar;
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
		private System.Windows.Forms.ComboBox comboMontadora;
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
		private System.Windows.Forms.ComboBox comboModelo;
		public System.Windows.Forms.TabControl TabCadastroVeiculos;
		private System.Windows.Forms.TextBox txtValorAtualCarro;
		private System.Windows.Forms.NumericUpDown numericLugares;
		private System.Windows.Forms.Label lblLugares;
		private System.Windows.Forms.TextBox txtCombustivel;
		private System.Windows.Forms.ComboBox comboAno;
		private System.Windows.Forms.GroupBox groupOpcionais;
		private System.Windows.Forms.CheckBox checkAirBag;
		private System.Windows.Forms.CheckBox checkAbs;
		private System.Windows.Forms.CheckBox checkArCond;
		private System.Windows.Forms.CheckBox checkVidroEletrico;
		private System.Windows.Forms.CheckBox checkDirecaoHidraulica;
		private System.Windows.Forms.TextBox txtAnoModelo;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtMontadora;
	}
}