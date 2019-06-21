namespace Forms
{
	partial class FormMonitoramentoVeiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitoramentoVeiculo));
			this.lblMonitoramento = new System.Windows.Forms.Label();
			this.lblSelecione = new System.Windows.Forms.Label();
			this.comboSelecao = new System.Windows.Forms.ComboBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMonitoramento
			// 
			this.lblMonitoramento.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblMonitoramento.AutoSize = true;
			this.lblMonitoramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonitoramento.Location = new System.Drawing.Point(277, 16);
			this.lblMonitoramento.Name = "lblMonitoramento";
			this.lblMonitoramento.Size = new System.Drawing.Size(273, 25);
			this.lblMonitoramento.TabIndex = 9;
			this.lblMonitoramento.Text = "Monitoramento de Veículos";
			this.lblMonitoramento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblSelecione
			// 
			this.lblSelecione.AutoSize = true;
			this.lblSelecione.Location = new System.Drawing.Point(25, 64);
			this.lblSelecione.Name = "lblSelecione";
			this.lblSelecione.Size = new System.Drawing.Size(101, 13);
			this.lblSelecione.TabIndex = 10;
			this.lblSelecione.Text = "Selecione o Veiculo";
			// 
			// comboSelecao
			// 
			this.comboSelecao.FormattingEnabled = true;
			this.comboSelecao.Location = new System.Drawing.Point(151, 61);
			this.comboSelecao.Name = "comboSelecao";
			this.comboSelecao.Size = new System.Drawing.Size(121, 21);
			this.comboSelecao.TabIndex = 11;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(63, 112);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(641, 287);
			this.webBrowser1.TabIndex = 12;
			this.webBrowser1.Url = new System.Uri("https://www.google.com.br/maps/place/UNIP-+Norte+Vila+Guilherme/@-23.5128757,-46." +
        "6118936,17z/data=!3m1!4b1!4m5!3m4!1s0x94ce58bcf5add8b5:0x7f4b742aebee617a!8m2!3d" +
        "-23.5128806!4d-46.6097049", System.UriKind.Absolute);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblMonitoramento);
			this.groupBox1.Controls.Add(this.webBrowser1);
			this.groupBox1.Controls.Add(this.lblSelecione);
			this.groupBox1.Controls.Add(this.comboSelecao);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 416);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// FormMonitoramentoVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMonitoramentoVeiculo";
			this.Text = "Monitoramento de Veiculos";
			this.Load += new System.EventHandler(this.FormMonitoramentoVeiculo_Load);
			this.Resize += new System.EventHandler(this.FormMonitoramentoVeiculo_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMonitoramento;
		private System.Windows.Forms.Label lblSelecione;
		private System.Windows.Forms.ComboBox comboSelecao;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}