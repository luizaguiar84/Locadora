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

namespace Dll_Forms_Fat
{
	public partial class FormAdicionarCargo : Form
	{
		public FormAdicionarCargo()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
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
					if (MessageBox.Show("Cargo Adicionado com sucesso! Adicionar novo cargo?", "Confirmação", MessageBoxButtons.YesNo)
						== DialogResult.Yes)
					{
						txtCargo.Text = "";
					}
					else
					{
						this.Close();
					}
				}
			}

		}

	}
}

