namespace Dll_Forms_Fat
{
	partial class FormCadastrarCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarCliente));
			this.label17 = new System.Windows.Forms.Label();
			this.dateCnhValidade = new System.Windows.Forms.DateTimePicker();
			this.dateCnhEmitida = new System.Windows.Forms.DateTimePicker();
			this.dateNascimento = new System.Windows.Forms.DateTimePicker();
			this.lblId = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.ComboBox();
			this.checkAtivo = new System.Windows.Forms.CheckBox();
			this.groupEndereco = new System.Windows.Forms.GroupBox();
			this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.txtLogradouro = new System.Windows.Forms.TextBox();
			this.lblUF = new System.Windows.Forms.Label();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCel = new System.Windows.Forms.Label();
			this.txtProfissao = new System.Windows.Forms.TextBox();
			this.txtTelRes = new System.Windows.Forms.MaskedTextBox();
			this.lblTelRes = new System.Windows.Forms.Label();
			this.txtTelCom = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCom = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.lblProfissao = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.txtCNH = new System.Windows.Forms.TextBox();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.lblCNH = new System.Windows.Forms.Label();
			this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.radioPessoaFisica = new System.Windows.Forms.RadioButton();
			this.radioPessoaJuridica = new System.Windows.Forms.RadioButton();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.groupEndereco.SuspendLayout();
			this.SuspendLayout();
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(310, 344);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(0, 13);
			this.label17.TabIndex = 24;
			// 
			// dateCnhValidade
			// 
			this.dateCnhValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateCnhValidade.Location = new System.Drawing.Point(406, 213);
			this.dateCnhValidade.Name = "dateCnhValidade";
			this.dateCnhValidade.Size = new System.Drawing.Size(104, 20);
			this.dateCnhValidade.TabIndex = 257;
			// 
			// dateCnhEmitida
			// 
			this.dateCnhEmitida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateCnhEmitida.Location = new System.Drawing.Point(299, 213);
			this.dateCnhEmitida.Name = "dateCnhEmitida";
			this.dateCnhEmitida.Size = new System.Drawing.Size(101, 20);
			this.dateCnhEmitida.TabIndex = 256;
			// 
			// dateNascimento
			// 
			this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNascimento.Location = new System.Drawing.Point(575, 126);
			this.dateNascimento.Name = "dateNascimento";
			this.dateNascimento.Size = new System.Drawing.Size(104, 20);
			this.dateNascimento.TabIndex = 250;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(30, 33);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(56, 13);
			this.lblId.TabIndex = 276;
			this.lblId.Text = "Nr. Cliente";
			// 
			// txtId
			// 
			this.txtId.CausesValidation = false;
			this.txtId.Location = new System.Drawing.Point(33, 49);
			this.txtId.MaxLength = 200;
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(49, 20);
			this.txtId.TabIndex = 275;
			this.txtId.TabStop = false;
			// 
			// txtCategoria
			// 
			this.txtCategoria.FormattingEnabled = true;
			this.txtCategoria.Items.AddRange(new object[] {
            "A",
            "AB",
            "B",
            "C",
            "D",
            "E"});
			this.txtCategoria.Location = new System.Drawing.Point(244, 212);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(39, 21);
			this.txtCategoria.TabIndex = 255;
			// 
			// checkAtivo
			// 
			this.checkAtivo.AutoSize = true;
			this.checkAtivo.Checked = true;
			this.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAtivo.Location = new System.Drawing.Point(323, 48);
			this.checkAtivo.Name = "checkAtivo";
			this.checkAtivo.Size = new System.Drawing.Size(85, 17);
			this.checkAtivo.TabIndex = 274;
			this.checkAtivo.Text = "Cliente Ativo";
			this.checkAtivo.UseVisualStyleBackColor = true;
			// 
			// groupEndereco
			// 
			this.groupEndereco.Controls.Add(this.maskedCEP);
			this.groupEndereco.Controls.Add(this.lblCep);
			this.groupEndereco.Controls.Add(this.lblNumero);
			this.groupEndereco.Controls.Add(this.txtUF);
			this.groupEndereco.Controls.Add(this.lblLogradouro);
			this.groupEndereco.Controls.Add(this.txtLogradouro);
			this.groupEndereco.Controls.Add(this.lblUF);
			this.groupEndereco.Controls.Add(this.lblComplemento);
			this.groupEndereco.Controls.Add(this.txtBairro);
			this.groupEndereco.Controls.Add(this.lblCidade);
			this.groupEndereco.Controls.Add(this.txtNumero);
			this.groupEndereco.Controls.Add(this.txtComplemento);
			this.groupEndereco.Controls.Add(this.txtCidade);
			this.groupEndereco.Controls.Add(this.lblBairro);
			this.groupEndereco.Location = new System.Drawing.Point(17, 239);
			this.groupEndereco.Name = "groupEndereco";
			this.groupEndereco.Size = new System.Drawing.Size(729, 115);
			this.groupEndereco.TabIndex = 258;
			this.groupEndereco.TabStop = false;
			this.groupEndereco.Text = "Endereço";
			// 
			// maskedCEP
			// 
			this.maskedCEP.Location = new System.Drawing.Point(16, 39);
			this.maskedCEP.Mask = "00000-000";
			this.maskedCEP.Name = "maskedCEP";
			this.maskedCEP.Size = new System.Drawing.Size(73, 20);
			this.maskedCEP.TabIndex = 14;
			this.maskedCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.maskedCEP.Leave += new System.EventHandler(this.MaskedCEP_Leave);
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Location = new System.Drawing.Point(13, 23);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(28, 13);
			this.lblCep.TabIndex = 16;
			this.lblCep.Text = "CEP";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(439, 23);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(44, 13);
			this.lblNumero.TabIndex = 18;
			this.lblNumero.Text = "Número";
			// 
			// txtUF
			// 
			this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUF.Location = new System.Drawing.Point(282, 79);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(30, 20);
			this.txtUF.TabIndex = 95;
			this.txtUF.TabStop = false;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.AutoSize = true;
			this.lblLogradouro.Location = new System.Drawing.Point(101, 23);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
			this.lblLogradouro.TabIndex = 12;
			this.lblLogradouro.Text = "Logradouro";
			// 
			// txtLogradouro
			// 
			this.txtLogradouro.Location = new System.Drawing.Point(104, 39);
			this.txtLogradouro.Name = "txtLogradouro";
			this.txtLogradouro.Size = new System.Drawing.Size(332, 20);
			this.txtLogradouro.TabIndex = 99;
			this.txtLogradouro.TabStop = false;
			// 
			// lblUF
			// 
			this.lblUF.AutoSize = true;
			this.lblUF.Location = new System.Drawing.Point(279, 62);
			this.lblUF.Name = "lblUF";
			this.lblUF.Size = new System.Drawing.Size(21, 13);
			this.lblUF.TabIndex = 15;
			this.lblUF.Text = "UF";
			// 
			// lblComplemento
			// 
			this.lblComplemento.AutoSize = true;
			this.lblComplemento.Location = new System.Drawing.Point(518, 23);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(71, 13);
			this.lblComplemento.TabIndex = 17;
			this.lblComplemento.Text = "Complemento";
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(16, 78);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(73, 20);
			this.txtBairro.TabIndex = 96;
			this.txtBairro.TabStop = false;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(100, 62);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(40, 13);
			this.lblCidade.TabIndex = 14;
			this.lblCidade.Text = "Cidade";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(442, 39);
			this.txtNumero.MaxLength = 5;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(66, 20);
			this.txtNumero.TabIndex = 15;
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(521, 39);
			this.txtComplemento.MaxLength = 200;
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(202, 20);
			this.txtComplemento.TabIndex = 16;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(103, 78);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(173, 20);
			this.txtCidade.TabIndex = 97;
			this.txtCidade.TabStop = false;
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Location = new System.Drawing.Point(13, 62);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(34, 13);
			this.lblBairro.TabIndex = 13;
			this.lblBairro.Text = "Bairro";
			// 
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(296, 197);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 273;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// txtTelCel
			// 
			this.txtTelCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCel.HidePromptOnLeave = true;
			this.txtTelCel.Location = new System.Drawing.Point(227, 167);
			this.txtTelCel.Mask = "(00) 00000-0000";
			this.txtTelCel.Name = "txtTelCel";
			this.txtTelCel.Size = new System.Drawing.Size(94, 20);
			this.txtTelCel.TabIndex = 253;
			this.txtTelCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelCel
			// 
			this.lblTelCel.AutoSize = true;
			this.lblTelCel.Location = new System.Drawing.Point(224, 151);
			this.lblTelCel.Name = "lblTelCel";
			this.lblTelCel.Size = new System.Drawing.Size(70, 13);
			this.lblTelCel.TabIndex = 269;
			this.lblTelCel.Text = "Telefone Cel.";
			// 
			// txtProfissao
			// 
			this.txtProfissao.Location = new System.Drawing.Point(529, 88);
			this.txtProfissao.Name = "txtProfissao";
			this.txtProfissao.Size = new System.Drawing.Size(150, 20);
			this.txtProfissao.TabIndex = 247;
			// 
			// txtTelRes
			// 
			this.txtTelRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelRes.HidePromptOnLeave = true;
			this.txtTelRes.Location = new System.Drawing.Point(126, 167);
			this.txtTelRes.Mask = "(00) 0000-0000";
			this.txtTelRes.Name = "txtTelRes";
			this.txtTelRes.Size = new System.Drawing.Size(81, 20);
			this.txtTelRes.TabIndex = 252;
			this.txtTelRes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelRes
			// 
			this.lblTelRes.AutoSize = true;
			this.lblTelRes.Location = new System.Drawing.Point(123, 151);
			this.lblTelRes.Name = "lblTelRes";
			this.lblTelRes.Size = new System.Drawing.Size(74, 13);
			this.lblTelRes.TabIndex = 267;
			this.lblTelRes.Text = "Telefone Res.";
			// 
			// txtTelCom
			// 
			this.txtTelCom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtTelCom.HidePromptOnLeave = true;
			this.txtTelCom.Location = new System.Drawing.Point(33, 167);
			this.txtTelCom.Mask = "(00) 0000-0000";
			this.txtTelCom.Name = "txtTelCom";
			this.txtTelCom.Size = new System.Drawing.Size(81, 20);
			this.txtTelCom.TabIndex = 251;
			this.txtTelCom.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelCom
			// 
			this.lblTelCom.AutoSize = true;
			this.lblTelCom.Location = new System.Drawing.Point(30, 151);
			this.lblTelCom.Name = "lblTelCom";
			this.lblTelCom.Size = new System.Drawing.Size(76, 13);
			this.lblTelCom.TabIndex = 268;
			this.lblTelCom.Text = "Telefone Com.";
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(403, 197);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 271;
			this.lblValidade.Text = "Validade:";
			// 
			// lblProfissao
			// 
			this.lblProfissao.AutoSize = true;
			this.lblProfissao.Location = new System.Drawing.Point(529, 72);
			this.lblProfissao.Name = "lblProfissao";
			this.lblProfissao.Size = new System.Drawing.Size(50, 13);
			this.lblProfissao.TabIndex = 266;
			this.lblProfissao.Text = "Profissão";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(242, 197);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(55, 13);
			this.lblCategoria.TabIndex = 272;
			this.lblCategoria.Text = "Categoria:";
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(33, 213);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(205, 20);
			this.txtCNH.TabIndex = 254;
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(562, 111);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(104, 13);
			this.lblNascimento.TabIndex = 264;
			this.lblNascimento.Text = "Data de Nascimento";
			// 
			// lblCNH
			// 
			this.lblCNH.AutoSize = true;
			this.lblCNH.Location = new System.Drawing.Point(30, 197);
			this.lblCNH.Name = "lblCNH";
			this.lblCNH.Size = new System.Drawing.Size(88, 13);
			this.lblCNH.TabIndex = 270;
			this.lblCNH.Text = "Número da CNH:";
			// 
			// maskedCpf
			// 
			this.maskedCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedCpf.HidePromptOnLeave = true;
			this.maskedCpf.Location = new System.Drawing.Point(421, 88);
			this.maskedCpf.Mask = "000.000.000-00";
			this.maskedCpf.Name = "maskedCpf";
			this.maskedCpf.Size = new System.Drawing.Size(87, 20);
			this.maskedCpf.TabIndex = 246;
			this.maskedCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Location = new System.Drawing.Point(418, 72);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(27, 13);
			this.lblCpf.TabIndex = 265;
			this.lblCpf.Text = "CPF";
			// 
			// lblRG
			// 
			this.lblRG.AutoSize = true;
			this.lblRG.Location = new System.Drawing.Point(418, 111);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(23, 13);
			this.lblRG.TabIndex = 263;
			this.lblRG.Text = "RG";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(30, 111);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(36, 13);
			this.lblEmail.TabIndex = 262;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(30, 72);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 261;
			this.lblNome.Text = "Nome";
			// 
			// txtRG
			// 
			this.txtRG.AccessibleDescription = "Digite seu RG";
			this.txtRG.AccessibleName = "RG";
			this.txtRG.Location = new System.Drawing.Point(421, 127);
			this.txtRG.MaxLength = 9;
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(136, 20);
			this.txtRG.TabIndex = 249;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(33, 127);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(373, 20);
			this.txtEmail.TabIndex = 248;
			// 
			// txtNome
			// 
			this.txtNome.CausesValidation = false;
			this.txtNome.Location = new System.Drawing.Point(33, 88);
			this.txtNome.MaxLength = 200;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(373, 20);
			this.txtNome.TabIndex = 245;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(604, 409);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(136, 42);
			this.btnSalvar.TabIndex = 259;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
			// 
			// radioPessoaFisica
			// 
			this.radioPessoaFisica.AutoSize = true;
			this.radioPessoaFisica.Checked = true;
			this.radioPessoaFisica.Location = new System.Drawing.Point(272, 15);
			this.radioPessoaFisica.Name = "radioPessoaFisica";
			this.radioPessoaFisica.Size = new System.Drawing.Size(90, 17);
			this.radioPessoaFisica.TabIndex = 277;
			this.radioPessoaFisica.TabStop = true;
			this.radioPessoaFisica.Text = "Pessoa Fisica";
			this.radioPessoaFisica.UseVisualStyleBackColor = true;
			this.radioPessoaFisica.CheckedChanged += new System.EventHandler(this.RadioPessoaFisica_CheckedChanged);
			// 
			// radioPessoaJuridica
			// 
			this.radioPessoaJuridica.AutoSize = true;
			this.radioPessoaJuridica.Location = new System.Drawing.Point(375, 15);
			this.radioPessoaJuridica.Name = "radioPessoaJuridica";
			this.radioPessoaJuridica.Size = new System.Drawing.Size(99, 17);
			this.radioPessoaJuridica.TabIndex = 278;
			this.radioPessoaJuridica.Text = "Pessoa Juridica";
			this.radioPessoaJuridica.UseVisualStyleBackColor = true;
			this.radioPessoaJuridica.CheckedChanged += new System.EventHandler(this.RadioPessoaJuridica_CheckedChanged);
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.Location = new System.Drawing.Point(604, 361);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(136, 42);
			this.btnLocalizar.TabIndex = 279;
			this.btnLocalizar.Text = "Localizar...";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
			// 
			// FormCadastrarCliente
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(792, 480);
			this.ControlBox = false;
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.radioPessoaJuridica);
			this.Controls.Add(this.radioPessoaFisica);
			this.Controls.Add(this.dateCnhValidade);
			this.Controls.Add(this.dateCnhEmitida);
			this.Controls.Add(this.dateNascimento);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.checkAtivo);
			this.Controls.Add(this.groupEndereco);
			this.Controls.Add(this.lblEmitida);
			this.Controls.Add(this.txtTelCel);
			this.Controls.Add(this.lblTelCel);
			this.Controls.Add(this.txtProfissao);
			this.Controls.Add(this.txtTelRes);
			this.Controls.Add(this.lblTelRes);
			this.Controls.Add(this.txtTelCom);
			this.Controls.Add(this.lblTelCom);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.lblProfissao);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.txtCNH);
			this.Controls.Add(this.lblNascimento);
			this.Controls.Add(this.lblCNH);
			this.Controls.Add(this.maskedCpf);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblRG);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label17);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarCliente";
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.FormCadastrarCliente_Load);
			this.groupEndereco.ResumeLayout(false);
			this.groupEndereco.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.DateTimePicker dateCnhValidade;
		private System.Windows.Forms.DateTimePicker dateCnhEmitida;
		private System.Windows.Forms.DateTimePicker dateNascimento;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.ComboBox txtCategoria;
		private System.Windows.Forms.CheckBox checkAtivo;
		private System.Windows.Forms.GroupBox groupEndereco;
		private System.Windows.Forms.MaskedTextBox maskedCEP;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.TextBox txtLogradouro;
		private System.Windows.Forms.Label lblUF;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.MaskedTextBox txtTelCel;
		private System.Windows.Forms.Label lblTelCel;
		private System.Windows.Forms.TextBox txtProfissao;
		private System.Windows.Forms.MaskedTextBox txtTelRes;
		private System.Windows.Forms.Label lblTelRes;
		private System.Windows.Forms.MaskedTextBox txtTelCom;
		private System.Windows.Forms.Label lblTelCom;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.Label lblProfissao;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.TextBox txtCNH;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblCNH;
		private System.Windows.Forms.MaskedTextBox maskedCpf;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.RadioButton radioPessoaFisica;
		private System.Windows.Forms.RadioButton radioPessoaJuridica;
		private System.Windows.Forms.Button btnLocalizar;
	}
}