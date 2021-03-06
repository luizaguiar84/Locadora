﻿using BsFat;

namespace Dll_Forms_Fat
{
	partial class FormControlePneus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlePneus));
			this.lblPlaca = new System.Windows.Forms.Label();
			this.comboPlaca = new System.Windows.Forms.ComboBox();
			this.lblData = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.dataGridPneus = new System.Windows.Forms.DataGridView();
			this.btnAddPneu = new System.Windows.Forms.Button();
			this.datePneu = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPneus)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(17, 9);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(34, 13);
			this.lblPlaca.TabIndex = 0;
			this.lblPlaca.Text = "Placa";
			// 
			// comboPlaca
			// 
			this.comboPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPlaca.FormattingEnabled = true;
			this.comboPlaca.Location = new System.Drawing.Point(20, 25);
			this.comboPlaca.Name = "comboPlaca";
			this.comboPlaca.Size = new System.Drawing.Size(121, 21);
			this.comboPlaca.TabIndex = 1;
			this.comboPlaca.SelectedIndexChanged += new System.EventHandler(this.ComboPlaca_SelectedIndexChanged);
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(213, 9);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(30, 13);
			this.lblData.TabIndex = 5;
			this.lblData.Text = "Data";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(20, 65);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(177, 20);
			this.txtMarca.TabIndex = 3;
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(17, 49);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(37, 13);
			this.lblMarca.TabIndex = 6;
			this.lblMarca.Text = "Marca";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(216, 65);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(173, 20);
			this.txtModelo.TabIndex = 4;
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(213, 49);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(42, 13);
			this.lblModelo.TabIndex = 8;
			this.lblModelo.Text = "Modelo";
			// 
			// dataGridPneus
			// 
			this.dataGridPneus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPneus.Location = new System.Drawing.Point(20, 108);
			this.dataGridPneus.Name = "dataGridPneus";
			this.dataGridPneus.Size = new System.Drawing.Size(550, 197);
			this.dataGridPneus.TabIndex = 12;
			// 
			// btnAddPneu
			// 
			this.btnAddPneu.Location = new System.Drawing.Point(414, 65);
			this.btnAddPneu.Name = "btnAddPneu";
			this.btnAddPneu.Size = new System.Drawing.Size(75, 23);
			this.btnAddPneu.TabIndex = 6;
			this.btnAddPneu.Text = "Adicionar";
			this.btnAddPneu.UseVisualStyleBackColor = true;
			this.btnAddPneu.Click += new System.EventHandler(this.BtnAddPneu_Click);
			// 
			// datePneu
			// 
			this.datePneu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePneu.Location = new System.Drawing.Point(216, 26);
			this.datePneu.Name = "datePneu";
			this.datePneu.Size = new System.Drawing.Size(96, 20);
			this.datePneu.TabIndex = 2;
			// 
			// FormControlePneus
			// 
			this.AcceptButton = this.btnAddPneu;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 363);
			this.ControlBox = false;
			this.Controls.Add(this.datePneu);
			this.Controls.Add(this.btnAddPneu);
			this.Controls.Add(this.dataGridPneus);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.comboPlaca);
			this.Controls.Add(this.lblPlaca);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlePneus";
			this.Text = "Controle de Pneus";
			this.Load += new System.EventHandler(this.FormControlePneus_Load);
			this.Enter += new System.EventHandler(this.FormControlePneus_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridPneus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.ComboBox comboPlaca;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.DataGridView dataGridPneus;
		private System.Windows.Forms.Button btnAddPneu;
		private System.Windows.Forms.DateTimePicker datePneu;
	}
}