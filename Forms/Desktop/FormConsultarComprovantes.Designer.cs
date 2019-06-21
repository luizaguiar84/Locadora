namespace Forms
{
	partial class FormConsultarComprovantes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarComprovantes));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.lblAte = new System.Windows.Forms.Label();
			this.lblDe = new System.Windows.Forms.Label();
			this.radioPersonalizado = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.radio60Dias = new System.Windows.Forms.RadioButton();
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.radio30Dias = new System.Windows.Forms.RadioButton();
			this.lblConsultarComprovantes = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnPesquisar);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.lblAte);
			this.groupBox1.Controls.Add(this.lblDe);
			this.groupBox1.Controls.Add(this.radioPersonalizado);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.radio60Dias);
			this.groupBox1.Controls.Add(this.lblPeriodo);
			this.groupBox1.Controls.Add(this.radio30Dias);
			this.groupBox1.Controls.Add(this.lblConsultarComprovantes);
			this.groupBox1.Location = new System.Drawing.Point(92, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 297);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(281, 240);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(105, 40);
			this.btnPesquisar.TabIndex = 18;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(248, 188);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(231, 20);
			this.dateTimePicker2.TabIndex = 17;
			// 
			// lblAte
			// 
			this.lblAte.AutoSize = true;
			this.lblAte.Location = new System.Drawing.Point(216, 195);
			this.lblAte.Name = "lblAte";
			this.lblAte.Size = new System.Drawing.Size(26, 13);
			this.lblAte.TabIndex = 16;
			this.lblAte.Text = "Até:";
			// 
			// lblDe
			// 
			this.lblDe.AutoSize = true;
			this.lblDe.Location = new System.Drawing.Point(216, 169);
			this.lblDe.Name = "lblDe";
			this.lblDe.Size = new System.Drawing.Size(24, 13);
			this.lblDe.TabIndex = 15;
			this.lblDe.Text = "De:";
			// 
			// radioPersonalizado
			// 
			this.radioPersonalizado.AutoSize = true;
			this.radioPersonalizado.Location = new System.Drawing.Point(248, 134);
			this.radioPersonalizado.Name = "radioPersonalizado";
			this.radioPersonalizado.Size = new System.Drawing.Size(94, 17);
			this.radioPersonalizado.TabIndex = 14;
			this.radioPersonalizado.TabStop = true;
			this.radioPersonalizado.Text = "Personalizado:";
			this.radioPersonalizado.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(248, 162);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// radio60Dias
			// 
			this.radio60Dias.AutoSize = true;
			this.radio60Dias.Location = new System.Drawing.Point(248, 111);
			this.radio60Dias.Name = "radio60Dias";
			this.radio60Dias.Size = new System.Drawing.Size(96, 17);
			this.radio60Dias.TabIndex = 12;
			this.radio60Dias.TabStop = true;
			this.radio60Dias.Text = "Ultimos 60 dias";
			this.radio60Dias.UseVisualStyleBackColor = true;
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.AutoSize = true;
			this.lblPeriodo.Location = new System.Drawing.Point(245, 61);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(141, 13);
			this.lblPeriodo.TabIndex = 11;
			this.lblPeriodo.Text = "Escolha o periodo desejado:";
			// 
			// radio30Dias
			// 
			this.radio30Dias.AutoSize = true;
			this.radio30Dias.Location = new System.Drawing.Point(248, 88);
			this.radio30Dias.Name = "radio30Dias";
			this.radio30Dias.Size = new System.Drawing.Size(96, 17);
			this.radio30Dias.TabIndex = 10;
			this.radio30Dias.TabStop = true;
			this.radio30Dias.Text = "Ultimos 30 dias";
			this.radio30Dias.UseVisualStyleBackColor = true;
			// 
			// lblConsultarComprovantes
			// 
			this.lblConsultarComprovantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblConsultarComprovantes.AutoSize = true;
			this.lblConsultarComprovantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsultarComprovantes.Location = new System.Drawing.Point(214, 16);
			this.lblConsultarComprovantes.Name = "lblConsultarComprovantes";
			this.lblConsultarComprovantes.Size = new System.Drawing.Size(249, 25);
			this.lblConsultarComprovantes.TabIndex = 9;
			this.lblConsultarComprovantes.Text = "Consultar Comprovantes";
			this.lblConsultarComprovantes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormConsultarComprovantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormConsultarComprovantes";
			this.Text = "Consultar Comprovantes";
			this.Load += new System.EventHandler(this.FormConsultarComprovantes_Load);
			this.Resize += new System.EventHandler(this.FormConsultarComprovantes_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label lblAte;
		private System.Windows.Forms.Label lblDe;
		private System.Windows.Forms.RadioButton radioPersonalizado;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton radio60Dias;
		private System.Windows.Forms.Label lblPeriodo;
		private System.Windows.Forms.RadioButton radio30Dias;
		private System.Windows.Forms.Label lblConsultarComprovantes;
		private System.Windows.Forms.Button btnPesquisar;
	}
}