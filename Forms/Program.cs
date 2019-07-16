﻿using Forms.Models;
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}

	}
}


