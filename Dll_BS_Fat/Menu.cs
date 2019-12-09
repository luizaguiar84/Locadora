using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsFat
{
	public class Menu
	{
		[Key]
		public int Id { get; set; }

		public int Nivel { get; set; }

		[MaxLength(40)]
		public string NomeMenu { get; set; }
	}
}
	