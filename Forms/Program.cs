using Forms.Models;
using System;
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
			var teste = new Teste();
			teste.Nome = "Luiz";
			teste.Email = "luiz@email.com";

			using (var contexto = new LocadoraContext())
			{
				contexto.Teste.Add(teste);
				contexto.SaveChanges();

			}

		}
	}
}


