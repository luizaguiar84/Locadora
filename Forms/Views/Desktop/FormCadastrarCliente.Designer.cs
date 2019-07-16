namespace Forms
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCadastro = new System.Windows.Forms.TabPage();
			this.lblId = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.ComboBox();
			this.checkAtivo = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
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
			this.maskedEmitida = new System.Windows.Forms.MaskedTextBox();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.txtTelCel = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCel = new System.Windows.Forms.Label();
			this.maskedValidade = new System.Windows.Forms.MaskedTextBox();
			this.txtProfissao = new System.Windows.Forms.TextBox();
			this.txtTelRes = new System.Windows.Forms.MaskedTextBox();
			this.lblTelRes = new System.Windows.Forms.Label();
			this.txtTelCom = new System.Windows.Forms.MaskedTextBox();
			this.lblTelCom = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.lblProfissao = new System.Windows.Forms.Label();
			this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.radioPj = new System.Windows.Forms.RadioButton();
			this.txtCNH = new System.Windows.Forms.TextBox();
			this.lblNascimento = new System.Windows.Forms.Label();
			this.lblCNH = new System.Windows.Forms.Label();
			this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
			this.radioPF = new System.Windows.Forms.RadioButton();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabMultas = new System.Windows.Forms.TabPage();
			this.maskedVencimentoMulta = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalvarMulta = new System.Windows.Forms.Button();
			this.comboPlaca = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNrPontos = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.maskedDataMulta = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabCadastro.SuspendLayout();
			this.groupEndereco.SuspendLayout();
			this.tabMultas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(325, 367);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(0, 13);
			this.label17.TabIndex = 24;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCadastro);
			this.tabControl1.Controls.Add(this.tabMultas);
			this.tabControl1.Location = new System.Drawing.Point(11, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(769, 448);
			this.tabControl1.TabIndex = 26;
			// 
			// tabCadastro
			// 
			this.tabCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabCadastro.Controls.Add(this.lblId);
			this.tabCadastro.Controls.Add(this.txtId);
			this.tabCadastro.Controls.Add(this.txtCategoria);
			this.tabCadastro.Controls.Add(this.checkAtivo);
			this.tabCadastro.Controls.Add(this.button2);
			this.tabCadastro.Controls.Add(this.groupEndereco);
			this.tabCadastro.Controls.Add(this.maskedEmitida);
			this.tabCadastro.Controls.Add(this.lblEmitida);
			this.tabCadastro.Controls.Add(this.txtTelCel);
			this.tabCadastro.Controls.Add(this.lblTelCel);
			this.tabCadastro.Controls.Add(this.maskedValidade);
			this.tabCadastro.Controls.Add(this.txtProfissao);
			this.tabCadastro.Controls.Add(this.txtTelRes);
			this.tabCadastro.Controls.Add(this.lblTelRes);
			this.tabCadastro.Controls.Add(this.txtTelCom);
			this.tabCadastro.Controls.Add(this.lblTelCom);
			this.tabCadastro.Controls.Add(this.lblValidade);
			this.tabCadastro.Controls.Add(this.lblProfissao);
			this.tabCadastro.Controls.Add(this.txtNascimento);
			this.tabCadastro.Controls.Add(this.lblCategoria);
			this.tabCadastro.Controls.Add(this.radioPj);
			this.tabCadastro.Controls.Add(this.txtCNH);
			this.tabCadastro.Controls.Add(this.lblNascimento);
			this.tabCadastro.Controls.Add(this.lblCNH);
			this.tabCadastro.Controls.Add(this.maskedCpf);
			this.tabCadastro.Controls.Add(this.radioPF);
			this.tabCadastro.Controls.Add(this.lblCpf);
			this.tabCadastro.Controls.Add(this.lblRG);
			this.tabCadastro.Controls.Add(this.lblEmail);
			this.tabCadastro.Controls.Add(this.lblNome);
			this.tabCadastro.Controls.Add(this.txtRG);
			this.tabCadastro.Controls.Add(this.txtEmail);
			this.tabCadastro.Controls.Add(this.txtNome);
			this.tabCadastro.Controls.Add(this.btnSalvar);
			this.tabCadastro.Location = new System.Drawing.Point(4, 22);
			this.tabCadastro.Name = "tabCadastro";
			this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastro.Size = new System.Drawing.Size(761, 422);
			this.tabCadastro.TabIndex = 0;
			this.tabCadastro.Text = "Informações do Cliente";
			this.tabCadastro.Click += new System.EventHandler(this.tabCadastro_Click);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(19, 42);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(56, 13);
			this.lblId.TabIndex = 244;
			this.lblId.Text = "Nr. Cliente";
			// 
			// txtId
			// 
			this.txtId.CausesValidation = false;
			this.txtId.Location = new System.Drawing.Point(22, 58);
			this.txtId.MaxLength = 200;
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(49, 20);
			this.txtId.TabIndex = 243;
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
			this.txtCategoria.Location = new System.Drawing.Point(233, 221);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(39, 21);
			this.txtCategoria.TabIndex = 242;
			// 
			// checkAtivo
			// 
			this.checkAtivo.AutoSize = true;
			this.checkAtivo.Checked = true;
			this.checkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkAtivo.Location = new System.Drawing.Point(312, 57);
			this.checkAtivo.Name = "checkAtivo";
			this.checkAtivo.Size = new System.Drawing.Size(85, 17);
			this.checkAtivo.TabIndex = 241;
			this.checkAtivo.Text = "Cliente Ativo";
			this.checkAtivo.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.AccessibleName = "Buscar Cliente";
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(364, 97);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 20);
			this.button2.TabIndex = 200;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
			this.groupEndereco.Location = new System.Drawing.Point(6, 248);
			this.groupEndereco.Name = "groupEndereco";
			this.groupEndereco.Size = new System.Drawing.Size(729, 115);
			this.groupEndereco.TabIndex = 14;
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
			this.maskedCEP.Leave += new System.EventHandler(this.maskedCEP_Leave_1);
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
			// maskedEmitida
			// 
			this.maskedEmitida.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedEmitida.HidePromptOnLeave = true;
			this.maskedEmitida.Location = new System.Drawing.Point(288, 222);
			this.maskedEmitida.Mask = "00/00/0000";
			this.maskedEmitida.Name = "maskedEmitida";
			this.maskedEmitida.Size = new System.Drawing.Size(75, 20);
			this.maskedEmitida.TabIndex = 12;
			this.maskedEmitida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedEmitida.ValidatingType = typeof(System.DateTime);
			this.maskedEmitida.Leave += new System.EventHandler(this.maskedEmitida_Leave);
			// 
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(285, 206);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 240;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// txtTelCel
			// 
			this.txtTelCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelCel.HidePromptOnLeave = true;
			this.txtTelCel.Location = new System.Drawing.Point(216, 176);
			this.txtTelCel.Mask = "(00) 00000-0000";
			this.txtTelCel.Name = "txtTelCel";
			this.txtTelCel.Size = new System.Drawing.Size(94, 20);
			this.txtTelCel.TabIndex = 9;
			this.txtTelCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelCel
			// 
			this.lblTelCel.AutoSize = true;
			this.lblTelCel.Location = new System.Drawing.Point(213, 160);
			this.lblTelCel.Name = "lblTelCel";
			this.lblTelCel.Size = new System.Drawing.Size(70, 13);
			this.lblTelCel.TabIndex = 231;
			this.lblTelCel.Text = "Telefone Cel.";
			// 
			// maskedValidade
			// 
			this.maskedValidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedValidade.HidePromptOnLeave = true;
			this.maskedValidade.Location = new System.Drawing.Point(372, 222);
			this.maskedValidade.Mask = "00/00/0000";
			this.maskedValidade.Name = "maskedValidade";
			this.maskedValidade.Size = new System.Drawing.Size(75, 20);
			this.maskedValidade.TabIndex = 13;
			this.maskedValidade.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedValidade.ValidatingType = typeof(System.DateTime);
			this.maskedValidade.Leave += new System.EventHandler(this.maskedValidade_Leave);
			// 
			// txtProfissao
			// 
			this.txtProfissao.Location = new System.Drawing.Point(518, 97);
			this.txtProfissao.Name = "txtProfissao";
			this.txtProfissao.Size = new System.Drawing.Size(150, 20);
			this.txtProfissao.TabIndex = 3;
			// 
			// txtTelRes
			// 
			this.txtTelRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtTelRes.HidePromptOnLeave = true;
			this.txtTelRes.Location = new System.Drawing.Point(115, 176);
			this.txtTelRes.Mask = "(00) 0000-0000";
			this.txtTelRes.Name = "txtTelRes";
			this.txtTelRes.Size = new System.Drawing.Size(81, 20);
			this.txtTelRes.TabIndex = 8;
			this.txtTelRes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelRes
			// 
			this.lblTelRes.AutoSize = true;
			this.lblTelRes.Location = new System.Drawing.Point(112, 160);
			this.lblTelRes.Name = "lblTelRes";
			this.lblTelRes.Size = new System.Drawing.Size(74, 13);
			this.lblTelRes.TabIndex = 229;
			this.lblTelRes.Text = "Telefone Res.";
			// 
			// txtTelCom
			// 
			this.txtTelCom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtTelCom.HidePromptOnLeave = true;
			this.txtTelCom.Location = new System.Drawing.Point(22, 176);
			this.txtTelCom.Mask = "(00) 0000-0000";
			this.txtTelCom.Name = "txtTelCom";
			this.txtTelCom.Size = new System.Drawing.Size(81, 20);
			this.txtTelCom.TabIndex = 7;
			this.txtTelCom.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lblTelCom
			// 
			this.lblTelCom.AutoSize = true;
			this.lblTelCom.Location = new System.Drawing.Point(19, 160);
			this.lblTelCom.Name = "lblTelCom";
			this.lblTelCom.Size = new System.Drawing.Size(76, 13);
			this.lblTelCom.TabIndex = 230;
			this.lblTelCom.Text = "Telefone Com.";
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(369, 206);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 236;
			this.lblValidade.Text = "Validade:";
			// 
			// lblProfissao
			// 
			this.lblProfissao.AutoSize = true;
			this.lblProfissao.Location = new System.Drawing.Point(518, 81);
			this.lblProfissao.Name = "lblProfissao";
			this.lblProfissao.Size = new System.Drawing.Size(50, 13);
			this.lblProfissao.TabIndex = 227;
			this.lblProfissao.Text = "Profissão";
			// 
			// txtNascimento
			// 
			this.txtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtNascimento.HidePromptOnLeave = true;
			this.txtNascimento.Location = new System.Drawing.Point(554, 136);
			this.txtNascimento.Mask = "00/00/0000";
			this.txtNascimento.Name = "txtNascimento";
			this.txtNascimento.Size = new System.Drawing.Size(71, 20);
			this.txtNascimento.TabIndex = 6;
			this.txtNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtNascimento.ValidatingType = typeof(System.DateTime);
			this.txtNascimento.Leave += new System.EventHandler(this.TxtNascimento_Leave);
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(231, 206);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(55, 13);
			this.lblCategoria.TabIndex = 238;
			this.lblCategoria.Text = "Categoria:";
			// 
			// radioPj
			// 
			this.radioPj.AutoSize = true;
			this.radioPj.Location = new System.Drawing.Point(405, 29);
			this.radioPj.Name = "radioPj";
			this.radioPj.Size = new System.Drawing.Size(101, 17);
			this.radioPj.TabIndex = 235;
			this.radioPj.Text = "Pessoa Jurídica";
			this.radioPj.UseVisualStyleBackColor = true;
			this.radioPj.CheckedChanged += new System.EventHandler(this.RadioPj_CheckedChanged_1);
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(22, 222);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(205, 20);
			this.txtCNH.TabIndex = 10;
			// 
			// lblNascimento
			// 
			this.lblNascimento.AutoSize = true;
			this.lblNascimento.Location = new System.Drawing.Point(551, 120);
			this.lblNascimento.Name = "lblNascimento";
			this.lblNascimento.Size = new System.Drawing.Size(104, 13);
			this.lblNascimento.TabIndex = 225;
			this.lblNascimento.Text = "Data de Nascimento";
			// 
			// lblCNH
			// 
			this.lblCNH.AutoSize = true;
			this.lblCNH.Location = new System.Drawing.Point(19, 206);
			this.lblCNH.Name = "lblCNH";
			this.lblCNH.Size = new System.Drawing.Size(88, 13);
			this.lblCNH.TabIndex = 232;
			this.lblCNH.Text = "Número da CNH:";
			// 
			// maskedCpf
			// 
			this.maskedCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedCpf.HidePromptOnLeave = true;
			this.maskedCpf.Location = new System.Drawing.Point(410, 97);
			this.maskedCpf.Mask = "000.000.000-00";
			this.maskedCpf.Name = "maskedCpf";
			this.maskedCpf.Size = new System.Drawing.Size(87, 20);
			this.maskedCpf.TabIndex = 2;
			this.maskedCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// radioPF
			// 
			this.radioPF.AutoSize = true;
			this.radioPF.Checked = true;
			this.radioPF.Location = new System.Drawing.Point(190, 29);
			this.radioPF.Name = "radioPF";
			this.radioPF.Size = new System.Drawing.Size(92, 17);
			this.radioPF.TabIndex = 234;
			this.radioPF.TabStop = true;
			this.radioPF.Text = "Pessoa Física";
			this.radioPF.UseVisualStyleBackColor = true;
			this.radioPF.CheckedChanged += new System.EventHandler(this.RadioPF_CheckedChanged_1);
			// 
			// lblCpf
			// 
			this.lblCpf.AutoSize = true;
			this.lblCpf.Location = new System.Drawing.Point(407, 81);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(27, 13);
			this.lblCpf.TabIndex = 226;
			this.lblCpf.Text = "CPF";
			// 
			// lblRG
			// 
			this.lblRG.AutoSize = true;
			this.lblRG.Location = new System.Drawing.Point(407, 120);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(23, 13);
			this.lblRG.TabIndex = 222;
			this.lblRG.Text = "RG";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(19, 120);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(36, 13);
			this.lblEmail.TabIndex = 220;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(19, 81);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 218;
			this.lblNome.Text = "Nome";
			// 
			// txtRG
			// 
			this.txtRG.AccessibleDescription = "Digite seu RG";
			this.txtRG.AccessibleName = "RG";
			this.txtRG.Location = new System.Drawing.Point(410, 136);
			this.txtRG.MaxLength = 9;
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(136, 20);
			this.txtRG.TabIndex = 5;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(22, 136);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(373, 20);
			this.txtEmail.TabIndex = 4;
			// 
			// txtNome
			// 
			this.txtNome.CausesValidation = false;
			this.txtNome.Location = new System.Drawing.Point(22, 97);
			this.txtNome.MaxLength = 200;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(332, 20);
			this.txtNome.TabIndex = 1;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(599, 369);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(136, 42);
			this.btnSalvar.TabIndex = 17;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
			// 
			// tabMultas
			// 
			this.tabMultas.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabMultas.Controls.Add(this.maskedVencimentoMulta);
			this.tabMultas.Controls.Add(this.label1);
			this.tabMultas.Controls.Add(this.dataGridView1);
			this.tabMultas.Controls.Add(this.btnSalvarMulta);
			this.tabMultas.Controls.Add(this.comboPlaca);
			this.tabMultas.Controls.Add(this.label7);
			this.tabMultas.Controls.Add(this.label6);
			this.tabMultas.Controls.Add(this.txtNrPontos);
			this.tabMultas.Controls.Add(this.label5);
			this.tabMultas.Controls.Add(this.txtValor);
			this.tabMultas.Controls.Add(this.txtDescricao);
			this.tabMultas.Controls.Add(this.label4);
			this.tabMultas.Controls.Add(this.maskedDataMulta);
			this.tabMultas.Controls.Add(this.label3);
			this.tabMultas.Location = new System.Drawing.Point(4, 22);
			this.tabMultas.Name = "tabMultas";
			this.tabMultas.Padding = new System.Windows.Forms.Padding(3);
			this.tabMultas.Size = new System.Drawing.Size(761, 422);
			this.tabMultas.TabIndex = 1;
			this.tabMultas.Text = "Adição de multas";
			// 
			// maskedVencimentoMulta
			// 
			this.maskedVencimentoMulta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedVencimentoMulta.HidePromptOnLeave = true;
			this.maskedVencimentoMulta.Location = new System.Drawing.Point(3, 76);
			this.maskedVencimentoMulta.Mask = "00/00/0000";
			this.maskedVencimentoMulta.Name = "maskedVencimentoMulta";
			this.maskedVencimentoMulta.Size = new System.Drawing.Size(100, 20);
			this.maskedVencimentoMulta.TabIndex = 11;
			this.maskedVencimentoMulta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedVencimentoMulta.ValidatingType = typeof(System.DateTime);
			this.maskedVencimentoMulta.Leave += new System.EventHandler(this.maskedVencimentoMulta_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Data de vencimento:";
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
			this.dataGridView1.Location = new System.Drawing.Point(3, 118);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(744, 271);
			this.dataGridView1.TabIndex = 7;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Data";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Descrição";
			this.Column2.Name = "Column2";
			this.Column2.Width = 200;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Valor";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Pontos";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Placa";
			this.Column5.Name = "Column5";
			// 
			// btnSalvarMulta
			// 
			this.btnSalvarMulta.Location = new System.Drawing.Point(479, 72);
			this.btnSalvarMulta.Name = "btnSalvarMulta";
			this.btnSalvarMulta.Size = new System.Drawing.Size(98, 23);
			this.btnSalvarMulta.TabIndex = 6;
			this.btnSalvarMulta.Text = "Gravar Multa";
			this.btnSalvarMulta.UseVisualStyleBackColor = true;
			this.btnSalvarMulta.Click += new System.EventHandler(this.btnSalvarMulta_Click);
			// 
			// comboPlaca
			// 
			this.comboPlaca.FormattingEnabled = true;
			this.comboPlaca.Location = new System.Drawing.Point(333, 76);
			this.comboPlaca.Name = "comboPlaca";
			this.comboPlaca.Size = new System.Drawing.Size(121, 21);
			this.comboPlaca.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(330, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Veículo Placa:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(252, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Nr. de pontos:";
			// 
			// txtNrPontos
			// 
			this.txtNrPontos.Location = new System.Drawing.Point(255, 76);
			this.txtNrPontos.Name = "txtNrPontos";
			this.txtNrPontos.Size = new System.Drawing.Size(69, 20);
			this.txtNrPontos.TabIndex = 4;
			this.txtNrPontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrPontos_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(126, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Valor:";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(129, 76);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 20);
			this.txtValor.TabIndex = 3;
			this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
			this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
			this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(129, 37);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(602, 20);
			this.txtDescricao.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(126, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Descrição da multa:";
			// 
			// maskedDataMulta
			// 
			this.maskedDataMulta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataMulta.HidePromptOnLeave = true;
			this.maskedDataMulta.Location = new System.Drawing.Point(3, 37);
			this.maskedDataMulta.Mask = "00/00/0000";
			this.maskedDataMulta.Name = "maskedDataMulta";
			this.maskedDataMulta.Size = new System.Drawing.Size(100, 20);
			this.maskedDataMulta.TabIndex = 1;
			this.maskedDataMulta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedDataMulta.ValidatingType = typeof(System.DateTime);
			this.maskedDataMulta.Leave += new System.EventHandler(this.maskedDataMulta_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Data da multa:";
			// 
			// FormCadastrarCliente
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(792, 480);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label17);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarCliente";
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.FormCadastrarCliente_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabCadastro.ResumeLayout(false);
			this.tabCadastro.PerformLayout();
			this.groupEndereco.ResumeLayout(false);
			this.groupEndereco.PerformLayout();
			this.tabMultas.ResumeLayout(false);
			this.tabMultas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabCadastro;
		private System.Windows.Forms.TabPage tabMultas;
		private System.Windows.Forms.Button btnSalvarMulta;
		private System.Windows.Forms.ComboBox comboPlaca;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNrPontos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedDataMulta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupEndereco;
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
		private System.Windows.Forms.MaskedTextBox maskedEmitida;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.MaskedTextBox txtTelCel;
		private System.Windows.Forms.Label lblTelCel;
		private System.Windows.Forms.MaskedTextBox maskedValidade;
		private System.Windows.Forms.TextBox txtProfissao;
		private System.Windows.Forms.MaskedTextBox txtTelRes;
		private System.Windows.Forms.Label lblTelRes;
		private System.Windows.Forms.MaskedTextBox txtTelCom;
		private System.Windows.Forms.Label lblTelCom;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.Label lblProfissao;
		private System.Windows.Forms.MaskedTextBox txtNascimento;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.RadioButton radioPj;
		private System.Windows.Forms.TextBox txtCNH;
		private System.Windows.Forms.Label lblNascimento;
		private System.Windows.Forms.Label lblCNH;
		private System.Windows.Forms.MaskedTextBox maskedCpf;
		private System.Windows.Forms.RadioButton radioPF;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.MaskedTextBox maskedCEP;
		private System.Windows.Forms.MaskedTextBox maskedVencimentoMulta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkAtivo;
		private System.Windows.Forms.ComboBox txtCategoria;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtId;
	}
}