using Dll_BS_Fat;
using Dll_DB_Fat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteFat.Controllers
{
    public class FuncionariosController : Controller
    {
        // GET: Funcionarios
        public ActionResult Index()
        {
			var listaFunc = new FuncionariosDao().GetAll();
            return View(listaFunc);
        }

		public ActionResult Detalhes(int id)
		{
			var funcionario = new FuncionariosDao().GetFuncionario(id);

			if (funcionario != null)
			{
				return View(funcionario);
			}
			else
			{
				return View();
			}
		}

		
		public ActionResult NovoFuncionario(Funcionarios funcionario)
		{
			return View();
		}
		public ActionResult Editar(int id)
		{

			var funcionario = new FuncionariosDao().GetFuncionario(id);

			if (funcionario != null)
			{
				return View(funcionario);
			}
			else
			{
				return View();
			}
		}

		public ActionResult Adiciona(Funcionarios funcionario)
		{
			var bd = new FuncionariosDao();
			var funcionou = bd.DbAdd(funcionario);

			return View();
		}
		public ActionResult Atualiza(Funcionarios funcionario)
		{
			var bd = new FuncionariosDao();
			var funcionou = bd.DbUpdate(funcionario);

			return View();
		}

		public ActionResult Deletar (Funcionarios funcionario)
		{
			var funcionou = new FuncionariosDao().DeleteRegistro(funcionario);

			return View();
		}
		public ActionResult Deletar (int id)
		{

			var funcionario = new FuncionariosDao().GetFuncionario(id);


			return View(funcionario);
		}


	}
}