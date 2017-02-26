using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers.Produtos
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly ICategoriaAppService _categoriaAppService;
        private readonly IUnidadeMedidaAppService _unidadeAppService;

        public ProdutoController(IProdutoAppService produtoAppService, ICategoriaAppService categoriaAppService, IUnidadeMedidaAppService unidadeAppService)
        {
            _produtoAppService = produtoAppService;
            _categoriaAppService = categoriaAppService;
            _unidadeAppService = unidadeAppService;
        }
        // GET: Produto
        public ActionResult Index()
        {
            return View(_produtoAppService.ObterTodos());
        }

        // GET: Produto/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoViewModel produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.Unidade = _unidadeAppService.ObterTodos();
            ViewBag.Categoria = _categoriaAppService.ObterTodos();
            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.Unidade = _unidadeAppService.ObterTodos().ToList();
            ViewBag.Categoria = _categoriaAppService.ObterTodos().ToList();
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                produtoViewModel = _produtoAppService.Adicionar(produtoViewModel);
                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoViewModel produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.Unidade = _unidadeAppService.ObterTodos().ToList();
            ViewBag.Categoria = _categoriaAppService.ObterTodos().ToList();
            ViewBag.ProdutoId = id;
            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoAppService.Atualizar(produtoViewModel);
                return RedirectToAction("Index");
            }
            return View(produtoViewModel);

        }

        // GET: Produto/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoViewModel produtoViewModel = _produtoAppService.ObterPorId(id.Value);
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _produtoAppService.Remover(id);
            return RedirectToAction("Index");

        }
    }
}
