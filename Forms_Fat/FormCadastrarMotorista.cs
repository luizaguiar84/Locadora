using BsFat;
using DbFat;
using System;
using System.Windows.Forms;
using Utilidades;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarMotorista : Form
	{
		private Funcionarios funcionario;

		public FormCadastrarMotorista()
		{
			InitializeComponent();
			txtNomeMotorista.Visible = false;
			funcionario = new Funcionarios();
			CarregaMotoristas();
			funcionario = (Funcionarios)comboMotoristas.SelectedItem;
		}

		public FormCadastrarMotorista(Funcionarios funcionario)
		{
			InitializeComponent();
			this.funcionario = funcionario;
			PreencheCampos(funcionario);
		}

		private void PreencheCampos(Funcionarios funcionario)
		{
			txtNomeMotorista.Text = funcionario.Nome;
			txtCnh.Text = funcionario.Cnh.Numero;
			comboCategoria.SelectedItem = funcionario.Cnh.Categoria;
			dateEmitida.Value = funcionario.Cnh.Emissao;
			dateValidade.Value = funcionario.Cnh.Validade;
	    }

		private void Button3_Click(object sender, EventArgs e)
		{
			if (validaMotorista())
			{
			
				var cnh = new CnhsBuilder()
			.GetNumero(txtCnh.Text)
			.GetCategoria(comboCategoria.SelectedItem.ToString())
			.GetEmissao(dateEmitida.Value.Date)
			.GetValidade(dateValidade.Value.Date)
			.Build();

				if (funcionario.Cnh == null)
				{
					funcionario = GetMotorista();
					cnh.Id = funcionario.Cnh.Id;
					funcionario.Cnh = cnh;
				}

				funcionario.Disponivel = true;

				if (new FuncionariosDao().DbUpdate(funcionario))
				{
					MessageBox.Show("Motorista adicionado com sucesso!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Erro na adição do Motorista, tente novamente.");
				}
			}	   
		}

		private Funcionarios GetMotorista()
		{
			return new FuncionariosDao().GetById(((Funcionarios)comboMotoristas.SelectedItem).Id);
		}

		private bool validaMotorista()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtCnh.Text))
			{
				MessageBox.Show("Favor inserir o numero da CNH");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.MdiParent = this.MdiParent;
			formCadastrarCliente.Show();
		}
		private void FormCadastrarMotorista_Load(object sender, EventArgs e)
		{
			comboCategoria.SelectedIndex = 0;
			if (funcionario == null)
			{
				this.Controls.LimparTextBoxes();
			}
		}

		private void CarregaMotoristas()
		{

			var motoristas = new FuncionariosDao().GetNaoMotoristas();
			comboMotoristas.Visible = true;
			comboMotoristas.DataSource = motoristas;
			comboMotoristas.DisplayMember = "Nome";
			if (comboMotoristas.Items.Count > 0)
			{
				comboMotoristas.SelectedIndex = 0;
			}

		}

		private void ComboMotoristas_SelectedIndexChanged(object sender, EventArgs e)
		{
			funcionario = (Funcionarios)comboMotoristas.SelectedItem;
		}
	}
}
