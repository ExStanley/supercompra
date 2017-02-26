using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Interfaces.Service
{
    public  interface ICompraService: IDisposable
    {
        Compra Adicionar(Compra compra);
        Compra ObterPorId(Guid id);
        Compra ObterPorNome(string nome);
        IEnumerable<Compra> ObterTodos();
        Compra Atualizar(Compra compra);
        void Remover(Guid id);
    }
}
