using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace Dll_Forms_Fat
{
	public partial class FormAdicionarCargo : Form
	{
		private Cargos cargo = new Cargos();

		public FormAdicionarCargo()
		{
			InitializeComponent();
		}
		public FormAdicionarCargo(Cargos cargo)
		{
			InitializeComponent();
			this.cargo = cargo;
			txtCargo.Text = cargo.Cargo;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (this.cargo != null)
			{
				cargo.Cargo = txtCargo.Text;

				if (new CargosDao().DbUpdate(cargo))
				{
					ConfirmaSaida();
				}
			}
			else
			{
				if (new CargosDao().CheckCargo(txtCargo.Text))
				{
					MessageBox.Show("Cargo já cadastrado no sistema");
				}
				else
				{
					var cargo = new Cargos();
					cargo.Cargo = txtCargo.Text;
			
					if (new CargosDao().DbAdd(cargo))
					{
						ConfirmaSaida();
					}
				}
			}	
		}

		private void ConfirmaSaida()
		{
			if (MessageBox.Show("Cargo Atualizado com Sucesso!\nAdicionar novo cargo?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Controls.LimparTextBoxes();
			}
			else
			{
				this.Close();
			}
		}

		private void FormAdicionarCargo_Load(object sender, EventArgs e)
		{
		}

		private void FormAdicionarCargo_Leave(object sender, EventArgs e)
		{

		}
	}
}

