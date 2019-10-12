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
			var listaFunc = new FuncionariosDao().GetAll().ToList();
            return View(listaFunc);
        }

		public ActionResult Detalhes(int id)
		{
			return BuscaFuncionario(id);
		}

		private ActionResult BuscaFuncionario(int id)
		{
			var listaFunc = new FuncionariosDao().GetAll()
							.Where(c => c.Id == id)
							.SingleOrDefault();

			if (listaFunc != null)
			{
				return View(listaFunc);
			}
			else
			{
				return View();
			}
		}

		public ActionResult Edit(int id)
		{
			return BuscaFuncionario(id);
		}

		public ActionResult NovoFuncionario(Funcionarios funcionario)
		{
			return View();
		}
		public ActionResult Editar(int id)
		{
			var funcionario = new FuncionariosDao().GetAll()
				.Where(f => f.Id == id)
				.SingleOrDefault();

			var cnh = new CnhsDao().GetAll().Where(c => c.Id == funcionario.CnhId).SingleOrDefault();
			var endereco = new EnderecosDao().GetAll().Where(c => c.Id == funcionario.EnderecoId).SingleOrDefault();

			funcionario.Cnh = cnh;
			funcionario.Endereco = endereco;

			return View(funcionario);

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

		public ActionResult Delete (int id)
		{

			var funcionario = new FuncionariosDao()
				.GetAll()
				.Where(f => f.Id == id)
				.SingleOrDefault();

			new FuncionariosDao().DeleteRegistro(funcionario);
			
			return View();
		}


	}
}