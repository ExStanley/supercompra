using STA.SuperCompra.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;

namespace STA.SuperCompra.Dominio.Services
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        public CompraService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public Compra Adicionar(Compra compra)
        {
            return _compraRepository.Adicionar(compra);
        }

        public Compra Atualizar(Compra compra)
        {
            return _compraRepository.Atualizar(compra);
        }

        public void Dispose()
        {
            _compraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Compra ObterPorId(Guid id)
        {
            return _compraRepository.ObterPorId(id);
        }

        public Compra ObterPorNome(string nome)
        {
            return _compraRepository.Buscar(c => c.NomeLista == nome).FirstOrDefault();
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _compraRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _compraRepository.Remover(id);
        }
    }
}
