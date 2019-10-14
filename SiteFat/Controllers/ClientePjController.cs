using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class ClientePjController : Controller
    {
        // GET: ClientePj
        public ActionResult Index()
		{
			var listaClientes = new List<ClientesPJ>();
			var clientes = new ClientesPjDao().GetAll()
							.ToList(); //busca os veiculos ativos no BD
			clientes.ForEach(v => listaClientes.Add(v)); //adiciona os veiculos na variavel model
	
			return View(listaClientes);
		}

        // GET: ClientePj/Details/5
        public ActionResult Detalhes(int id)
        {
			var cliente = new ClientesPjDao().GetCliente(id);
            return View(cliente);
        }

        // GET: ClientePj/Create
        public ActionResult NovoCliente()
        {

            return View();
        }

		// POST: ClientePj/Create
		[HttpPost]
		public ActionResult Adiciona(ClientesPJ cliente)
		{

			var dao = new ClientesPjDao();
			var funcionou = dao.DbAdd(cliente);

			return View();

		}

		// GET: ClientePj/Edit/5
		public ActionResult Editar(int id)
        {
			var clientePj = new ClientesPjDao().GetCliente(id);
            return View(clientePj);
        }

        // POST: ClientePj/Edit/5
        [HttpPost]
        public ActionResult Atualizar(ClientesPJ cliente)
        {
            try
            {
				var bd = new ClientesPjDao().DbUpdate(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientePj/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientePj/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
