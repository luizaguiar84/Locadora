namespace Forms
{
	partial class FormSobre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
			this.LogoFat = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.LogoFat)).BeginInit();
			this.SuspendLayout();
			// 
			// LogoFat
			// 
			this.LogoFat.Image = ((System.Drawing.Image)(resources.GetObject("LogoFat.Image")));
			this.LogoFat.Location = new System.Drawing.Point(56, 12);
			this.LogoFat.Name = "LogoFat";
			this.LogoFat.Size = new System.Drawing.Size(100, 50);
			this.LogoFat.TabIndex = 0;
			this.LogoFat.TabStop = false;
			this.LogoFat.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "FatCars v 0.1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 252);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Todos os direitos reservados";
			// 
			// FormSobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(251, 288);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LogoFat);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormSobre";
			this.Text = "Sobre";
			this.Load += new System.EventHandler(this.FormSobre_Load);
			((System.ComponentModel.ISupportInitialize)(this.LogoFat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox LogoFat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}