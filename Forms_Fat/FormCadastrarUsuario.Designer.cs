﻿namespace Dll_Forms_Fat
{
	partial class FormCadastrarUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblConfirmaSenha = new System.Windows.Forms.Label();
			this.txtRegistroFunc = new System.Windows.Forms.TextBox();
			this.lblCadastrarNovoUsuario = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblNivelAcesso = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.comboNivel = new System.Windows.Forms.ComboBox();
			this.txtCargo = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupCadastro.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSalvar.Location = new System.Drawing.Point(87, 287);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.AutoSize = true;
			this.lblNomeUsuario.Location = new System.Drawing.Point(12, 166);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(89, 13);
			this.lblNomeUsuario.TabIndex = 1;
			this.lblNomeUsuario.Text = "Nome de Usuário";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(14, 103);
			this.txtNome.Name = "txtNome";
			this.txtNome.ReadOnly = true;
			this.txtNome.Size = new System.Drawing.Size(266, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(13, 206);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha";
			// 
			// lblConfirmaSenha
			// 
			this.lblConfirmaSenha.AutoSize = true;
			this.lblConfirmaSenha.Location = new System.Drawing.Point(12, 245);
			this.lblConfirmaSenha.Name = "lblConfirmaSenha";
			this.lblConfirmaSenha.Size = new System.Drawing.Size(85, 13);
			this.lblConfirmaSenha.TabIndex = 4;
			this.lblConfirmaSenha.Text = "Confirmar Senha";
			// 
			// txtRegistroFunc
			// 
			this.txtRegistroFunc.Location = new System.Drawing.Point(14, 64);
			this.txtRegistroFunc.Name = "txtRegistroFunc";
			this.txtRegistroFunc.ReadOnly = true;
			this.txtRegistroFunc.Size = new System.Drawing.Size(120, 20);
			this.txtRegistroFunc.TabIndex = 2;
			// 
			// lblCadastrarNovoUsuario
			// 
			this.lblCadastrarNovoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCadastrarNovoUsuario.AutoSize = true;
			this.lblCadastrarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastrarNovoUsuario.Location = new System.Drawing.Point(28, 16);
			this.lblCadastrarNovoUsuario.Name = "lblCadastrarNovoUsuario";
			this.lblCadastrarNovoUsuario.Size = new System.Drawing.Size(242, 25);
			this.lblCadastrarNovoUsuario.TabIndex = 7;
			this.lblCadastrarNovoUsuario.Text = "Cadastrar Novo Usuário";
			this.lblCadastrarNovoUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(11, 87);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 8;
			this.lblNome.Text = "Nome";
			// 
			// lblCargo
			// 
			this.lblCargo.AutoSize = true;
			this.lblCargo.Location = new System.Drawing.Point(12, 126);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(35, 13);
			this.lblCargo.TabIndex = 9;
			this.lblCargo.Text = "Cargo";
			// 
			// lblNivelAcesso
			// 
			this.lblNivelAcesso.AutoSize = true;
			this.lblNivelAcesso.Location = new System.Drawing.Point(195, 126);
			this.lblNivelAcesso.Name = "lblNivelAcesso";
			this.lblNivelAcesso.Size = new System.Drawing.Size(85, 13);
			this.lblNivelAcesso.TabIndex = 10;
			this.lblNivelAcesso.Text = "Nível de acesso";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(11, 48);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(119, 13);
			this.lblEmail.TabIndex = 11;
			this.lblEmail.Text = "Nº Registro Funcionário";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(15, 182);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(266, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(14, 222);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(266, 20);
			this.txtSenha.TabIndex = 6;
			// 
			// txtConfirmaSenha
			// 
			this.txtConfirmaSenha.Location = new System.Drawing.Point(14, 261);
			this.txtConfirmaSenha.Name = "txtConfirmaSenha";
			this.txtConfirmaSenha.PasswordChar = '*';
			this.txtConfirmaSenha.Size = new System.Drawing.Size(266, 20);
			this.txtConfirmaSenha.TabIndex = 7;
			// 
			// groupCadastro
			// 
			this.groupCadastro.Controls.Add(this.comboNivel);
			this.groupCadastro.Controls.Add(this.txtCargo);
			this.groupCadastro.Controls.Add(this.button2);
			this.groupCadastro.Controls.Add(this.btnSalvar);
			this.groupCadastro.Controls.Add(this.txtConfirmaSenha);
			this.groupCadastro.Controls.Add(this.lblNome);
			this.groupCadastro.Controls.Add(this.lblConfirmaSenha);
			this.groupCadastro.Controls.Add(this.txtSenha);
			this.groupCadastro.Controls.Add(this.lblEmail);
			this.groupCadastro.Controls.Add(this.lblSenha);
			this.groupCadastro.Controls.Add(this.txtUsuario);
			this.groupCadastro.Controls.Add(this.lblCargo);
			this.groupCadastro.Controls.Add(this.lblNomeUsuario);
			this.groupCadastro.Controls.Add(this.lblCadastrarNovoUsuario);
			this.groupCadastro.Controls.Add(this.txtNome);
			this.groupCadastro.Controls.Add(this.txtRegistroFunc);
			this.groupCadastro.Controls.Add(this.lblNivelAcesso);
			this.groupCadastro.Location = new System.Drawing.Point(12, 12);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(310, 344);
			this.groupCadastro.TabIndex = 13;
			this.groupCadastro.TabStop = false;
			// 
			// comboNivel
			// 
			this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboNivel.FormattingEnabled = true;
			this.comboNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.comboNivel.Location = new System.Drawing.Point(226, 141);
			this.comboNivel.Name = "comboNivel";
			this.comboNivel.Size = new System.Drawing.Size(54, 21);
			this.comboNivel.TabIndex = 275;
			// 
			// txtCargo
			// 
			this.txtCargo.Location = new System.Drawing.Point(15, 143);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.ReadOnly = true;
			this.txtCargo.Size = new System.Drawing.Size(194, 20);
			this.txtCargo.TabIndex = 274;
			// 
			// button2
			// 
			this.button2.AccessibleName = "Buscar Cliente";
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(212, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 21);
			this.button2.TabIndex = 273;
			this.button2.Text = "Consultar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// FormCadastrarUsuario
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(343, 364);
			this.Controls.Add(this.groupCadastro);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarUsuario";
			this.Text = "Cadastrar Usuários";
			this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
			this.Enter += new System.EventHandler(this.FormCadastrarUsuario_Load);
			this.Resize += new System.EventHandler(this.FormCadastrarUsuario_Resize);
			this.groupCadastro.ResumeLayout(false);
			this.groupCadastro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblConfirmaSenha;
		private System.Windows.Forms.TextBox txtRegistroFunc;
		private System.Windows.Forms.Label lblCadastrarNovoUsuario;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Label lblNivelAcesso;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtConfirmaSenha;
		private System.Windows.Forms.GroupBox groupCadastro;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtCargo;
		private System.Windows.Forms.ComboBox comboNivel;
	}
}