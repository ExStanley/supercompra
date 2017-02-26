using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers.Unidades
{
    public class UnidadeMedidaController : Controller
    {

        private readonly IUnidadeMedidaAppService _unidadeMedidaAppService;

        public UnidadeMedidaController(IUnidadeMedidaAppService unidadeMedidaAppService)
        {
            _unidadeMedidaAppService = unidadeMedidaAppService;
        }

        // GET: UnidadeMedida
        public ActionResult Index()
        {
            return View(_unidadeMedidaAppService.ObterTodos());
        }

        // GET: UnidadeMedida/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadeMedidaViewModel unidadeMedidaViewModel = _unidadeMedidaAppService.ObterPorId(id.Value);
            if (unidadeMedidaViewModel == null)
            {
                return HttpNotFound();
            }

            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeMedida/Create
        [HttpPost]
        public ActionResult Create(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            if (ModelState.IsValid)
            {
                unidadeMedidaViewModel = _unidadeMedidaAppService.Adicionar(unidadeMedidaViewModel);
                return RedirectToAction("Index");
            }
            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadeMedidaViewModel unidadeMedidaViewModel = _unidadeMedidaAppService.ObterPorId(id.Value);
            if (unidadeMedidaViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.UnidadeMedidaId = id;
            return View(unidadeMedidaViewModel);
        }

        // POST: UnidadeMedida/Edit/5
        [HttpPost]
        public ActionResult Edit(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            if (ModelState.IsValid)
            {
                _unidadeMedidaAppService.Atualizar(unidadeMedidaViewModel);
                return RedirectToAction("Index");
            }
            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadeMedidaViewModel unidadeMedidaViewModel = _unidadeMedidaAppService.ObterPorId(id.Value);
            if (unidadeMedidaViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.UnidadeMedidaId = id;
            return View(unidadeMedidaViewModel);
        }

        // POST: UnidadeMedida/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _unidadeMedidaAppService.Remover(id);
            return RedirectToAction("Index");
         
        }
    }
}
