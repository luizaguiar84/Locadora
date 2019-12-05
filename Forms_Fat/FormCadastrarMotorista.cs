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
			this.funcionario = funcionario;
			PreencheCampos(funcionario);
			InitializeComponent();
		}

		private void PreencheCampos(Funcionarios funcionario)
		{
			txtNomeMotorista.Text = funcionario.Nome;
	    }

		private void Button3_Click(object sender, EventArgs e)
		{
			Motoristas motorista = new Motoristas();
			motorista = funcionario as Motoristas;
			CnhsBuilder cnh = new CnhsBuilder();
			cnh.GetNumero(txtCnh.Text)
				.GetCategoria(txtCategoria.Text)
				.GetEmissao(dateEmitida.Value.Date)
				.GetValidade(dateValidade.Value.Date);
			
			motorista.Cnh = cnh.Build();

			if (new MotoristasDao().DbUpdate(motorista))
			{
				MessageBox.Show("Motorista adicionado com sucesso!");
				this.Hide();
			}
			else
			{
				MessageBox.Show("Erro na adição do Motorista, tente novamente.");
			}
			
		   
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
			formCadastrarCliente.ControlBox = true;
			formCadastrarCliente.Show();
		}
		private void FormCadastrarMotorista_Load(object sender, EventArgs e)
		{
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
