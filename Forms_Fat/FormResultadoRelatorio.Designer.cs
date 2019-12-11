namespace Dll_Forms_Fat
{
	partial class FormResultadoRelatorio
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.lblTituloPag = new System.Windows.Forms.Label();
			this.lblInferior = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(2, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(795, 425);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(713, 514);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 1;
			this.btnVoltar.Text = "Voltar...";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// lblTituloPag
			// 
			this.lblTituloPag.AutoSize = true;
			this.lblTituloPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloPag.Location = new System.Drawing.Point(336, 9);
			this.lblTituloPag.Name = "lblTituloPag";
			this.lblTituloPag.Size = new System.Drawing.Size(70, 25);
			this.lblTituloPag.TabIndex = 2;
			this.lblTituloPag.Text = "label1";
			// 
			// lblInferior
			// 
			this.lblInferior.AutoSize = true;
			this.lblInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInferior.Location = new System.Drawing.Point(-2, 482);
			this.lblInferior.Name = "lblInferior";
			this.lblInferior.Size = new System.Drawing.Size(19, 20);
			this.lblInferior.TabIndex = 3;
			this.lblInferior.Text = "..";
			// 
			// FormResultadoRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 571);
			this.ControlBox = false;
			this.Controls.Add(this.lblInferior);
			this.Controls.Add(this.lblTituloPag);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormResultadoRelatorio";
			this.ShowIcon = false;
			this.Text = "+";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Label lblTituloPag;
		private System.Windows.Forms.Label lblInferior;
	}
}