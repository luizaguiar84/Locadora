using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
			txtUsuario.Focus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//var usuario = new Usuarios();
			//usuario.Login = txtUsuario.Text;
			//usuario.Password = TxtSenha.Text;

			//if (new UsuariosDao().ConfereUsuario(usuario))
			//{
				FormPrincipal form = new FormPrincipal();
				form.Show();
				this.Hide();
			//}
			//else
			//{
			//	MessageBox.Show("Usuário Inválido!");
			//}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//Centralizando
			ImgLogoFat.Left = (Width - ImgLogoFat.Width) / 2;
			LayoutLogin.Left = (Width - LayoutLogin.Width) / 2;
			LayoutBotoes.Left = (Width - LayoutBotoes.Width) / 2;
			LinkEsqueciSenha.Left = (Width - LinkEsqueciSenha.Width) / 2;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if
				(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Environment.Exit(0);
			}

		}

		private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			if
				(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0);
			}

		}

		private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			{
				if (e.KeyChar == 13)
				{
					FormPrincipal form = new FormPrincipal();
					form.Show();
					this.Hide();
				}
			}
		}

	}
}
