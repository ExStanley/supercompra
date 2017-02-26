using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Interfaces.Service
{
    public interface IProdutoService : IDisposable
    {
        Produto Adicionar(Produto produto);
        Produto ObterPorId(Guid id);
        Produto ObterPorNome(string nome);
        IEnumerable<Produto> ObterTodos();
        Produto Atualizar(Produto produto);
        void Remover(Guid id);
    }
}
