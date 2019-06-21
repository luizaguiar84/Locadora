using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class Util
	{
		//Metodo para limpar todos os textbox
		public void LimparTextBoxes(Control.ControlCollection controles)
		{
			//Faz um laço para todos os controles passados no parâmetro
			foreach (Control ctrl in controles)
			{
				//Se o contorole for um TextBox...
				if (ctrl is TextBox)
				{
					((TextBox)(ctrl)).Text = String.Empty;
				}
				//Se o controle for um MaskedTextBox
				if(ctrl is MaskedTextBox)
				{
					((MaskedTextBox)(ctrl)).Text = String.Empty;

				}
				//Se o controle for um ComboBox
				if (ctrl is ComboBox)
				{
					((ComboBox)(ctrl)).Text = String.Empty;

				}
				//Se o controle for um RichTextBox
				if (ctrl is RichTextBox)
				{
					((RichTextBox)(ctrl)).Text = String.Empty;

				}
				//Se o controle for um CheckedListBox
				if (ctrl is CheckedListBox)
				{
					((CheckedListBox)(ctrl)).Text = String.Empty;

				}
				if (ctrl is CheckBox)
				{
					((CheckBox)(ctrl)).Text = String.Empty;

				}
			}
		}
	}
}
