using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utilidades;

namespace Dll_Forms_Fat
{
	public partial class FormControleUsuarios : Form
	{
		private Usuarios usuario;
		private Funcionarios funcionario;


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
			if (ValidaUsuario())
			{
				var u = GetUsuario();

				u.Nivel = Convert.ToInt32(ComboNivelAcesso.Text);
				u.Login = txtUsuario.Text;
				u.Password = txtSenha.Text;
				u.ConfirmaSenha = txtConfirmaSenha.Text;

				if (!new UsuariosDao().ConfirmaUsuario(u))
				{
					MessageBox.Show("Desculpe, nome de usuário em uso");
				}
				else if (!(u.ConfirmarSenha(txtSenha.Text, txtConfirmaSenha.Text)))
				{
					MessageBox.Show("Senhas não coincidem!");
				}
				else
				{
					if (new UsuariosDao().DbUpdate(u))
					{
						MessageBox.Show("Usuário atualizado com Êxito.");
						ResetTela();
					}
					else
					{
						MessageBox.Show("Erro na gravação, tente novamente.");
					}
				}
			}
			
		}

		private void FormControleUsuarios_Load(object sender, EventArgs e)
		{
			CarregaUsuarios();
			ComboNivelAcesso.SelectedIndex = 0;
		}

		private void CarregaUsuarios()
		{
			var usuarios = new UsuariosDao().GetAll();
			comboUsuarios.DataSource = usuarios;
			comboUsuarios.DisplayMember = "Login";
			if (!(comboUsuarios.Items.Count == 0))
			{
				comboUsuarios.SelectedIndex = 0;
			}
		}
		private bool ValidaUsuario()
		{
			 if (String.IsNullOrWhiteSpace(ComboNivelAcesso.Text))
			{
				MessageBox.Show("Favor preencher o nivel do usuário.");
				return false;
			}
			return true;
		}

		private void comboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
		{
			usuario = GetUsuario();

			funcionario = new FuncionariosDao().getByUsuario(usuario);//.GetById(usuario.FuncionariosId);

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
		private void ResetTela()
		{
			this.Controls.LimparTextBoxes();
			CarregaUsuarios();
		}
	}
}
