namespace Dll_Forms_Fat
{
	partial class FormControleEstoque
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleEstoque));
			this.TabCotroleEstoque = new System.Windows.Forms.TabControl();
			this.tabConsultaEstoque = new System.Windows.Forms.TabPage();
			this.comboFiltro = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tabCadEntradas = new System.Windows.Forms.TabPage();
			this.dateEntrada = new System.Windows.Forms.DateTimePicker();
			this.txtIncluidoPor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValorUnitEntrada = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
			this.btnSalvarEntrada = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txtNomeEntrada = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tabCadSaidas = new System.Windows.Forms.TabPage();
			this.txtIdSaida = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.dateSaida = new System.Windows.Forms.DateTimePicker();
			this.txtRetirado = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtObservacoesSaida = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValorUnitSaida = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQuantidadeSaida = new System.Windows.Forms.TextBox();
			this.btnSalvarSaida = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNomeSaida = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridConsulta = new System.Windows.Forms.DataGridView();
			this.TabCotroleEstoque.SuspendLayout();
			this.tabConsultaEstoque.SuspendLayout();
			this.tabCadEntradas.SuspendLayout();
			this.tabCadSaidas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
			this.SuspendLayout();
			// 
			// TabCotroleEstoque
			// 
			this.TabCotroleEstoque.Controls.Add(this.tabConsultaEstoque);
			this.TabCotroleEstoque.Controls.Add(this.tabCadEntradas);
			this.TabCotroleEstoque.Controls.Add(this.tabCadSaidas);
			this.TabCotroleEstoque.Location = new System.Drawing.Point(12, 12);
			this.TabCotroleEstoque.Name = "TabCotroleEstoque";
			this.TabCotroleEstoque.SelectedIndex = 0;
			this.TabCotroleEstoque.Size = new System.Drawing.Size(724, 297);
			this.TabCotroleEstoque.TabIndex = 30;
			// 
			// tabConsultaEstoque
			// 
			this.tabConsultaEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabConsultaEstoque.Controls.Add(this.comboFiltro);
			this.tabConsultaEstoque.Controls.Add(this.label14);
			this.tabConsultaEstoque.Controls.Add(this.btnBuscar);
			this.tabConsultaEstoque.Controls.Add(this.txtPesquisar);
			this.tabConsultaEstoque.Controls.Add(this.label13);
			this.tabConsultaEstoque.Location = new System.Drawing.Point(4, 22);
			this.tabConsultaEstoque.Name = "tabConsultaEstoque";
			this.tabConsultaEstoque.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsultaEstoque.Size = new System.Drawing.Size(716, 271);
			this.tabConsultaEstoque.TabIndex = 2;
			this.tabConsultaEstoque.Text = "Consulta de estoque";
			// 
			// comboFiltro
			// 
			this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFiltro.FormattingEnabled = true;
			this.comboFiltro.Items.AddRange(new object[] {
            "Peça",
            "Código"});
			this.comboFiltro.Location = new System.Drawing.Point(84, 37);
			this.comboFiltro.Name = "comboFiltro";
			this.comboFiltro.Size = new System.Drawing.Size(137, 21);
			this.comboFiltro.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(233, 21);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 13);
			this.label14.TabIndex = 3;
			this.label14.Text = "Pesquisa:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(421, 34);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar...";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(236, 37);
			this.txtPesquisar.MaxLength = 20;
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(167, 20);
			this.txtPesquisar.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(81, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Filtro:";
			// 
			// tabCadEntradas
			// 
			this.tabCadEntradas.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabCadEntradas.Controls.Add(this.dateEntrada);
			this.tabCadEntradas.Controls.Add(this.txtIncluidoPor);
			this.tabCadEntradas.Controls.Add(this.label1);
			this.tabCadEntradas.Controls.Add(this.label2);
			this.tabCadEntradas.Controls.Add(this.txtObservacoes);
			this.tabCadEntradas.Controls.Add(this.label3);
			this.tabCadEntradas.Controls.Add(this.txtValorUnitEntrada);
			this.tabCadEntradas.Controls.Add(this.label10);
			this.tabCadEntradas.Controls.Add(this.txtQuantidadeEntrada);
			this.tabCadEntradas.Controls.Add(this.btnSalvarEntrada);
			this.tabCadEntradas.Controls.Add(this.label11);
			this.tabCadEntradas.Controls.Add(this.txtNomeEntrada);
			this.tabCadEntradas.Controls.Add(this.label12);
			this.tabCadEntradas.Location = new System.Drawing.Point(4, 22);
			this.tabCadEntradas.Name = "tabCadEntradas";
			this.tabCadEntradas.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadEntradas.Size = new System.Drawing.Size(716, 271);
			this.tabCadEntradas.TabIndex = 0;
			this.tabCadEntradas.Text = "Cadastro de entradas";
			// 
			// dateEntrada
			// 
			this.dateEntrada.Location = new System.Drawing.Point(86, 20);
			this.dateEntrada.Name = "dateEntrada";
			this.dateEntrada.Size = new System.Drawing.Size(229, 20);
			this.dateEntrada.TabIndex = 1;
			// 
			// txtIncluidoPor
			// 
			this.txtIncluidoPor.Location = new System.Drawing.Point(83, 101);
			this.txtIncluidoPor.MaxLength = 50;
			this.txtIncluidoPor.Name = "txtIncluidoPor";
			this.txtIncluidoPor.Size = new System.Drawing.Size(465, 20);
			this.txtIncluidoPor.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 67;
			this.label1.Text = "Incluído por:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 66;
			this.label2.Text = "Data da entrada:";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(83, 155);
			this.txtObservacoes.MaxLength = 250;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(476, 68);
			this.txtObservacoes.TabIndex = 5;
			this.txtObservacoes.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 62;
			this.label3.Text = "Observações:";
			// 
			// txtValorUnitEntrada
			// 
			this.txtValorUnitEntrada.Location = new System.Drawing.Point(471, 58);
			this.txtValorUnitEntrada.MaxLength = 8;
			this.txtValorUnitEntrada.Name = "txtValorUnitEntrada";
			this.txtValorUnitEntrada.Size = new System.Drawing.Size(77, 20);
			this.txtValorUnitEntrada.TabIndex = 3;
			this.txtValorUnitEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitEntrada_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(471, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 13);
			this.label10.TabIndex = 60;
			this.label10.Text = "Valor Unitário";
			// 
			// txtQuantidadeEntrada
			// 
			this.txtQuantidadeEntrada.Location = new System.Drawing.Point(404, 58);
			this.txtQuantidadeEntrada.MaxLength = 8;
			this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
			this.txtQuantidadeEntrada.Size = new System.Drawing.Size(61, 20);
			this.txtQuantidadeEntrada.TabIndex = 58;
			this.txtQuantidadeEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEntrada_KeyPress);
			// 
			// btnSalvarEntrada
			// 
			this.btnSalvarEntrada.Location = new System.Drawing.Point(259, 225);
			this.btnSalvarEntrada.Name = "btnSalvarEntrada";
			this.btnSalvarEntrada.Size = new System.Drawing.Size(105, 40);
			this.btnSalvarEntrada.TabIndex = 59;
			this.btnSalvarEntrada.Text = "Salvar";
			this.btnSalvarEntrada.UseVisualStyleBackColor = true;
			this.btnSalvarEntrada.Click += new System.EventHandler(this.btnSalvarEntrada_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(403, 42);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 13);
			this.label11.TabIndex = 57;
			this.label11.Text = "Quantidade";
			// 
			// txtNomeEntrada
			// 
			this.txtNomeEntrada.Location = new System.Drawing.Point(83, 58);
			this.txtNomeEntrada.MaxLength = 50;
			this.txtNomeEntrada.Name = "txtNomeEntrada";
			this.txtNomeEntrada.Size = new System.Drawing.Size(315, 20);
			this.txtNomeEntrada.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(80, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 13);
			this.label12.TabIndex = 55;
			this.label12.Text = "Nome da peça";
			// 
			// tabCadSaidas
			// 
			this.tabCadSaidas.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabCadSaidas.Controls.Add(this.txtIdSaida);
			this.tabCadSaidas.Controls.Add(this.label15);
			this.tabCadSaidas.Controls.Add(this.dateSaida);
			this.tabCadSaidas.Controls.Add(this.txtRetirado);
			this.tabCadSaidas.Controls.Add(this.label9);
			this.tabCadSaidas.Controls.Add(this.label4);
			this.tabCadSaidas.Controls.Add(this.txtObservacoesSaida);
			this.tabCadSaidas.Controls.Add(this.label5);
			this.tabCadSaidas.Controls.Add(this.txtValorUnitSaida);
			this.tabCadSaidas.Controls.Add(this.label6);
			this.tabCadSaidas.Controls.Add(this.txtQuantidadeSaida);
			this.tabCadSaidas.Controls.Add(this.btnSalvarSaida);
			this.tabCadSaidas.Controls.Add(this.label7);
			this.tabCadSaidas.Controls.Add(this.txtNomeSaida);
			this.tabCadSaidas.Controls.Add(this.label8);
			this.tabCadSaidas.Location = new System.Drawing.Point(4, 22);
			this.tabCadSaidas.Name = "tabCadSaidas";
			this.tabCadSaidas.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadSaidas.Size = new System.Drawing.Size(716, 271);
			this.tabCadSaidas.TabIndex = 1;
			this.tabCadSaidas.Text = "Cadastro de saídas";
			// 
			// txtIdSaida
			// 
			this.txtIdSaida.Location = new System.Drawing.Point(488, 19);
			this.txtIdSaida.MaxLength = 4;
			this.txtIdSaida.Name = "txtIdSaida";
			this.txtIdSaida.ReadOnly = true;
			this.txtIdSaida.Size = new System.Drawing.Size(61, 20);
			this.txtIdSaida.TabIndex = 73;
			this.txtIdSaida.TabStop = false;
			this.txtIdSaida.TextChanged += new System.EventHandler(this.txtIdSaida_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(487, 3);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(16, 13);
			this.label15.TabIndex = 72;
			this.label15.Text = "Id";
			// 
			// dateSaida
			// 
			this.dateSaida.Location = new System.Drawing.Point(84, 19);
			this.dateSaida.Name = "dateSaida";
			this.dateSaida.Size = new System.Drawing.Size(230, 20);
			this.dateSaida.TabIndex = 1;
			// 
			// txtRetirado
			// 
			this.txtRetirado.Location = new System.Drawing.Point(84, 101);
			this.txtRetirado.MaxLength = 50;
			this.txtRetirado.Name = "txtRetirado";
			this.txtRetirado.Size = new System.Drawing.Size(465, 20);
			this.txtRetirado.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(84, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 13);
			this.label9.TabIndex = 53;
			this.label9.Text = "Retirado por:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(81, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 52;
			this.label4.Text = "Data da saída:";
			// 
			// txtObservacoesSaida
			// 
			this.txtObservacoesSaida.Location = new System.Drawing.Point(84, 155);
			this.txtObservacoesSaida.Name = "txtObservacoesSaida";
			this.txtObservacoesSaida.Size = new System.Drawing.Size(476, 68);
			this.txtObservacoesSaida.TabIndex = 4;
			this.txtObservacoesSaida.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(81, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 48;
			this.label5.Text = "Observações:";
			// 
			// txtValorUnitSaida
			// 
			this.txtValorUnitSaida.Location = new System.Drawing.Point(472, 58);
			this.txtValorUnitSaida.MaxLength = 4;
			this.txtValorUnitSaida.Name = "txtValorUnitSaida";
			this.txtValorUnitSaida.ReadOnly = true;
			this.txtValorUnitSaida.Size = new System.Drawing.Size(77, 20);
			this.txtValorUnitSaida.TabIndex = 47;
			this.txtValorUnitSaida.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(472, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 46;
			this.label6.Text = "Valor Unitário";
			// 
			// txtQuantidadeSaida
			// 
			this.txtQuantidadeSaida.Location = new System.Drawing.Point(405, 58);
			this.txtQuantidadeSaida.MaxLength = 8;
			this.txtQuantidadeSaida.Name = "txtQuantidadeSaida";
			this.txtQuantidadeSaida.Size = new System.Drawing.Size(61, 20);
			this.txtQuantidadeSaida.TabIndex = 2;
			this.txtQuantidadeSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeSaida_KeyPress);
			// 
			// btnSalvarSaida
			// 
			this.btnSalvarSaida.Location = new System.Drawing.Point(260, 225);
			this.btnSalvarSaida.Name = "btnSalvarSaida";
			this.btnSalvarSaida.Size = new System.Drawing.Size(105, 40);
			this.btnSalvarSaida.TabIndex = 5;
			this.btnSalvarSaida.Text = "Salvar";
			this.btnSalvarSaida.UseVisualStyleBackColor = true;
			this.btnSalvarSaida.Click += new System.EventHandler(this.btnSalvarSaida_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(404, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Quantidade";
			// 
			// txtNomeSaida
			// 
			this.txtNomeSaida.Location = new System.Drawing.Point(84, 58);
			this.txtNomeSaida.Name = "txtNomeSaida";
			this.txtNomeSaida.ReadOnly = true;
			this.txtNomeSaida.Size = new System.Drawing.Size(315, 20);
			this.txtNomeSaida.TabIndex = 42;
			this.txtNomeSaida.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(81, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "Nome da peça";
			// 
			// dataGridConsulta
			// 
			this.dataGridConsulta.AllowUserToAddRows = false;
			this.dataGridConsulta.AllowUserToDeleteRows = false;
			this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridConsulta.Location = new System.Drawing.Point(2, 315);
			this.dataGridConsulta.Name = "dataGridConsulta";
			this.dataGridConsulta.ReadOnly = true;
			this.dataGridConsulta.Size = new System.Drawing.Size(734, 188);
			this.dataGridConsulta.TabIndex = 32;
			this.dataGridConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsulta_CellClick);
			this.dataGridConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConsulta_CellContentClick);
			// 
			// FormControleEstoque
			// 
			this.AcceptButton = this.btnBuscar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 515);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridConsulta);
			this.Controls.Add(this.TabCotroleEstoque);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControleEstoque";
			this.Text = "Controle de estoque";
			this.Load += new System.EventHandler(this.FormControleEstoque_Load);
			this.Enter += new System.EventHandler(this.FormControleEstoque_Load);
			this.TabCotroleEstoque.ResumeLayout(false);
			this.tabConsultaEstoque.ResumeLayout(false);
			this.tabConsultaEstoque.PerformLayout();
			this.tabCadEntradas.ResumeLayout(false);
			this.tabCadEntradas.PerformLayout();
			this.tabCadSaidas.ResumeLayout(false);
			this.tabCadSaidas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabCadEntradas;
		private System.Windows.Forms.TextBox txtIncluidoPor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtObservacoes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtValorUnitEntrada;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtQuantidadeEntrada;
		private System.Windows.Forms.Button btnSalvarEntrada;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNomeEntrada;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabPage tabCadSaidas;
		private System.Windows.Forms.TextBox txtRetirado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtObservacoesSaida;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtValorUnitSaida;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtQuantidadeSaida;
		private System.Windows.Forms.Button btnSalvarSaida;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNomeSaida;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabConsultaEstoque;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboFiltro;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.TabControl TabCotroleEstoque;
		private System.Windows.Forms.DateTimePicker dateEntrada;
		private System.Windows.Forms.DateTimePicker dateSaida;
		private System.Windows.Forms.TextBox txtIdSaida;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataGridView dataGridConsulta;
	}
}