namespace Forms
{
	public class Definicoes	
	{
		public double ValorSegTerceiros { get; set; }
		public double ValorSegFurtoBatida { get; set; }
		public string NomeDoSistema { get; set; }



		/// <summary>
		/// Define o valor dos Preços do Seguro.
		/// </summary>
		public Definicoes()
		{
			ValorSegTerceiros = 30;
			ValorSegFurtoBatida = 30;
		}
	}
}
	