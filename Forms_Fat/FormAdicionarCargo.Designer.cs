namespace Dll_Forms_Fat
{
	partial class FormAdicionarCargo
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
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtCargo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboNivel = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(133, 56);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 0;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtCargo
			// 
			this.txtCargo.Location = new System.Drawing.Point(55, 12);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.Size = new System.Drawing.Size(261, 20);
			this.txtCargo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cargo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(334, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nivel De Acesso:";
			// 
			// comboNivel
			// 
			this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboNivel.FormattingEnabled = true;
			this.comboNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.comboNivel.Location = new System.Drawing.Point(430, 13);
			this.comboNivel.Name = "comboNivel";
			this.comboNivel.Size = new System.Drawing.Size(47, 21);
			this.comboNivel.Sorted = true;
			this.comboNivel.TabIndex = 4;
			// 
			// FormAdicionarCargo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 101);
			this.Controls.Add(this.comboNivel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCargo);
			this.Controls.Add(this.btnSalvar);
			this.Name = "FormAdicionarCargo";
			this.Text = "Adicionar Cargo";
			this.Load += new System.EventHandler(this.FormAdicionarCargo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtCargo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboNivel;
	}
}