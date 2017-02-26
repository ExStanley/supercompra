using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Interfaces.Service
{
    public  interface IUnidadeMedidaService: IDisposable
    {
        UnidadeMedida Adicionar(UnidadeMedida unidadeMedida);
        UnidadeMedida ObterPorId(Guid id);
        UnidadeMedida ObterPorNome(string nome);
        IEnumerable<UnidadeMedida> ObterTodos();
        UnidadeMedida Atualizar(UnidadeMedida unidadeMedida);
        void Remover(Guid id);
    }
}
