using Dll_Forms_Fat;
using System;
using System.Windows.Forms;

namespace Desktop_Fat
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]

		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}
	}
}
