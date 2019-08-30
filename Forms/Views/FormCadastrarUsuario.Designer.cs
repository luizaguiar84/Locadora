namespace FatCars
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
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.lblCadastrarNovoUsuario = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblNivelAcesso = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.ComboNivelAcesso = new System.Windows.Forms.ComboBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
			this.comboCargo = new System.Windows.Forms.ComboBox();
			this.groupCadastro = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
			// TxtEmail
			// 
			this.TxtEmail.Location = new System.Drawing.Point(14, 64);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(120, 20);
			this.TxtEmail.TabIndex = 2;
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
			this.lblNivelAcesso.Location = new System.Drawing.Point(156, 126);
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
			// ComboNivelAcesso
			// 
			this.ComboNivelAcesso.FormattingEnabled = true;
			this.ComboNivelAcesso.Items.AddRange(new object[] {
            "Usuário",
            "Supervisor",
            "Administrador"});
			this.ComboNivelAcesso.Location = new System.Drawing.Point(159, 142);
			this.ComboNivelAcesso.Name = "ComboNivelAcesso";
			this.ComboNivelAcesso.Size = new System.Drawing.Size(121, 21);
			this.ComboNivelAcesso.TabIndex = 4;
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
			// comboCargo
			// 
			this.comboCargo.FormattingEnabled = true;
			this.comboCargo.Location = new System.Drawing.Point(14, 142);
			this.comboCargo.Name = "comboCargo";
			this.comboCargo.Size = new System.Drawing.Size(121, 21);
			this.comboCargo.TabIndex = 12;
			// 
			// groupCadastro
			// 
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
			this.groupCadastro.Controls.Add(this.ComboNivelAcesso);
			this.groupCadastro.Controls.Add(this.lblCadastrarNovoUsuario);
			this.groupCadastro.Controls.Add(this.txtNome);
			this.groupCadastro.Controls.Add(this.TxtEmail);
			this.groupCadastro.Controls.Add(this.lblNivelAcesso);
			this.groupCadastro.Controls.Add(this.comboCargo);
			this.groupCadastro.Location = new System.Drawing.Point(12, 12);
			this.groupCadastro.Name = "groupCadastro";
			this.groupCadastro.Size = new System.Drawing.Size(310, 344);
			this.groupCadastro.TabIndex = 13;
			this.groupCadastro.TabStop = false;
			// 
			// button2
			// 
			this.button2.AccessibleName = "Buscar Cliente";
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(140, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 20);
			this.button2.TabIndex = 273;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// FormCadastrarUsuario
			// 
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
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label lblCadastrarNovoUsuario;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Label lblNivelAcesso;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.ComboBox ComboNivelAcesso;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtConfirmaSenha;
		private System.Windows.Forms.GroupBox groupCadastro;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ComboBox comboCargo;
		private System.Windows.Forms.Button button2;
	}
}