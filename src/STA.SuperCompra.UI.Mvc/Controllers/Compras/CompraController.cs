using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers.Compras
{
    public class CompraController : Controller
    {
        private readonly ICompraAppService _compraAppService;

        public CompraController(ICompraAppService compraAppService)
        {
            _compraAppService = compraAppService;
        }

        // GET: Compra
        public ActionResult Index()
        {           
            return View(_compraAppService.ObterTodos());
        }

        // GET: Compra/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraViewModel compraViewModel = _compraAppService.ObterPorId(id.Value);
            if (compraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(compraViewModel);
        }

        // GET: Compra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compra/Create
        [HttpPost]
        public ActionResult Create(CompraViewModel compraViewModel)
        {
            if (ModelState.IsValid)
            {
                compraViewModel = _compraAppService.Adicionar(compraViewModel);
                return RedirectToAction("Index");
            }
            return View(compraViewModel);
        }

        // GET: Compra/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraViewModel compraViewModel = _compraAppService.ObterPorId(id.Value);
            if (compraViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompraId = id;
            return View(compraViewModel);
        }

        // POST: Compra/Edit/5
        [HttpPost]
        public ActionResult Edit(CompraViewModel compraViewModel)
        {
            if (ModelState.IsValid)
            {
                _compraAppService.Atualizar(compraViewModel);
                return RedirectToAction("Index");
            }
            return View(compraViewModel);
        }

        // GET: Compra/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraViewModel compraViewModel = _compraAppService.ObterPorId(id.Value);
            if (compraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(compraViewModel);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _compraAppService.Remover(id);
            return RedirectToAction("Index");
        }
    }
}
