namespace Dll_BS_Fat
{
	public class Modelos
	{
		//public Modelos()
		//{
		//	this.carros = new HashSet<Carros>();
		//}

		public int Id { get; set; }
		public string Nome { get; set; }
		public Montadora Montadora { get; set; }

		//public virtual ICollection<Carros> carros { get; set; }
		//public virtual Montadora montadora { get; set; }
	}
}
