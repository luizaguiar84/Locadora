using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormControleUsuarios : Form
	{
		private Usuarios usuario;
		private Funcionarios funcionario;

		public List<Usuarios> Usuarios { get; private set; }

		public FormControleUsuarios()
		{
			InitializeComponent();
		}

		private void btnAdicionarUsuario_Click(object sender, EventArgs e)
		{
			FormCadastrarUsuario cadastrarUsuario = new FormCadastrarUsuario();
			cadastrarUsuario.Show();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			var u = GetUsuario();

			u.Nivel = Convert.ToInt32(ComboNivelAcesso.Text);
			u.Login = txtNome.Text;
			u.Password = txtSenha.Text;
			u.ConfirmaSenha = txtConfirmaSenha.Text;

			if (u.ConfereUsuario(Usuarios) && u.ConfirmarSenha(txtSenha.Text, txtConfirmaSenha.Text))
			{
				if (new UsuariosDao().DbUpdate(u))
				{
					MessageBox.Show("Usuário atualizado com Êxito.");
				}
				else
				{
					MessageBox.Show("Erro na gravação, tente novamente.");
				}
			}
			else
			{
				MessageBox.Show("Usuário Inválido!");
			}
		}

		private void FormControleUsuarios_Load(object sender, EventArgs e)
		{
			CarregaUsuarios();
		}

		private void CarregaUsuarios()
		{
			var usuarios = new UsuariosDao().GetAll();
			comboUsuarios.DataSource = usuarios;
			comboUsuarios.DisplayMember = "Login";
			comboUsuarios.SelectedIndex = 0;
			
		}

		private void comboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
		{
			usuario = GetUsuario();
			funcionario = new FuncionariosDao().GetById(usuario.FuncionariosId);

			txtRegFuncionario.Text = funcionario.Id.ToString();
			txtNome.Text = funcionario.Nome;
			txtCargo.Text = new CargosDao().GetById(funcionario.CargoId).Cargo;
			ComboNivelAcesso.SelectedText = usuario.Nivel.ToString();
			txtUsuario.Text = usuario.Login;
			txtSenha.Text = usuario.Password;
			txtConfirmaSenha.Text = usuario.ConfirmaSenha;
		}

		private Usuarios GetUsuario()
		{
			return (Usuarios)comboUsuarios.SelectedItem;
		}
	}
}
