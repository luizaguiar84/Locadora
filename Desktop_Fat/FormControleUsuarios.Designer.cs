namespace Dll_Forms_Fat
{
	partial class FormControleUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleUsuarios));
			this.lblUsuario = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblCargo = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.ComboNivelAcesso = new System.Windows.Forms.ComboBox();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblConfirmaSenha = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNivelAcesso = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.comboCargo = new System.Windows.Forms.ComboBox();
			this.btnAdicionarUsuario = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkStatus = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtRegFuncionario = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(15, 9);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(46, 13);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuário:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(18, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(237, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(15, 102);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 8;
			this.lblNome.Text = "Nome";
			// 
			// txtConfirmaSenha
			// 
			this.txtConfirmaSenha.Location = new System.Drawing.Point(18, 275);
			this.txtConfirmaSenha.Name = "txtConfirmaSenha";
			this.txtConfirmaSenha.PasswordChar = '*';
			this.txtConfirmaSenha.Size = new System.Drawing.Size(266, 20);
			this.txtConfirmaSenha.TabIndex = 7;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(18, 236);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(266, 20);
			this.txtSenha.TabIndex = 6;
			// 
			// lblCargo
			// 
			this.lblCargo.AutoSize = true;
			this.lblCargo.Location = new System.Drawing.Point(15, 141);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(35, 13);
			this.lblCargo.TabIndex = 9;
			this.lblCargo.Text = "Cargo";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(18, 197);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(266, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// ComboNivelAcesso
			// 
			this.ComboNivelAcesso.FormattingEnabled = true;
			this.ComboNivelAcesso.Items.AddRange(new object[] {
            "Usuário",
            "Supervisor",
            "Administrador"});
			this.ComboNivelAcesso.Location = new System.Drawing.Point(163, 157);
			this.ComboNivelAcesso.Name = "ComboNivelAcesso";
			this.ComboNivelAcesso.Size = new System.Drawing.Size(121, 21);
			this.ComboNivelAcesso.TabIndex = 4;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.AutoSize = true;
			this.lblNomeUsuario.Location = new System.Drawing.Point(15, 181);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(89, 13);
			this.lblNomeUsuario.TabIndex = 1;
			this.lblNomeUsuario.Text = "Nome de Usuário";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(15, 220);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha";
			// 
			// lblConfirmaSenha
			// 
			this.lblConfirmaSenha.AutoSize = true;
			this.lblConfirmaSenha.Location = new System.Drawing.Point(15, 259);
			this.lblConfirmaSenha.Name = "lblConfirmaSenha";
			this.lblConfirmaSenha.Size = new System.Drawing.Size(85, 13);
			this.lblConfirmaSenha.TabIndex = 4;
			this.lblConfirmaSenha.Text = "Confirmar Senha";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(18, 118);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(266, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblNivelAcesso
			// 
			this.lblNivelAcesso.AutoSize = true;
			this.lblNivelAcesso.Location = new System.Drawing.Point(161, 141);
			this.lblNivelAcesso.Name = "lblNivelAcesso";
			this.lblNivelAcesso.Size = new System.Drawing.Size(85, 13);
			this.lblNivelAcesso.TabIndex = 10;
			this.lblNivelAcesso.Text = "Nível de acesso";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSalvar.Location = new System.Drawing.Point(93, 301);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(105, 40);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// comboCargo
			// 
			this.comboCargo.FormattingEnabled = true;
			this.comboCargo.Location = new System.Drawing.Point(18, 157);
			this.comboCargo.Name = "comboCargo";
			this.comboCargo.Size = new System.Drawing.Size(121, 21);
			this.comboCargo.TabIndex = 12;
			// 
			// btnAdicionarUsuario
			// 
			this.btnAdicionarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAdicionarUsuario.Location = new System.Drawing.Point(261, 25);
			this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
			this.btnAdicionarUsuario.Size = new System.Drawing.Size(23, 21);
			this.btnAdicionarUsuario.TabIndex = 13;
			this.btnAdicionarUsuario.Text = "+";
			this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
			this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkStatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblEmail);
			this.groupBox1.Controls.Add(this.txtRegFuncionario);
			this.groupBox1.Controls.Add(this.txtConfirmaSenha);
			this.groupBox1.Controls.Add(this.btnAdicionarUsuario);
			this.groupBox1.Controls.Add(this.comboCargo);
			this.groupBox1.Controls.Add(this.btnSalvar);
			this.groupBox1.Controls.Add(this.lblNivelAcesso);
			this.groupBox1.Controls.Add(this.lblNome);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.lblConfirmaSenha);
			this.groupBox1.Controls.Add(this.lblUsuario);
			this.groupBox1.Controls.Add(this.txtSenha);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.ComboNivelAcesso);
			this.groupBox1.Controls.Add(this.lblSenha);
			this.groupBox1.Controls.Add(this.lblNomeUsuario);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.lblCargo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(305, 360);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// checkStatus
			// 
			this.checkStatus.AutoSize = true;
			this.checkStatus.Location = new System.Drawing.Point(158, 83);
			this.checkStatus.Name = "checkStatus";
			this.checkStatus.Size = new System.Drawing.Size(50, 17);
			this.checkStatus.TabIndex = 17;
			this.checkStatus.Text = "Ativo";
			this.checkStatus.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Status:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(15, 65);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(119, 13);
			this.lblEmail.TabIndex = 15;
			this.lblEmail.Text = "Nº Registro Funcionário";
			// 
			// txtRegFuncionario
			// 
			this.txtRegFuncionario.Location = new System.Drawing.Point(18, 81);
			this.txtRegFuncionario.Name = "txtRegFuncionario";
			this.txtRegFuncionario.Size = new System.Drawing.Size(120, 20);
			this.txtRegFuncionario.TabIndex = 14;
			// 
			// FormControleUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 381);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControleUsuarios";
			this.Text = "Usuários";
			this.Load += new System.EventHandler(this.FormControleUsuarios_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtConfirmaSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.ComboBox ComboNivelAcesso;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblConfirmaSenha;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNivelAcesso;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.ComboBox comboCargo;
		private System.Windows.Forms.Button btnAdicionarUsuario;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtRegFuncionario;
		private System.Windows.Forms.CheckBox checkStatus;
	}
}