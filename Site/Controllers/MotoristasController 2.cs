using Dll_BS_Fat;
using Dll_DB_Fat;
using Microsoft.AspNetCore.Mvc;


namespace SiteFat.Controllers
{
    public class MotoristasController : Controller
    {
        // GET: Motoristas
        public ActionResult Index()
        {
			var motoristas = new ClientesPFDao().GetMotoristas();
            return View(motoristas);
        }

        // GET: Motoristas/Details/5
        public ActionResult Detalhes(int id)
        {
			var motorista = new ClientesPFDao().GetDetalhesMotorista(id);
            return View(motorista);
        }

        // GET: Motoristas/Create
        public ActionResult Adicionar()
        {
            return View();
        }

        // POST: Motoristas/Create
        [HttpPost]
        public ActionResult Adicionar(ClientesPF motorista)
        {
            try
            {
				new ClientesPFDao().DbAdd(motorista);

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
			var motorista = new ClientesPFDao().GetDetalhesMotorista(id);
            return View(motorista);
        }

        // POST: Motoristas/Edit/5
        [HttpPost]
        public ActionResult Editar(ClientesPF motorista)
        {
            try
            {
				new ClientesPFDao().DbUpdate(motorista);

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
			var motorista = new ClientesPFDao().GetDetalhesMotorista(id);
            return View(motorista);
        }

        // POST: Motoristas/Delete/5
        [HttpPost]
        public ActionResult Deletar(ClientesPF motorista)
        {
            try
            {
				new ClientesPFDao().DeleteRegistro(motorista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
