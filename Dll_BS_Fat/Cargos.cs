//namespace Forms.Models
//{
//    using FatCars.Models;
//    using System;
//	using System.Collections.Generic;
//	using System.ComponentModel.DataAnnotations;

//	public class Cargos
//	{
//		public Cargos()
//		{
//			this.funcionarios = new HashSet<Funcionarios>();
//		}

//		public int Id { get; set; }
//		public string Cargo { get; set; }

//		public virtual ICollection<Funcionarios> funcionarios { get; set; }

//		public void DbAdd()
//		{
//			using (var contexto = new LocadoraContext())
//			{
//				contexto.Cargos.Add(this);
//				contexto.SaveChanges();
//			}
//		}
//		public void DbUpdate()
//		{
//			using (var contexto = new LocadoraContext())
//			{
//				contexto.Cargos.Update(this);
//				contexto.SaveChanges();
//			}
//		}

//	}
//}
