namespace Dll_BS_Fat
{
	public class Definicoes : BaseModel
	{
		public decimal ValorSeguroTerceiros { get; set; }
		public decimal ValorSeguro { get; set; }
		public string NomeDoSistema { get; set; }



		/// <summary>
		/// Define o valor dos Preços do Seguro.
		/// </summary>
		public Definicoes()
		{
			ValorSeguroTerceiros = 30;
			ValorSeguro = 30;
		}
	}
}
