using BsFat;
using DbFat;
using System;
using System.Windows.Forms;

namespace Dll_Forms_Fat
{
	public partial class FormDefinicoes : Form
	{


		public FormDefinicoes()
		{
			InitializeComponent();
		}


		private void FormTabelaDePrecos_Load(object sender, EventArgs e)
		{
			PreencheCargos();
			
		}

		private void PreencheCargos()
		{
			comboCargos.DataSource = new CargosDao().GetAll();
			comboCargos.DisplayMember = nameof(Cargos.Cargo);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var adicionarCargo = new FormAdicionarCargo();
			adicionarCargo.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var adicionarCargo = new FormAdicionarCargo((Cargos)comboCargos.SelectedItem);
			adicionarCargo.Show();
		}
	}
}
