using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Interfaces.Service
{
    public interface IItensCompraService: IDisposable
    {
        ItensCompra Adicionar(ItensCompra itensCompra);
        ItensCompra ObterPorId(Guid id);
        ItensCompra ObterPorNome(string nome);
        IEnumerable<ItensCompra> ObterTodos();
        ItensCompra Atualizar(ItensCompra itensCompra);
        void Remover(Guid id);
    }
}
