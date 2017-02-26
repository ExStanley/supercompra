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
    public class ComprasController : ApiController
    {
        private readonly ICompraAppService _compraAppService;

        public ComprasController(ICompraAppService compraAppService)
        {
            _compraAppService = compraAppService;
        }

        // GET: api/Compras
        [HttpGet]
        public IEnumerable<CompraViewModel> ObterTodos()
        {
            return _compraAppService.ObterTodos();
        }

        // GET: api/Compras/5
        [HttpGet]
        public CompraViewModel ObterPorId(Guid id)
        {
            return _compraAppService.ObterPorId(id);
        }

        // POST: api/Compras
        [HttpPost]
        public void Adicionar(CompraViewModel compraViewModel)
        {
            _compraAppService.Adicionar(compraViewModel);
        }

        // PUT: api/Compras/5
        [HttpPost]
        public void Atualizar(CompraViewModel compraViewModel)
        {
            _compraAppService.Atualizar(compraViewModel);
        }

        // DELETE: api/Compras/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            _compraAppService.Remover(id);
        }
    }
}
