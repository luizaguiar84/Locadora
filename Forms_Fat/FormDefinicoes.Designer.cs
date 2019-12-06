namespace Dll_Forms_Fat
{
	partial class FormDefinicoes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefinicoes));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSegFurtoBatida = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSeguroTerceiros = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.comboCargos = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(94, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tabela de Preços";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seguro contra furto e batida";
			// 
			// txtSegFurtoBatida
			// 
			this.txtSegFurtoBatida.Location = new System.Drawing.Point(157, 49);
			this.txtSegFurtoBatida.Name = "txtSegFurtoBatida";
			this.txtSegFurtoBatida.Size = new System.Drawing.Size(100, 20);
			this.txtSegFurtoBatida.TabIndex = 2;
			this.txtSegFurtoBatida.TextChanged += new System.EventHandler(this.TxtSegFurtoBatida_TextChanged);
			this.txtSegFurtoBatida.Enter += new System.EventHandler(this.txtSegFurtoBatida_Enter);
			this.txtSegFurtoBatida.Leave += new System.EventHandler(this.txtSegFurtoBatida_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Seguro contra terceiros";
			// 
			// txtSeguroTerceiros
			// 
			this.txtSeguroTerceiros.Location = new System.Drawing.Point(157, 85);
			this.txtSeguroTerceiros.Name = "txtSeguroTerceiros";
			this.txtSeguroTerceiros.Size = new System.Drawing.Size(100, 20);
			this.txtSeguroTerceiros.TabIndex = 4;
			this.txtSeguroTerceiros.TextChanged += new System.EventHandler(this.txtSeguroTerceiros_TextChanged);
			this.txtSeguroTerceiros.Enter += new System.EventHandler(this.txtSeguroTerceiros_Enter);
			this.txtSeguroTerceiros.Leave += new System.EventHandler(this.txtSeguroTerceiros_Leave);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(197, 182);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(97, 48);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// comboCargos
			// 
			this.comboCargos.FormattingEnabled = true;
			this.comboCargos.Location = new System.Drawing.Point(154, 124);
			this.comboCargos.Name = "comboCargos";
			this.comboCargos.Size = new System.Drawing.Size(121, 21);
			this.comboCargos.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cargos";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(296, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Adicionar cargo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormDefinicoes
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 252);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboCargos);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtSeguroTerceiros);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSegFurtoBatida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormDefinicoes";
			this.Text = "Definições do sistema";
			this.Load += new System.EventHandler(this.FormTabelaDePrecos_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSegFurtoBatida;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSeguroTerceiros;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.ComboBox comboCargos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}