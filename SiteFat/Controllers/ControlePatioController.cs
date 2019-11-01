using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class ControlePatioController : Controller
    {
        // GET: ControlePatio
        public ActionResult Index()
        {
			var controle = new ControlePatioDao().GetAll();
            return View(controle);
        }

		// GET: ControlePatio/Details/5
		public ActionResult Detalhes(int id)
        {
			var controle = new ControlePatioDao().GetById(id);
            return View(controle);
        }

        // GET: ControlePatio/Create
        public ActionResult Adicionar()
        {
			  ViewBag.ListaCarros = new SelectList(
				new VeiculosDao().GetVeiculosAtivos(),
				"Placa"
				);
            return View();
        }

        // POST: ControlePatio/Create
        [HttpPost]
        public ActionResult Adicionar(ControlePatio controle)
        {
            try
            {
				controle.DataSaida = DateTime.Now;
				controle.HoraSaida = DateTime.Now.TimeOfDay;
				controle.Status = true;

				new ControlePatioDao().DbAdd(controle);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

		public ActionResult RegistrarRetorno (int id)
		{
			var retorno = new ControlePatioDao().GetById(id);
			
			return View(retorno);
		}
		[HttpPost]
		public ActionResult RegistrarRetorno (ControlePatio controle)
		{
			try
			{
				controle.Status = false;
				controle.DataRetorno = DateTime.Now;
				controle.HoraRetorno = DateTime.Now.TimeOfDay;

				var veiculo = new VeiculosDao().GetById(controle.VeiculoId);

				new ControlePatioDao().RegistraRetorno(controle, veiculo);
				
				
				return RedirectToAction("Index");
			}
			catch (Exception)
			{
				return View();
			}
		}

        // GET: ControlePatio/Edit/5
        public ActionResult Editar(int id)
        {
			var controle = new ControlePatioDao().GetById(id);
            return View();
        }

        // POST: ControlePatio/Edit/5
        [HttpPost]
        public ActionResult Editar(ControlePatio controle)
        {
            try
            {
				new ControlePatioDao().DbUpdate(controle);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ControlePatio/Delete/5
        public ActionResult Deletar(int id)
        {
			var controle = new ControlePatioDao().GetById(id);
            return View(controle);
        }

        // POST: ControlePatio/Delete/5
        [HttpPost]
        public ActionResult Deletar(ControlePatio controle)
        {
            try
            {
				new ControlePatioDao().DeleteRegistro(controle);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
