namespace Dll_Forms_Fat
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCnh = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblEmitida = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.dateEmitida = new System.Windows.Forms.DateTimePicker();
			this.dateValidade = new System.Windows.Forms.DateTimePicker();
			this.txtNomeMotorista = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
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
			// lblEmitida
			// 
			this.lblEmitida.AutoSize = true;
			this.lblEmitida.Location = new System.Drawing.Point(12, 98);
			this.lblEmitida.Name = "lblEmitida";
			this.lblEmitida.Size = new System.Drawing.Size(61, 13);
			this.lblEmitida.TabIndex = 244;
			this.lblEmitida.Text = "Emitida em:";
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(114, 98);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(51, 13);
			this.lblValidade.TabIndex = 242;
			this.lblValidade.Text = "Validade:";
			// 
			// dateEmitida
			// 
			this.dateEmitida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateEmitida.Location = new System.Drawing.Point(15, 115);
			this.dateEmitida.Name = "dateEmitida";
			this.dateEmitida.Size = new System.Drawing.Size(85, 20);
			this.dateEmitida.TabIndex = 247;
			// 
			// dateValidade
			// 
			this.dateValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateValidade.Location = new System.Drawing.Point(117, 114);
			this.dateValidade.Name = "dateValidade";
			this.dateValidade.Size = new System.Drawing.Size(85, 20);
			this.dateValidade.TabIndex = 248;
			// 
			// txtNomeMotorista
			// 
			this.txtNomeMotorista.Location = new System.Drawing.Point(12, 31);
			this.txtNomeMotorista.Name = "txtNomeMotorista";
			this.txtNomeMotorista.Size = new System.Drawing.Size(267, 20);
			this.txtNomeMotorista.TabIndex = 249;
			// 
			// FormCadastrarMotorista
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 213);
			this.Controls.Add(this.txtNomeMotorista);
			this.Controls.Add(this.dateValidade);
			this.Controls.Add(this.dateEmitida);
			this.Controls.Add(this.lblEmitida);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCnh);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCadastrarMotorista";
			this.Text = "Motoristas";
			this.Load += new System.EventHandler(this.FormCadastrarMotorista_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCnh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblEmitida;
		private System.Windows.Forms.Label lblValidade;
		private System.Windows.Forms.DateTimePicker dateEmitida;
		private System.Windows.Forms.DateTimePicker dateValidade;
		private System.Windows.Forms.TextBox txtNomeMotorista;
	}
}