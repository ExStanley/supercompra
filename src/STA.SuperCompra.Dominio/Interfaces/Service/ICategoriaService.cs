using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Interfaces.Service
{
    public interface ICategoriaService: IDisposable
    {
        Categoria Adicionar(Categoria categoria);
        Categoria ObterPorId(Guid id);
        Categoria ObterPorNome(string nome);
        IEnumerable<Categoria> ObterTodos();
        Categoria Atualizar(Categoria categoria);
        void Remover(Guid id);
    }
}
