namespace Dll_Forms_Fat
{
	partial class FormAddTipoDespesa
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
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.btnAddTipoDespesa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(24, 42);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(216, 20);
			this.txtTipo.TabIndex = 0;
			// 
			// btnAddTipoDespesa
			// 
			this.btnAddTipoDespesa.Location = new System.Drawing.Point(275, 39);
			this.btnAddTipoDespesa.Name = "btnAddTipoDespesa";
			this.btnAddTipoDespesa.Size = new System.Drawing.Size(75, 23);
			this.btnAddTipoDespesa.TabIndex = 1;
			this.btnAddTipoDespesa.Text = "Adicionar";
			this.btnAddTipoDespesa.UseVisualStyleBackColor = true;
			this.btnAddTipoDespesa.Click += new System.EventHandler(this.BtnAddTipoDespesa_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Adicionar novo tipo de despesa:";
			// 
			// FormAddTipoDespesa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 88);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddTipoDespesa);
			this.Controls.Add(this.txtTipo);
			this.Name = "FormAddTipoDespesa";
			this.Text = "Adicionar novo tipo de despesa";
			this.Load += new System.EventHandler(this.FormAddTipoDespesa_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.Button btnAddTipoDespesa;
		private System.Windows.Forms.Label label1;
	}
}