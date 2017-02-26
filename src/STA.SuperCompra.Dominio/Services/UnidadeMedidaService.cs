using STA.SuperCompra.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;

namespace STA.SuperCompra.Dominio.Services
{
    public class UnidadeMedidaService : IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;

        public UnidadeMedidaService(IUnidadeMedidaRepository unidadeMedidaRepository)
        {
            _unidadeMedidaRepository = unidadeMedidaRepository;
        }

        public UnidadeMedida Adicionar(UnidadeMedida unidadeMedida)
        {
            return _unidadeMedidaRepository.Adicionar(unidadeMedida);
        }

        public UnidadeMedida Atualizar(UnidadeMedida unidadeMedida)
        {
            return _unidadeMedidaRepository.Atualizar(unidadeMedida);
        }

        public void Dispose()
        {
            _unidadeMedidaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public UnidadeMedida ObterPorId(Guid id)
        {
            return _unidadeMedidaRepository.ObterPorId(id);
        }

        public UnidadeMedida ObterPorNome(string nome)
        {
            return _unidadeMedidaRepository.Buscar(u => u.Descricao == nome).FirstOrDefault();
        }

        public IEnumerable<UnidadeMedida> ObterTodos()
        {
            return _unidadeMedidaRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _unidadeMedidaRepository.Remover(id);
        }
    }
}
