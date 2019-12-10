using Utilidades;
using System;
using System.Windows.Forms;
using BsFat;
using DbFat;

namespace Dll_Forms_Fat
{
	public partial class FormCadastrarUsuario : Form
	{
		private Usuarios usuario;
		private Funcionarios func;

		public FormCadastrarUsuario()
		{
			InitializeComponent();
		}

		public FormCadastrarUsuario(Usuarios usuario)
		{
			InitializeComponent();
			this.usuario = usuario;
			func = new FuncionariosDao().GetById(usuario.FuncionariosId);
			PreencheDados();
		}

		private void PreencheDados()
		{
			txtRegistroFunc.ReadOnly = true;
			txtNome.ReadOnly = true;
			txtCargo.ReadOnly = true;
			txtNivelAcesso.ReadOnly = true;

			txtRegistroFunc.Text = usuario.FuncionariosId.ToString();
			txtNome.Text = func.Nome;
			txtCargo.Text = func.Cargo.Cargo;
			txtNivelAcesso.Text = func.Cargo.NivelAcesso.ToString();
		}

		private void FormCadastrarUsuario_Load(object sender, EventArgs e)
		{
		
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;

		}

		private void Btn_Salvar_Click(object sender, EventArgs e)
		{
			if (validaUsuario())
			{
				var usuario = new Usuarios
				{
					Login = txtUsuario.Text,
					Password = txtSenha.Text,
					ConfirmaSenha = txtConfirmaSenha.Text,
					IsAtivo = true,
					Nivel = Convert.ToInt32(txtNivelAcesso.Text)
				};
				if (new UsuariosDao().DbAdd(usuario))
				{
					MessageBox.Show("Usuário Cadastrado com Sucesso!");
					this.Controls.LimparTextBoxes();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Erro na adição de usuário!");
				}
	
			}
			
		}

		private bool validaUsuario()
		{
			bool ret = false;
			if (String.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				MessageBox.Show("Favor informar o nome de usuário");
			}
			else if (String.IsNullOrWhiteSpace(txtSenha.Text))
			{
				MessageBox.Show("Favor digitar a senha.");
			}
			else if (String.IsNullOrWhiteSpace(txtConfirmaSenha.Text))
			{
				MessageBox.Show("Favor Confirmar a senha.");
			}
			else if (!(txtSenha.Text.Equals(txtConfirmaSenha.Text)))
			{
				MessageBox.Show("Senha e conformação são diferentes!");
			}
			else
			{
				ret = true;
			}
			return ret;
		}

		private void FormCadastrarUsuario_Resize(object sender, EventArgs e)
		{
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;
		}

		private void BtnCadastrarCNH_Click(object sender, EventArgs e)
		{
			var cadastrarMotorista = new FormCadastrarMotorista()
			{
				ControlBox = true
			};
			cadastrarMotorista.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Usuarios usuario = new Usuarios();
			var buscaFuncionario = new FormBuscaFuncionario(usuario);
			buscaFuncionario.MdiParent = this.MdiParent;
			buscaFuncionario.ControlBox = false;
			buscaFuncionario.WindowState = FormWindowState.Maximized;
			buscaFuncionario.Show();
			this.Close();
		}
	}
}
