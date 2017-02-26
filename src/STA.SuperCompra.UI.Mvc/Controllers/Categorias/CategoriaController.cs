using PagedList;
using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Infra.CrossCutting.MvcFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaAppService _categoriaAppService;
        private int _pageNumber;
        private int _pageSize = 3;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        // GET: Categoria
        //[Route("listaCategoria")]
        //[ClaimsAuthorize("Categoria", "C")]
        [AllowAnonymous]
        public ActionResult Index(int? page)
        {
            _pageNumber = page ?? 1;
            return View(_categoriaAppService.ObterTodos().OrderByDescending(c=>c.Descricao).ToPagedList(_pageNumber, _pageSize));
        }

        // GET: Categoria/Details/5
        [ClaimsAuthorize("Categoria", "C")]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CategoriaViewModel categoriaViewModel = _categoriaAppService.ObterPorId(id.Value);
            if (categoriaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoriaViewModel);
        }

        // GET: Categoria/Create
        [ClaimsAuthorize("Categoria", "I")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ClaimsAuthorize("Categoria", "I")]
        public ActionResult Create(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                categoriaViewModel = _categoriaAppService.Adicionar(categoriaViewModel);
                return RedirectToAction("Index");
            }
            return View(categoriaViewModel);
        }

        // GET: Categoria/Edit/5
        [ClaimsAuthorize("Categoria", "A")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaViewModel categoriaViewModel = _categoriaAppService.ObterPorId(id.Value);
            if (categoriaViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = id;
            return View(categoriaViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ClaimsAuthorize("Categoria", "A")]
        public ActionResult Edit(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                _categoriaAppService.Atualizar(categoriaViewModel);
                return RedirectToAction("Index");
            }
            return View(categoriaViewModel);
        }

        // GET: Categoria/Delete/5
        [ClaimsAuthorize("Categoria", "E")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaViewModel categoriaViewModel = _categoriaAppService.ObterPorId(id.Value);
            if (categoriaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoriaViewModel);
        }

        // POST: Categoria/Delete/5
        [ClaimsAuthorize("Categoria", "E")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _categoriaAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _categoriaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
