using Forms;
using Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{

	public static class Program
	{
		public static Definicoes Valores { get; set; } = new Definicoes();


		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>

		[STAThread]

		static void Main()
		{
			//GravarUsandoEntity();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}

		private static void GravarUsandoEntity()
		{
			Teste f = new Teste();
			f.Nome = "Luiz";
			f.Salario = "4000";

			using (var contexto = new LocadoraContext())
			{
				contexto.Teste.Add(f);
				contexto.SaveChanges();
			}
		}

			
	}
}

