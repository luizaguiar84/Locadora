namespace Forms.Views.Desktop
{
	partial class FormControlePatio
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlePatio));
			this.label2 = new System.Windows.Forms.Label();
			this.groupSaida = new System.Windows.Forms.GroupBox();
			this.dateTimeSaida = new System.Windows.Forms.DateTimePicker();
			this.brnSalvarSaida = new System.Windows.Forms.Button();
			this.comboCombustivelSaida = new System.Windows.Forms.ComboBox();
			this.comboLiberadoSaida = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKmSaida = new System.Windows.Forms.TextBox();
			this.groupRetorno = new System.Windows.Forms.GroupBox();
			this.comboCarrosForaPlaca = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dateTimeRetorno = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.comboCombustivelRetorno = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.comboRecolhido = new System.Windows.Forms.ComboBox();
			this.btnSalvarRetorno = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.comboEstadoRetorno = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtkmRetorno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupVeicFora = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaidaPatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupRegistro = new System.Windows.Forms.GroupBox();
			this.btnAddCarro = new System.Windows.Forms.Button();
			this.btnAddMotorista = new System.Windows.Forms.Button();
			this.txtVeiculo = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboMotorista = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboCarros = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.controlePatioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.veiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.groupSaida.SuspendLayout();
			this.groupRetorno.SuspendLayout();
			this.groupVeicFora.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupRegistro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlePatioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Data e hora:";
			// 
			// groupSaida
			// 
			this.groupSaida.Controls.Add(this.dateTimeSaida);
			this.groupSaida.Controls.Add(this.brnSalvarSaida);
			this.groupSaida.Controls.Add(this.comboCombustivelSaida);
			this.groupSaida.Controls.Add(this.comboLiberadoSaida);
			this.groupSaida.Controls.Add(this.label23);
			this.groupSaida.Controls.Add(this.label4);
			this.groupSaida.Controls.Add(this.txtObservacoes);
			this.groupSaida.Controls.Add(this.label3);
			this.groupSaida.Controls.Add(this.label1);
			this.groupSaida.Controls.Add(this.txtKmSaida);
			this.groupSaida.Controls.Add(this.label2);
			this.groupSaida.Location = new System.Drawing.Point(12, 209);
			this.groupSaida.Name = "groupSaida";
			this.groupSaida.Size = new System.Drawing.Size(361, 284);
			this.groupSaida.TabIndex = 4;
			this.groupSaida.TabStop = false;
			this.groupSaida.Text = "Registro de Saída do pátio";
			// 
			// dateTimeSaida
			// 
			this.dateTimeSaida.Location = new System.Drawing.Point(9, 39);
			this.dateTimeSaida.Name = "dateTimeSaida";
			this.dateTimeSaida.Size = new System.Drawing.Size(228, 20);
			this.dateTimeSaida.TabIndex = 9;
			// 
			// brnSalvarSaida
			// 
			this.brnSalvarSaida.Location = new System.Drawing.Point(118, 229);
			this.brnSalvarSaida.Name = "brnSalvarSaida";
			this.brnSalvarSaida.Size = new System.Drawing.Size(110, 43);
			this.brnSalvarSaida.TabIndex = 9;
			this.brnSalvarSaida.Text = "Registrar Saida";
			this.brnSalvarSaida.UseVisualStyleBackColor = true;
			this.brnSalvarSaida.Click += new System.EventHandler(this.brnSalvarSaida_Click);
			// 
			// comboCombustivelSaida
			// 
			this.comboCombustivelSaida.FormattingEnabled = true;
			this.comboCombustivelSaida.Items.AddRange(new object[] {
            "Cheio",
            "3/4",
            "1/2",
            "1/4",
            "Reserva"});
			this.comboCombustivelSaida.Location = new System.Drawing.Point(9, 81);
			this.comboCombustivelSaida.Name = "comboCombustivelSaida";
			this.comboCombustivelSaida.Size = new System.Drawing.Size(121, 21);
			this.comboCombustivelSaida.TabIndex = 40;
			// 
			// comboLiberadoSaida
			// 
			this.comboLiberadoSaida.FormattingEnabled = true;
			this.comboLiberadoSaida.Location = new System.Drawing.Point(9, 118);
			this.comboLiberadoSaida.Name = "comboLiberadoSaida";
			this.comboLiberadoSaida.Size = new System.Drawing.Size(332, 21);
			this.comboLiberadoSaida.TabIndex = 20;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(6, 66);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(110, 13);
			this.label23.TabIndex = 39;
			this.label23.Text = "Nivel de combustível:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Observações:";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(9, 159);
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(332, 64);
			this.txtObservacoes.TabIndex = 8;
			this.txtObservacoes.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Liberado por:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(243, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Km do carro:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtKmSaida
			// 
			this.txtKmSaida.Location = new System.Drawing.Point(246, 42);
			this.txtKmSaida.MaxLength = 8;
			this.txtKmSaida.Name = "txtKmSaida";
			this.txtKmSaida.Size = new System.Drawing.Size(95, 20);
			this.txtKmSaida.TabIndex = 4;
			this.txtKmSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmSaida_KeyPress);
			// 
			// groupRetorno
			// 
			this.groupRetorno.Controls.Add(this.comboCarrosForaPlaca);
			this.groupRetorno.Controls.Add(this.label10);
			this.groupRetorno.Controls.Add(this.dateTimeRetorno);
			this.groupRetorno.Controls.Add(this.label6);
			this.groupRetorno.Controls.Add(this.comboCombustivelRetorno);
			this.groupRetorno.Controls.Add(this.label15);
			this.groupRetorno.Controls.Add(this.comboRecolhido);
			this.groupRetorno.Controls.Add(this.btnSalvarRetorno);
			this.groupRetorno.Controls.Add(this.label9);
			this.groupRetorno.Controls.Add(this.comboEstadoRetorno);
			this.groupRetorno.Controls.Add(this.label7);
			this.groupRetorno.Controls.Add(this.txtkmRetorno);
			this.groupRetorno.Controls.Add(this.label5);
			this.groupRetorno.Location = new System.Drawing.Point(379, 209);
			this.groupRetorno.Name = "groupRetorno";
			this.groupRetorno.Size = new System.Drawing.Size(341, 284);
			this.groupRetorno.TabIndex = 5;
			this.groupRetorno.TabStop = false;
			this.groupRetorno.Text = "Registro de retorno ao pátio";
			// 
			// comboCarrosForaPlaca
			// 
			this.comboCarrosForaPlaca.FormattingEnabled = true;
			this.comboCarrosForaPlaca.Location = new System.Drawing.Point(9, 31);
			this.comboCarrosForaPlaca.Name = "comboCarrosForaPlaca";
			this.comboCarrosForaPlaca.Size = new System.Drawing.Size(121, 21);
			this.comboCarrosForaPlaca.TabIndex = 21;
			this.comboCarrosForaPlaca.SelectedIndexChanged += new System.EventHandler(this.comboCarrosForaPlaca_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "Placa:";
			// 
			// dateTimeRetorno
			// 
			this.dateTimeRetorno.Location = new System.Drawing.Point(9, 71);
			this.dateTimeRetorno.Name = "dateTimeRetorno";
			this.dateTimeRetorno.Size = new System.Drawing.Size(226, 20);
			this.dateTimeRetorno.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Data e hora:";
			// 
			// comboCombustivelRetorno
			// 
			this.comboCombustivelRetorno.FormattingEnabled = true;
			this.comboCombustivelRetorno.Items.AddRange(new object[] {
            "Cheio",
            "3/4",
            "1/2",
            "1/4",
            "Reserva"});
			this.comboCombustivelRetorno.Location = new System.Drawing.Point(6, 109);
			this.comboCombustivelRetorno.Name = "comboCombustivelRetorno";
			this.comboCombustivelRetorno.Size = new System.Drawing.Size(121, 21);
			this.comboCombustivelRetorno.TabIndex = 40;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 94);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 13);
			this.label15.TabIndex = 39;
			this.label15.Text = "Nivel de combustível:";
			// 
			// comboRecolhido
			// 
			this.comboRecolhido.FormattingEnabled = true;
			this.comboRecolhido.Location = new System.Drawing.Point(9, 149);
			this.comboRecolhido.Name = "comboRecolhido";
			this.comboRecolhido.Size = new System.Drawing.Size(323, 21);
			this.comboRecolhido.TabIndex = 21;
			// 
			// btnSalvarRetorno
			// 
			this.btnSalvarRetorno.Location = new System.Drawing.Point(125, 229);
			this.btnSalvarRetorno.Name = "btnSalvarRetorno";
			this.btnSalvarRetorno.Size = new System.Drawing.Size(110, 43);
			this.btnSalvarRetorno.TabIndex = 6;
			this.btnSalvarRetorno.Text = "Registrar Retorno";
			this.btnSalvarRetorno.UseVisualStyleBackColor = true;
			this.btnSalvarRetorno.Click += new System.EventHandler(this.btnSalvarRetorno_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 133);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Recolhido por:";
			// 
			// comboEstadoRetorno
			// 
			this.comboEstadoRetorno.AutoCompleteCustomSource.AddRange(new string[] {
            "SEM INCIDENTES",
            "ACIDENTADO"});
			this.comboEstadoRetorno.FormattingEnabled = true;
			this.comboEstadoRetorno.Location = new System.Drawing.Point(240, 71);
			this.comboEstadoRetorno.Name = "comboEstadoRetorno";
			this.comboEstadoRetorno.Size = new System.Drawing.Size(92, 21);
			this.comboEstadoRetorno.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(237, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Estado:";
			// 
			// txtkmRetorno
			// 
			this.txtkmRetorno.Location = new System.Drawing.Point(208, 110);
			this.txtkmRetorno.MaxLength = 8;
			this.txtkmRetorno.Name = "txtkmRetorno";
			this.txtkmRetorno.Size = new System.Drawing.Size(121, 20);
			this.txtkmRetorno.TabIndex = 10;
			this.txtkmRetorno.TextChanged += new System.EventHandler(this.txtkmRetorno_TextChanged);
			this.txtkmRetorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkmRetorno_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(205, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Km no retorno:";
			// 
			// groupVeicFora
			// 
			this.groupVeicFora.Controls.Add(this.dataGridView1);
			this.groupVeicFora.Location = new System.Drawing.Point(402, 12);
			this.groupVeicFora.Name = "groupVeicFora";
			this.groupVeicFora.Size = new System.Drawing.Size(318, 191);
			this.groupVeicFora.TabIndex = 7;
			this.groupVeicFora.TabStop = false;
			this.groupVeicFora.Text = "Veículos fora do pátio";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Placa,
            this.SaidaPatio});
			this.dataGridView1.DataSource = this.controlePatioBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(312, 172);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// Placa
			// 
			this.Placa.DataPropertyName = "Placa";
			this.Placa.HeaderText = "Placa";
			this.Placa.Name = "Placa";
			this.Placa.ReadOnly = true;
			// 
			// SaidaPatio
			// 
			this.SaidaPatio.DataPropertyName = "SaidaPatio";
			this.SaidaPatio.HeaderText = "SaidaPatio";
			this.SaidaPatio.Name = "SaidaPatio";
			this.SaidaPatio.ReadOnly = true;
			// 
			// groupRegistro
			// 
			this.groupRegistro.Controls.Add(this.btnAddCarro);
			this.groupRegistro.Controls.Add(this.btnAddMotorista);
			this.groupRegistro.Controls.Add(this.txtVeiculo);
			this.groupRegistro.Controls.Add(this.label14);
			this.groupRegistro.Controls.Add(this.comboMotorista);
			this.groupRegistro.Controls.Add(this.label13);
			this.groupRegistro.Controls.Add(this.comboCarros);
			this.groupRegistro.Controls.Add(this.label12);
			this.groupRegistro.Location = new System.Drawing.Point(12, 12);
			this.groupRegistro.Name = "groupRegistro";
			this.groupRegistro.Size = new System.Drawing.Size(361, 159);
			this.groupRegistro.TabIndex = 8;
			this.groupRegistro.TabStop = false;
			this.groupRegistro.Text = "Registro do carro:";
			// 
			// btnAddCarro
			// 
			this.btnAddCarro.Location = new System.Drawing.Point(136, 32);
			this.btnAddCarro.Name = "btnAddCarro";
			this.btnAddCarro.Size = new System.Drawing.Size(17, 21);
			this.btnAddCarro.TabIndex = 19;
			this.btnAddCarro.Text = "+";
			this.btnAddCarro.UseVisualStyleBackColor = true;
			this.btnAddCarro.Click += new System.EventHandler(this.btnAddCarro_Click);
			// 
			// btnAddMotorista
			// 
			this.btnAddMotorista.Location = new System.Drawing.Point(338, 113);
			this.btnAddMotorista.Name = "btnAddMotorista";
			this.btnAddMotorista.Size = new System.Drawing.Size(17, 23);
			this.btnAddMotorista.TabIndex = 18;
			this.btnAddMotorista.Text = "+";
			this.btnAddMotorista.UseVisualStyleBackColor = true;
			this.btnAddMotorista.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtVeiculo
			// 
			this.txtVeiculo.Location = new System.Drawing.Point(9, 73);
			this.txtVeiculo.Name = "txtVeiculo";
			this.txtVeiculo.ReadOnly = true;
			this.txtVeiculo.Size = new System.Drawing.Size(323, 20);
			this.txtVeiculo.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 57);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Veículo:";
			// 
			// comboMotorista
			// 
			this.comboMotorista.FormattingEnabled = true;
			this.comboMotorista.Location = new System.Drawing.Point(9, 113);
			this.comboMotorista.Name = "comboMotorista";
			this.comboMotorista.Size = new System.Drawing.Size(323, 21);
			this.comboMotorista.TabIndex = 15;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 97);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Motorista:";
			// 
			// comboCarros
			// 
			this.comboCarros.FormattingEnabled = true;
			this.comboCarros.Location = new System.Drawing.Point(9, 32);
			this.comboCarros.Name = "comboCarros";
			this.comboCarros.Size = new System.Drawing.Size(121, 21);
			this.comboCarros.TabIndex = 13;
			this.comboCarros.SelectedValueChanged += new System.EventHandler(this.comboCarros_SelectedValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Placa:";
			// 
			// id
			// 
			this.id.DataPropertyName = "Id";
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 40;
			// 
			// controlePatioBindingSource
			// 
			this.controlePatioBindingSource.DataSource = typeof(Forms.Models.ControlePatio);
			// 
			// veiculoBindingSource
			// 
			this.veiculoBindingSource.DataSource = typeof(Forms.Models.Veiculo);
			// 
			// veiculoBindingSource1
			// 
			this.veiculoBindingSource1.DataSource = typeof(Forms.Models.Veiculo);
			// 
			// FormControlePatio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 505);
			this.ControlBox = false;
			this.Controls.Add(this.groupRegistro);
			this.Controls.Add(this.groupVeicFora);
			this.Controls.Add(this.groupSaida);
			this.Controls.Add(this.groupRetorno);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControlePatio";
			this.Text = "Controle de pátio";
			this.Load += new System.EventHandler(this.FormControlePatio_Load);
			this.groupSaida.ResumeLayout(false);
			this.groupSaida.PerformLayout();
			this.groupRetorno.ResumeLayout(false);
			this.groupRetorno.PerformLayout();
			this.groupVeicFora.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupRegistro.ResumeLayout(false);
			this.groupRegistro.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlePatioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupSaida;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtObservacoes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKmSaida;
		private System.Windows.Forms.GroupBox groupRetorno;
		private System.Windows.Forms.ComboBox comboEstadoRetorno;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtkmRetorno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSalvarRetorno;
		private System.Windows.Forms.GroupBox groupVeicFora;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupRegistro;
		private System.Windows.Forms.TextBox txtVeiculo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox comboMotorista;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboCarros;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnAddMotorista;
		private System.Windows.Forms.Button btnAddCarro;
		private System.Windows.Forms.ComboBox comboLiberadoSaida;
		private System.Windows.Forms.ComboBox comboRecolhido;
		private System.Windows.Forms.ComboBox comboCombustivelSaida;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox comboCombustivelRetorno;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button brnSalvarSaida;
		private System.Windows.Forms.DateTimePicker dateTimeSaida;
		private System.Windows.Forms.DateTimePicker dateTimeRetorno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource controlePatioBindingSource;
		private System.Windows.Forms.BindingSource veiculoBindingSource1;
		private System.Windows.Forms.BindingSource veiculoBindingSource;
		private System.Windows.Forms.ComboBox comboCarrosForaPlaca;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaidaPatio;
	}
}