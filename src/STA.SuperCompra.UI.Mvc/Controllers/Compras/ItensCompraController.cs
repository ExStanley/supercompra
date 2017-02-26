using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.Services;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers.Compras
{
    public class ItensCompraController : Controller
    {

        private readonly IItensCompraAppService _itensCompraAppService;
        private readonly ICompraAppService _compraAppService;
        private readonly IProdutoAppService _produtoAppService;

        public ItensCompraController(IItensCompraAppService itensCompraAppService
                                    ,ICompraAppService compraAppService
                                    ,IProdutoAppService produtoAppService)
        {
            _itensCompraAppService = itensCompraAppService;
            _compraAppService = compraAppService;
            _produtoAppService = produtoAppService;
        }

        // GET: ItensCompra
        public ActionResult ListaProdutos(Guid id)
        {
            ViewBag.CompraId = id;
            return PartialView("_ListaProdutos", _compraAppService.ObterPorId(id).Itens);
        }

        // GET: ItensCompra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItensCompra/Create
        public ActionResult AdicionarProduto(Guid id)
        {
            ViewBag.CompraId = id;
            ViewBag.Produtos = _produtoAppService.ObterTodos();
            return PartialView("_AdicionarProduto");
        }

        // POST: ItensCompra/Create
        [HttpPost]
        public ActionResult AdicionarProduto(ItensCompraViewModel itensViewModel)
        {
            if (ModelState.IsValid)
            {
                _itensCompraAppService.Adicionar(itensViewModel);
                string url = Url.Action("ListaProdutos", "ItensCompra", new { id = itensViewModel.CompraId });
                return Json(new { success = true, url = url });
            }
            return PartialView("_AdicionarProduto", itensViewModel);
        }

        // GET: ItensCompra/Edit/5
        public ActionResult AtualizarProduto(Guid id)
        {
            var itemViewModel = _itensCompraAppService.ObterPorId(id);
            ViewBag.CompraId = itemViewModel.CompraId;
            ViewBag.Produtos = _produtoAppService.ObterTodos();
            return PartialView("_AtualizarProduto", itemViewModel );
        }

        // POST: ItensCompra/Edit/5
        [HttpPost]
        public ActionResult AtualizarProduto(ItensCompraViewModel itensViewModel)
        {
            if (ModelState.IsValid)
            {
                _itensCompraAppService.Atualizar(itensViewModel);

                string url = Url.Action("Lista de produto", "Compra", new { id = itensViewModel.CompraId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarProduto", itensViewModel);
        }

        // GET: ItensCompra/Delete/5
        public ActionResult DeletarProduto(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var itensViewModel = _itensCompraAppService.ObterPorId(id.Value);
            if (itensViewModel == null)
            {
                return HttpNotFound();
            }
            return PartialView("_DeletarProduto", itensViewModel);
        }

        // POST: ItensCompra/Delete/5
        [HttpPost]
        public ActionResult DeletarProduto(Guid id)
        {
            var itemId = _itensCompraAppService.ObterPorId(id).CompraId;
            _itensCompraAppService.Remover(id);

            string url = Url.Action("_ListaProdutos", "Compra", new { id = itemId });
            return Json(new { success = true, url = url });
        }
    }
}
