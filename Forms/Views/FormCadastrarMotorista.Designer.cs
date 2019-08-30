namespace FatCars.Desktop
{
	partial class FormCadastrarMotorista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarMotorista));
			this.btnAddMotorista = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCnh = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.maskedEmitida = new System.Windows.Forms.MaskedTextBox();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.maskedValidade = new System.Windows.Forms.MaskedTextBox();
			this.lblValidade = new System.Windows.Forms.Label();
			this.comboMotoristas = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAddMotorista
			// 
			this.btnAddMotorista.Location = new System.Drawing.Point(285, 30);
			this.btnAddMotorista.Name = "btnAddMotorista";
			this.btnAddMotorista.Size = new System.Drawing.Size(20, 21);
			this.btnAddMotorista.TabIndex = 0;
			this.btnAddMotorista.Text = "+";
			this.btnAddMotorista.UseVisualStyleBackColor = true;
			this.btnAddMotorista.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Motorista:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Número da CNH:";
			// 
			// txtCnh
			// 
			this.txtCnh.Location = new System.Drawing.Point(15, 70);
			this.txtCnh.Name = "txtCnh";
			this.txtCnh.Size = new System.Drawing.Size(219, 20);
			this.txtCnh.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(237, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Categoria:";
			// 
			// txtCategoria
			// 
			this.txtCategoria.Location = new System.Drawing.Point(240, 70);
			this.txtCategoria.MaxLength = 2;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(39, 20);
			this.txtCategoria.TabIndex = 7;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(127, 166);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 35);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.Button3_Click);
			// 
			// maskedEmitida
			// 
			this.maskedEmitida.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedEmitida.HidePromptOnLeave = true;
			this.maskedEmitida.Location = new System.Drawing.Point(15, 114);
			this.maskedEmitida.Mask = "00/00/0000";
			this.maskedEmitida.Name = "maskedEmitida";
			this.maskedEmitida.Size = new System.Drawing.Size(75, 20);
			this.maskedEmitida.TabIndex = 245;
			this.maskedEmitida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedEmitida.ValidatingType = typeof(System.DateTime);
			// 
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(12, 98);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 244;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// maskedValidade
			// 
			this.maskedValidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedValidade.HidePromptOnLeave = true;
			this.maskedValidade.Location = new System.Drawing.Point(99, 114);
			this.maskedValidade.Mask = "00/00/0000";
			this.maskedValidade.Name = "maskedValidade";
			this.maskedValidade.Size = new System.Drawing.Size(75, 20);
			this.maskedValidade.TabIndex = 243;
			this.maskedValidade.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.maskedValidade.ValidatingType = typeof(System.DateTime);
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(96, 98);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 242;
			this.lblValidade.Text = "Validade:";
			// 
			// comboMotoristas
			// 
			this.comboMotoristas.FormattingEnabled = true;
			this.comboMotoristas.Location = new System.Drawing.Point(15, 30);
			this.comboMotoristas.Name = "comboMotoristas";
			this.comboMotoristas.Size = new System.Drawing.Size(264, 21);
			this.comboMotoristas.TabIndex = 246;
			this.comboMotoristas.SelectedIndexChanged += new System.EventHandler(this.ComboMotoristas_SelectedIndexChanged);
			// 
			// FormCadastrarMotorista
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 213);
			this.Controls.Add(this.comboMotoristas);
			this.Controls.Add(this.maskedEmitida);
			this.Controls.Add(this.lblEmitida);
			this.Controls.Add(this.maskedValidade);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCnh);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddMotorista);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarMotorista";
			this.Text = "Motoristas";
			this.Load += new System.EventHandler(this.FormCadastrarMotorista_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddMotorista;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCnh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.MaskedTextBox maskedEmitida;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.MaskedTextBox maskedValidade;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.ComboBox comboMotoristas;
	}
}