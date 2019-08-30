using Classes;
using Classes.DAO;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FatCars.Desktop
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

			Usuarios = new UsuariosDao().GetUsuarios();

			u.IsAtivo = checkStatus.Checked;
			u.Nivel = Convert.ToInt32(ComboNivelAcesso.Text);
			u.Login = txtNome.Text;
			u.Password = txtSenha.Text;
	
			if (u.ConfereUsuario(Usuarios) && u.ConfirmaSenha(txtSenha.Text, txtConfirmaSenha.Text))
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
