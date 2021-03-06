﻿namespace Dll_Forms_Fat
{
	partial class FormRelatorios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorios));
			this.radioListagemVeiculos = new System.Windows.Forms.RadioButton();
			this.radioListagemClientes = new System.Windows.Forms.RadioButton();
			this.radioManutencoesGeral = new System.Windows.Forms.RadioButton();
			this.radioAbastecimentoGeral = new System.Windows.Forms.RadioButton();
			this.radioMultaPorMotorista = new System.Windows.Forms.RadioButton();
			this.radioListagemMotoristas = new System.Windows.Forms.RadioButton();
			this.radioListaManutencaoPorVeiculo = new System.Windows.Forms.RadioButton();
			this.radioMultasPorVeiculo = new System.Windows.Forms.RadioButton();
			this.groupRelatorios = new System.Windows.Forms.GroupBox();
			this.radioListagemEstoque = new System.Windows.Forms.RadioButton();
			this.radioSinistroVeiculo = new System.Windows.Forms.RadioButton();
			this.groupPlacas = new System.Windows.Forms.GroupBox();
			this.comboPlacas = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupPesquisaPeriodo = new System.Windows.Forms.GroupBox();
			this.dateFim = new System.Windows.Forms.DateTimePicker();
			this.dateInicio = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.brnConsultar = new System.Windows.Forms.Button();
			this.radioListaFuncionarios = new System.Windows.Forms.RadioButton();
			this.groupRelatorios.SuspendLayout();
			this.groupPlacas.SuspendLayout();
			this.groupPesquisaPeriodo.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioListagemVeiculos
			// 
			this.radioListagemVeiculos.AutoSize = true;
			this.radioListagemVeiculos.Location = new System.Drawing.Point(7, 16);
			this.radioListagemVeiculos.Name = "radioListagemVeiculos";
			this.radioListagemVeiculos.Size = new System.Drawing.Size(126, 17);
			this.radioListagemVeiculos.TabIndex = 0;
			this.radioListagemVeiculos.TabStop = true;
			this.radioListagemVeiculos.Text = "Listagem de veículos";
			this.radioListagemVeiculos.UseVisualStyleBackColor = true;
			// 
			// radioListagemClientes
			// 
			this.radioListagemClientes.AutoSize = true;
			this.radioListagemClientes.Location = new System.Drawing.Point(7, 80);
			this.radioListagemClientes.Name = "radioListagemClientes";
			this.radioListagemClientes.Size = new System.Drawing.Size(121, 17);
			this.radioListagemClientes.TabIndex = 2;
			this.radioListagemClientes.TabStop = true;
			this.radioListagemClientes.Text = "Listagem de clientes";
			this.radioListagemClientes.UseVisualStyleBackColor = true;
			this.radioListagemClientes.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
			// 
			// radioManutencoesGeral
			// 
			this.radioManutencoesGeral.AutoSize = true;
			this.radioManutencoesGeral.Location = new System.Drawing.Point(7, 217);
			this.radioManutencoesGeral.Name = "radioManutencoesGeral";
			this.radioManutencoesGeral.Size = new System.Drawing.Size(175, 17);
			this.radioManutencoesGeral.TabIndex = 9;
			this.radioManutencoesGeral.TabStop = true;
			this.radioManutencoesGeral.Text = "Listagem de manutenções geral";
			this.radioManutencoesGeral.UseVisualStyleBackColor = true;
			// 
			// radioAbastecimentoGeral
			// 
			this.radioAbastecimentoGeral.AutoSize = true;
			this.radioAbastecimentoGeral.Location = new System.Drawing.Point(7, 175);
			this.radioAbastecimentoGeral.Name = "radioAbastecimentoGeral";
			this.radioAbastecimentoGeral.Size = new System.Drawing.Size(180, 17);
			this.radioAbastecimentoGeral.TabIndex = 7;
			this.radioAbastecimentoGeral.TabStop = true;
			this.radioAbastecimentoGeral.Text = "Listagem de abastecimento geral";
			this.radioAbastecimentoGeral.UseVisualStyleBackColor = true;
			// 
			// radioMultaPorMotorista
			// 
			this.radioMultaPorMotorista.AutoSize = true;
			this.radioMultaPorMotorista.Location = new System.Drawing.Point(7, 152);
			this.radioMultaPorMotorista.Name = "radioMultaPorMotorista";
			this.radioMultaPorMotorista.Size = new System.Drawing.Size(178, 17);
			this.radioMultaPorMotorista.TabIndex = 6;
			this.radioMultaPorMotorista.TabStop = true;
			this.radioMultaPorMotorista.Text = "Listagem de multas por motorista";
			this.radioMultaPorMotorista.UseVisualStyleBackColor = true;
			// 
			// radioListagemMotoristas
			// 
			this.radioListagemMotoristas.AutoSize = true;
			this.radioListagemMotoristas.Location = new System.Drawing.Point(7, 37);
			this.radioListagemMotoristas.Name = "radioListagemMotoristas";
			this.radioListagemMotoristas.Size = new System.Drawing.Size(132, 17);
			this.radioListagemMotoristas.TabIndex = 1;
			this.radioListagemMotoristas.TabStop = true;
			this.radioListagemMotoristas.Text = "Listagem de motoristas";
			this.radioListagemMotoristas.UseVisualStyleBackColor = true;
			// 
			// radioListaManutencaoPorVeiculo
			// 
			this.radioListaManutencaoPorVeiculo.AutoSize = true;
			this.radioListaManutencaoPorVeiculo.Location = new System.Drawing.Point(7, 197);
			this.radioListaManutencaoPorVeiculo.Name = "radioListaManutencaoPorVeiculo";
			this.radioListaManutencaoPorVeiculo.Size = new System.Drawing.Size(206, 17);
			this.radioListaManutencaoPorVeiculo.TabIndex = 8;
			this.radioListaManutencaoPorVeiculo.TabStop = true;
			this.radioListaManutencaoPorVeiculo.Text = "Listagem de manutenções por veículo";
			this.radioListaManutencaoPorVeiculo.UseVisualStyleBackColor = true;
			// 
			// radioMultasPorVeiculo
			// 
			this.radioMultasPorVeiculo.AutoSize = true;
			this.radioMultasPorVeiculo.Location = new System.Drawing.Point(7, 103);
			this.radioMultasPorVeiculo.Name = "radioMultasPorVeiculo";
			this.radioMultasPorVeiculo.Size = new System.Drawing.Size(172, 17);
			this.radioMultasPorVeiculo.TabIndex = 3;
			this.radioMultasPorVeiculo.TabStop = true;
			this.radioMultasPorVeiculo.Text = "Listagem de multas por veículo";
			this.radioMultasPorVeiculo.UseVisualStyleBackColor = true;
			// 
			// groupRelatorios
			// 
			this.groupRelatorios.Controls.Add(this.radioListaFuncionarios);
			this.groupRelatorios.Controls.Add(this.radioListagemEstoque);
			this.groupRelatorios.Controls.Add(this.radioListagemVeiculos);
			this.groupRelatorios.Controls.Add(this.radioListaManutencaoPorVeiculo);
			this.groupRelatorios.Controls.Add(this.radioSinistroVeiculo);
			this.groupRelatorios.Controls.Add(this.radioManutencoesGeral);
			this.groupRelatorios.Controls.Add(this.radioListagemMotoristas);
			this.groupRelatorios.Controls.Add(this.radioMultasPorVeiculo);
			this.groupRelatorios.Controls.Add(this.radioMultaPorMotorista);
			this.groupRelatorios.Controls.Add(this.radioListagemClientes);
			this.groupRelatorios.Controls.Add(this.radioAbastecimentoGeral);
			this.groupRelatorios.Location = new System.Drawing.Point(12, 12);
			this.groupRelatorios.Name = "groupRelatorios";
			this.groupRelatorios.Size = new System.Drawing.Size(232, 279);
			this.groupRelatorios.TabIndex = 15;
			this.groupRelatorios.TabStop = false;
			this.groupRelatorios.Text = "Relatórios";
			// 
			// radioListagemEstoque
			// 
			this.radioListagemEstoque.AutoSize = true;
			this.radioListagemEstoque.Location = new System.Drawing.Point(7, 240);
			this.radioListagemEstoque.Name = "radioListagemEstoque";
			this.radioListagemEstoque.Size = new System.Drawing.Size(123, 17);
			this.radioListagemEstoque.TabIndex = 12;
			this.radioListagemEstoque.TabStop = true;
			this.radioListagemEstoque.Text = "Listagem de estoque";
			this.radioListagemEstoque.UseVisualStyleBackColor = true;
			// 
			// radioSinistroVeiculo
			// 
			this.radioSinistroVeiculo.AutoSize = true;
			this.radioSinistroVeiculo.Location = new System.Drawing.Point(7, 129);
			this.radioSinistroVeiculo.Name = "radioSinistroVeiculo";
			this.radioSinistroVeiculo.Size = new System.Drawing.Size(179, 17);
			this.radioSinistroVeiculo.TabIndex = 4;
			this.radioSinistroVeiculo.TabStop = true;
			this.radioSinistroVeiculo.Text = "Listagem de sinistros por veículo";
			this.radioSinistroVeiculo.UseVisualStyleBackColor = true;
			// 
			// groupPlacas
			// 
			this.groupPlacas.Controls.Add(this.comboPlacas);
			this.groupPlacas.Controls.Add(this.label1);
			this.groupPlacas.Location = new System.Drawing.Point(267, 12);
			this.groupPlacas.Name = "groupPlacas";
			this.groupPlacas.Size = new System.Drawing.Size(143, 74);
			this.groupPlacas.TabIndex = 18;
			this.groupPlacas.TabStop = false;
			this.groupPlacas.Text = "Pesquisa por placa:";
			// 
			// comboPlacas
			// 
			this.comboPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPlacas.FormattingEnabled = true;
			this.comboPlacas.Location = new System.Drawing.Point(9, 37);
			this.comboPlacas.Name = "comboPlacas";
			this.comboPlacas.Size = new System.Drawing.Size(121, 21);
			this.comboPlacas.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Placa:";
			// 
			// groupPesquisaPeriodo
			// 
			this.groupPesquisaPeriodo.Controls.Add(this.dateFim);
			this.groupPesquisaPeriodo.Controls.Add(this.dateInicio);
			this.groupPesquisaPeriodo.Controls.Add(this.label3);
			this.groupPesquisaPeriodo.Controls.Add(this.label2);
			this.groupPesquisaPeriodo.Location = new System.Drawing.Point(267, 167);
			this.groupPesquisaPeriodo.Name = "groupPesquisaPeriodo";
			this.groupPesquisaPeriodo.Size = new System.Drawing.Size(245, 109);
			this.groupPesquisaPeriodo.TabIndex = 19;
			this.groupPesquisaPeriodo.TabStop = false;
			this.groupPesquisaPeriodo.Text = "Pesquisa por período:";
			// 
			// dateFim
			// 
			this.dateFim.Location = new System.Drawing.Point(9, 77);
			this.dateFim.Name = "dateFim";
			this.dateFim.Size = new System.Drawing.Size(227, 20);
			this.dateFim.TabIndex = 3;
			// 
			// dateInicio
			// 
			this.dateInicio.Location = new System.Drawing.Point(9, 39);
			this.dateInicio.Name = "dateInicio";
			this.dateInicio.Size = new System.Drawing.Size(227, 20);
			this.dateInicio.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Até:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "De:";
			// 
			// brnConsultar
			// 
			this.brnConsultar.Location = new System.Drawing.Point(162, 309);
			this.brnConsultar.Name = "brnConsultar";
			this.brnConsultar.Size = new System.Drawing.Size(188, 37);
			this.brnConsultar.TabIndex = 22;
			this.brnConsultar.Text = "Consultar";
			this.brnConsultar.UseVisualStyleBackColor = true;
			this.brnConsultar.Click += new System.EventHandler(this.brnConsultar_Click);
			// 
			// radioListaFuncionarios
			// 
			this.radioListaFuncionarios.AutoSize = true;
			this.radioListaFuncionarios.Location = new System.Drawing.Point(7, 57);
			this.radioListaFuncionarios.Name = "radioListaFuncionarios";
			this.radioListaFuncionarios.Size = new System.Drawing.Size(127, 17);
			this.radioListaFuncionarios.TabIndex = 13;
			this.radioListaFuncionarios.TabStop = true;
			this.radioListaFuncionarios.Text = "ListagemFuncionários";
			this.radioListaFuncionarios.UseVisualStyleBackColor = true;
			// 
			// FormRelatorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 430);
			this.Controls.Add(this.brnConsultar);
			this.Controls.Add(this.groupPesquisaPeriodo);
			this.Controls.Add(this.groupPlacas);
			this.Controls.Add(this.groupRelatorios);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRelatorios";
			this.Text = "Relatórios";
			this.Load += new System.EventHandler(this.FormRelatorios_Load);
			this.groupRelatorios.ResumeLayout(false);
			this.groupRelatorios.PerformLayout();
			this.groupPlacas.ResumeLayout(false);
			this.groupPlacas.PerformLayout();
			this.groupPesquisaPeriodo.ResumeLayout(false);
			this.groupPesquisaPeriodo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioListagemVeiculos;
		private System.Windows.Forms.RadioButton radioListagemClientes;
		private System.Windows.Forms.RadioButton radioManutencoesGeral;
		private System.Windows.Forms.RadioButton radioAbastecimentoGeral;
		private System.Windows.Forms.RadioButton radioMultaPorMotorista;
		private System.Windows.Forms.RadioButton radioListagemMotoristas;
		private System.Windows.Forms.RadioButton radioListaManutencaoPorVeiculo;
		private System.Windows.Forms.RadioButton radioMultasPorVeiculo;
		private System.Windows.Forms.GroupBox groupRelatorios;
		private System.Windows.Forms.GroupBox groupPlacas;
		private System.Windows.Forms.ComboBox comboPlacas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupPesquisaPeriodo;
		private System.Windows.Forms.DateTimePicker dateFim;
		private System.Windows.Forms.DateTimePicker dateInicio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioSinistroVeiculo;
		private System.Windows.Forms.RadioButton radioListagemEstoque;
		private System.Windows.Forms.Button brnConsultar;
		private System.Windows.Forms.RadioButton radioListaFuncionarios;
	}
}