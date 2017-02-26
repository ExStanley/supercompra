using STA.SuperCompra.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;

namespace STA.SuperCompra.Dominio.Services
{
    public class ItensCompraService : IItensCompraService
    {
        private readonly IitensCompraRepository _itensCompraRepository;

        public ItensCompraService(IitensCompraRepository itensCompraRepository)
        {
            _itensCompraRepository = itensCompraRepository;
        }

        public ItensCompra Adicionar(ItensCompra itensCompra)
        {
            return _itensCompraRepository.Adicionar(itensCompra);
        }

        public ItensCompra Atualizar(ItensCompra itensCompra)
        {
            return _itensCompraRepository.Atualizar(itensCompra);
        }

        public void Dispose()
        {
            _itensCompraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public ItensCompra ObterPorId(Guid id)
        {
            return _itensCompraRepository.ObterPorId(id);
        }

        public ItensCompra ObterPorNome(string nome)
        {
            return _itensCompraRepository.Buscar(i => i.Produto.NomeProduto == nome).FirstOrDefault();
        }

        public IEnumerable<ItensCompra> ObterTodos()
        {
            return _itensCompraRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _itensCompraRepository.Remover(id);
        }
    }
}
