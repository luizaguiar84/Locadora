using Classes;
using Classes.Models;
using FatCars;
using FatCars.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatCars
{
	public partial class FormCadastrarUsuario : Form
	{
		public FormCadastrarUsuario()
		{
		
			InitializeComponent();
		}

		private void FormCadastrarUsuario_Load(object sender, EventArgs e)
		{
			//centralizando
			groupCadastro.Left = (Width - groupCadastro.Width) / 2;
			groupCadastro.Top = ((Height - groupCadastro.Height) - 50) / 2;

		}

		private void Btn_Salvar_Click(object sender, EventArgs e)
		{
			
			MessageBox.Show("Usuário Cadastrado com Sucesso!");
			this.Controls.LimparTextBoxes();
			this.Hide();
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
			var buscaFuncionario = new FormBuscaFuncionario();
			buscaFuncionario.Show();
		}
	}
}
