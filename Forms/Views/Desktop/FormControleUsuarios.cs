using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views.Desktop
{
	public partial class FormControleUsuarios : Form
	{
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
			MessageBox.Show("Usuário Atualizado com Sucesso");
			this.Hide();

		}

		private void btnCadastrarCNH_Click(object sender, EventArgs e)
		{
			Views.Desktop.FormCadastrarMotorista cadastrarMotorista = new Views.Desktop.FormCadastrarMotorista();
			cadastrarMotorista.ControlBox = true;
			cadastrarMotorista.Show();

		}

		private void FormControleUsuarios_Load(object sender, EventArgs e)
		{

		}
	}
}
