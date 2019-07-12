namespace Forms
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.BtnLogin = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.TxtSenha = new System.Windows.Forms.TextBox();
			this.LinkEsqueciSenha = new System.Windows.Forms.LinkLabel();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.ImgLogoFat = new System.Windows.Forms.PictureBox();
			this.LayoutLogin = new System.Windows.Forms.TableLayoutPanel();
			this.LayoutBotoes = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.ImgLogoFat)).BeginInit();
			this.LayoutLogin.SuspendLayout();
			this.LayoutBotoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.Location = new System.Drawing.Point(133, 3);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(109, 23);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(3, 28);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(176, 20);
			this.txtUsuario.TabIndex = 1;
			// 
			// TxtSenha
			// 
			this.TxtSenha.Location = new System.Drawing.Point(3, 78);
			this.TxtSenha.Name = "TxtSenha";
			this.TxtSenha.Size = new System.Drawing.Size(176, 20);
			this.TxtSenha.TabIndex = 2;
			this.TxtSenha.UseSystemPasswordChar = true;
			// 
			// LinkEsqueciSenha
			// 
			this.LinkEsqueciSenha.AutoSize = true;
			this.LinkEsqueciSenha.Location = new System.Drawing.Point(103, 225);
			this.LinkEsqueciSenha.Name = "LinkEsqueciSenha";
			this.LinkEsqueciSenha.Size = new System.Drawing.Size(117, 13);
			this.LinkEsqueciSenha.TabIndex = 5;
			this.LinkEsqueciSenha.TabStop = true;
			this.LinkEsqueciSenha.Text = "Esqueci minha senha...";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(3, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(52, 16);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Usuário";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.Location = new System.Drawing.Point(3, 50);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(45, 16);
			this.lblSenha.TabIndex = 7;
			this.lblSenha.Text = "Senha";
			this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnSair
			// 
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(3, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(109, 23);
			this.btnSair.TabIndex = 4;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "Sair do sistema";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.button1_Click);
			// 
			// ImgLogoFat
			// 
			this.ImgLogoFat.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogoFat.Image")));
			this.ImgLogoFat.Location = new System.Drawing.Point(114, 12);
			this.ImgLogoFat.Name = "ImgLogoFat";
			this.ImgLogoFat.Size = new System.Drawing.Size(100, 50);
			this.ImgLogoFat.TabIndex = 8;
			this.ImgLogoFat.TabStop = false;
			// 
			// LayoutLogin
			// 
			this.LayoutLogin.ColumnCount = 1;
			this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutLogin.Controls.Add(this.txtUsuario, 0, 1);
			this.LayoutLogin.Controls.Add(this.lblUsuario, 0, 0);
			this.LayoutLogin.Controls.Add(this.lblSenha, 0, 2);
			this.LayoutLogin.Controls.Add(this.TxtSenha, 0, 3);
			this.LayoutLogin.Location = new System.Drawing.Point(67, 78);
			this.LayoutLogin.Name = "LayoutLogin";
			this.LayoutLogin.RowCount = 4;
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.LayoutLogin.Size = new System.Drawing.Size(200, 100);
			this.LayoutLogin.TabIndex = 1;
			// 
			// LayoutBotoes
			// 
			this.LayoutBotoes.ColumnCount = 2;
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutBotoes.Controls.Add(this.btnSair, 0, 0);
			this.LayoutBotoes.Controls.Add(this.BtnLogin, 1, 0);
			this.LayoutBotoes.Location = new System.Drawing.Point(45, 184);
			this.LayoutBotoes.Name = "LayoutBotoes";
			this.LayoutBotoes.RowCount = 1;
			this.LayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutBotoes.Size = new System.Drawing.Size(261, 38);
			this.LayoutBotoes.TabIndex = 10;
			// 
			// FormLogin
			// 
			this.AcceptButton = this.BtnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(342, 279);
			this.Controls.Add(this.LayoutBotoes);
			this.Controls.Add(this.LayoutLogin);
			this.Controls.Add(this.ImgLogoFat);
			this.Controls.Add(this.LinkEsqueciSenha);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.Text = "Dream Car\'s - Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing_1);
			this.Load += new System.EventHandler(this.Login_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.ImgLogoFat)).EndInit();
			this.LayoutLogin.ResumeLayout(false);
			this.LayoutLogin.PerformLayout();
			this.LayoutBotoes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox TxtSenha;
		private System.Windows.Forms.LinkLabel LinkEsqueciSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.PictureBox ImgLogoFat;
		private System.Windows.Forms.TableLayoutPanel LayoutLogin;
		private System.Windows.Forms.TableLayoutPanel LayoutBotoes;
	}
}