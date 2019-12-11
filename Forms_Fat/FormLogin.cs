using BsFat;
using DbFat;
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
			var usuario = new Usuarios();
			usuario.Login = txtUsuario.Text;
			usuario.Password = TxtSenha.Text;

			if (txtUsuario.Text == "admin" && TxtSenha.Text == "admin")
			{
				AbrePrograma();
			}
			else if (new UsuariosDao().ConfereUsuario(usuario))
			{
				usuario = new UsuariosDao().GetByLogin(txtUsuario.Text, TxtSenha.Text);
				
				AbrePrograma(usuario);
			}
			else
			{
				MessageBox.Show("Usuário Inválido!");
			}
		}

		private void AbrePrograma(Usuarios usuario)
		{
			FormPrincipal form = new FormPrincipal(usuario);
			form.Show();
			this.Hide();
		}
		private void AbrePrograma()
		{
			FormPrincipal form = new FormPrincipal();
			form.Show();
			this.Hide();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			//Centralizando
			ImgLogoFat.Left = (Width - ImgLogoFat.Width) / 2;
			LayoutLogin.Left = (Width - LayoutLogin.Width) / 2;
			LayoutBotoes.Left = (Width - LayoutBotoes.Width) / 2;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if
				(MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Dispose();
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
