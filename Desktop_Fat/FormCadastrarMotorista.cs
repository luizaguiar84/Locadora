using BsFat;
using DbFat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarMotorista : Form
	{
		private Funcionarios funcionario;

		public FormCadastrarMotorista()
		{
			//CarregaMotoristas();
			InitializeComponent();
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
			.GetCategoria(comboCategoria.SelectedText)
			.GetEmissao(dateEmitida.Value.Date)
			.GetValidade(dateValidade.Value.Date)
			.Build();

				funcionario.Cnh = cnh;

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
		}

		//private void CarregaMotoristas()
		//{

		//	var motoristas = new MotoristasDao().GetAll();

		//	comboMotoristas.DataSource = motoristas;
		//	comboMotoristas.DisplayMember = "Nome";

		//}

		//private void ComboMotoristas_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	Motoristas motorista = (Motoristas)comboMotoristas.SelectedItem;
		//	txtCnh.Text = motorista.Cnh.Numero;
		//	txtCategoria.Text = motorista.Cnh.Categoria;
		//	//maskedEmitida.Text = motorista.Cnh.Emissao.Value.ToString();
		//	//maskedValidade.Text = motorista.Cnh.Validade.Value.ToString();

		//}
	}
}
