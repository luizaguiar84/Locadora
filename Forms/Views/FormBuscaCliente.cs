using Classes.DAO;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
{
	public partial class FormBuscaCliente : Form
	{

		public FormBuscaCliente()
		{
			InitializeComponent();
		}

		private void FormBuscaCliente_Load(object sender, EventArgs e)
		{
			
		}

		private void BtnPesquisar_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(ComboFiltro.Text))
			{
				MessageBox.Show("Favor selecionar um filtro para a busca.");
			}
			else
			{
				var source = new ClientesDao().DbSearch(ComboFiltro.Text, txtPesquisa.Text);

				MontarDataGrid(source);
			}
		}

		private void MontarDataGrid(List<Clientes> source)
		{
			dataGridView1.DataSource = source;

			dataGridView1.Visible = true;
			dataGridView1.Columns["IsAtivo"].Visible = true;
			dataGridView1.Columns["IsAtivo"].HeaderText = "Ativo";
			dataGridView1.Columns["Id"].Visible = true;
			dataGridView1.Columns["Nome"].Visible = true;
			dataGridView1.Columns["Nome"].HeaderText = "Nome";
			dataGridView1.Columns["Cpf"].Visible = true;
			dataGridView1.Columns["Cpf"].HeaderText = "CPF";
			dataGridView1.Columns["Rg"].Visible = true;
			dataGridView1.Columns["Rg"].HeaderText = "RG";
			dataGridView1.Columns["Cnpj"].Visible = true;
			dataGridView1.Columns["Cnpj"].HeaderText = "CNPJ";
			dataGridView1.Columns["Ie"].Visible = true;
			dataGridView1.Columns["Ie"].HeaderText = "IE";
			dataGridView1.Columns["Nascimento"].Visible = true;
			dataGridView1.Columns["TelCelular"].Visible = true;
			dataGridView1.Columns["TelCelular"].HeaderText = "Celular";
			dataGridView1.Columns["TelResidencial"].Visible = true;
			dataGridView1.Columns["TelResidencial"].HeaderText = "Tel. Residencial";
			dataGridView1.Columns["TelComercial"].Visible = true;
			dataGridView1.Columns["TelComercial"].HeaderText = "Tel. Comercial";
			dataGridView1.Columns["Profissao"].Visible = true;
			dataGridView1.Columns["Profissao"].HeaderText = "Profissão";
		
			dataGridView1.Columns["Contato"].Visible = true;
			dataGridView1.Columns["TipoCliente"].Visible = false;
			dataGridView1.Columns["Cnh"].Visible = false;
			dataGridView1.Columns["Locacao"].Visible = false;
			dataGridView1.Columns["Endereco"].Visible = false;
		}

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var cnh = new Cnhs();
			var endereco = new Enderecos();

			int clienteId = Convert.ToInt32(dataGridView1["Id", e.RowIndex].Value);

			var cliente = new ClientesDao().GetClientes().Single(x => x.Id == clienteId);

			endereco = new EnderecosDao().DbGetEndereco(cliente.EnderecoId);
			cnh = new CnhsDao().DbGetCnh(cliente.CnhId);

			cliente.Endereco = endereco;
			cliente.Cnh = cnh;



			var form = new FormCadastrarCliente(cliente)
			{
				MdiParent = this.ParentForm
			};
			
			this.Close();
			form.Show();
			
		}


	}
}
