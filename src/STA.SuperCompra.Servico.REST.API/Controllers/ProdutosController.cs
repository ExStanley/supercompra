using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace STA.SuperCompra.Servico.REST.API.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return _produtoAppService.ObterTodos();
        }

        [HttpGet]
        // POST: api/Produtos
        public ProdutoViewModel ObterPorId(Guid id)
        {
            return _produtoAppService.ObterPorId(id);
        }

        [HttpPost]
        public void Adicionar(ProdutoViewModel produtoViewModel)
        {
            _produtoAppService.Adicionar(produtoViewModel);
        }

        [HttpPost]
        public void Atualizar(ProdutoViewModel produtoViewModel)
        {
            _produtoAppService.Atualizar(produtoViewModel);
        }

        // DELETE: api/Produtos/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            _produtoAppService.Remover(id);
        }
    }
}
