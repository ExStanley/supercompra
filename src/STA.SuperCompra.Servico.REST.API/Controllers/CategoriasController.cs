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
    public class CategoriasController : ApiController
    {

        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriasController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        // GET: api/Categorias
        [HttpGet]
        public IEnumerable<CategoriaViewModel> ObterTodos()
        {
            return _categoriaAppService.ObterTodos().ToList().OrderByDescending(c => c.Descricao);
        }

        // GET: api/Categorias/5
        [HttpGet]
        public CategoriaViewModel ObterPorId(Guid id)
        {
            return _categoriaAppService.ObterPorId(id);
        }

        // POST: api/Categorias
        [HttpPost]
        public void Adicionar(CategoriaViewModel categoriaViewModel)
        {
            _categoriaAppService.Adicionar(categoriaViewModel);
        }

        // PUT: api/Categorias/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categorias/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            _categoriaAppService.Remover(id);
        }
    }
}

