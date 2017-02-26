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
    public class ItensCompraController : ApiController
    {
        private readonly IItensCompraAppService _itensAppService;
        public ItensCompraController(IItensCompraAppService itensAppService)
        {
            _itensAppService = itensAppService;
        }
        // GET: api/ItensCompra
        [HttpGet]
        public IEnumerable<ItensCompraViewModel> ObterTodos()
        {
            return _itensAppService.ObterTodos();
        }

        // GET: api/ItensCompra/5
        [HttpGet]
        public ItensCompraViewModel ObterPorId(Guid id)
        {
            return _itensAppService.ObterPorId(id);
        }

        // POST: api/ItensCompra
        [HttpPost]
        public void Adicionar(ItensCompraViewModel itensCompraViewModel)
        {
            _itensAppService.Adicionar(itensCompraViewModel);
        }

        // PUT: api/ItensCompra/5
        [HttpPost]
        public void Atualizar(ItensCompraViewModel itensCompraViewModel)
        {
            _itensAppService.Atualizar(itensCompraViewModel);
        }

        // DELETE: api/ItensCompra/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            _itensAppService.Remover(id);
        }
    }
}
