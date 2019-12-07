namespace BsFat
{
	public class Cargos : BaseModel
	{
		public Cargos()
		{
		}

		public int Id { get; set; }
		public string Cargo { get; set; }

		public string NivelAcesso { get; set; }
	}
}
