namespace Dll_BS_Fat
{
	public class ClienteLocacao
	{
		public int ClienteId { get; set; }
		public ClientesPF Cliente { get; set; }

		public int LocacaoId { get; set; }
		public Locacoes Locacao { get; set; }
	}
}
