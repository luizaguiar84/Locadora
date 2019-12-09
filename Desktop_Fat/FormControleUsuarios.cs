using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormControleUsuarios : Form
	{
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
			var u = new Usuarios();

			Usuarios = new UsuariosDao().GetAll();

			u.IsAtivo = checkStatus.Checked;
			u.Nivel = Convert.ToInt32(ComboNivelAcesso.Text);
			u.Login = txtNome.Text;
			u.Password = txtSenha.Text;

			if (u.ConfereUsuario(Usuarios) && u.ConfirmarSenha(txtSenha.Text, txtConfirmaSenha.Text))
			{
				var dao = new UsuariosDao();
				dao.DbAdd(u);
			}
		}

		private void btnCadastrarCNH_Click(object sender, EventArgs e)
		{
			var cadastrarMotorista = new FormCadastrarMotorista
			{
				ControlBox = true
			};
			cadastrarMotorista.Show();

		}

		private void FormControleUsuarios_Load(object sender, EventArgs e)
		{

		}
	}
}
