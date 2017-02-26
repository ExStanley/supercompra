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
    public class UnidadesController : ApiController
    {
        private readonly IUnidadeMedidaAppService _unidadeMedidaAppService;
        public UnidadesController(IUnidadeMedidaAppService unidadeMedidaAppService)
        {
            _unidadeMedidaAppService = unidadeMedidaAppService;
        }

        // GET: api/Unidades
        [HttpGet]
        public IEnumerable<UnidadeMedidaViewModel> ObterTodos()
        {
            return _unidadeMedidaAppService.ObterTodos();
        }

        // GET: api/Unidades/5
        [HttpGet]
        public UnidadeMedidaViewModel ObterPorId(Guid id)
        {
            return _unidadeMedidaAppService.ObterPorId(id);
        }

        // POST: api/Unidades
        [HttpPost]
        public void Adicionar(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            _unidadeMedidaAppService.Adicionar(unidadeMedidaViewModel);
        }

        // PUT: api/Unidades/5
        [HttpPost]
        public void Atualizar(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            _unidadeMedidaAppService.Atualizar(unidadeMedidaViewModel);
        }

        // DELETE: api/Unidades/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            _unidadeMedidaAppService.Remover(id);
        }
    }
}
