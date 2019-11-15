namespace BsFat
{
	public class ClienteLocacao
	{
		#region Atributos
		public int ClienteId { get; set; }
		public Motoristas Cliente { get; set; }

		public int LocacaoId { get; set; }
		public Locacoes Locacao { get; set; } 
		#endregion
	}
}
