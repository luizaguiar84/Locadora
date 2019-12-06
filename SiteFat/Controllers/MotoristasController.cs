using BsFat;
using DbFat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class MotoristasController : Controller
    {
        // GET: Motoristas
        public ActionResult Index()
        {
			var motoristas = new FuncionariosDao().GetMotoristas();
            return View(motoristas);
        }

        // GET: Motoristas/Details/5
        public ActionResult Detalhes(int id)
        {
			var motorista = new FuncionariosDao().GetById(id);
            return View(motorista);
        }

        // GET: Motoristas/Create
        public ActionResult Adicionar()
        {
            return View();
        }

        // POST: Motoristas/Create
        [HttpPost]
        public ActionResult Adicionar(Funcionarios motorista)
        {
            try
            {
				new FuncionariosDao().DbAdd(motorista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Motoristas/Edit/5
        public ActionResult Editar(int id)
        {
			var motorista = new FuncionariosDao().GetById(id);
            return View(motorista);
        }

        // POST: Motoristas/Edit/5
        [HttpPost]
        public ActionResult Editar(Funcionarios motorista)
        {
            try
            {
				new FuncionariosDao().DbUpdate(motorista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Motoristas/Delete/5
        public ActionResult Deletar(int id)
        {
			var motorista = new FuncionariosDao().GetById(id);
            return View(motorista);
        }

        // POST: Motoristas/Delete/5
        [HttpPost]
        public ActionResult Deletar(Funcionarios motorista)
        {
            try
            {
				new FuncionariosDao().DeleteRegistro(motorista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
