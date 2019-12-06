namespace BsFat
{
	public class ClienteLocacao
	{
		#region Atributos
		public int FuncionarioId { get; set; }
		public Funcionarios Funcionario { get; set; }

		public int LocacaoId { get; set; }
		public Locacoes Locacao { get; set; } 
		#endregion
	}
}
