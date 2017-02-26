using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Aplicacao.Interfaces
{
    public interface IUnidadeMedidaAppService: IDisposable
    {
        UnidadeMedidaViewModel Adicionar(UnidadeMedidaViewModel unidadeMedidaViewModel);
        UnidadeMedidaViewModel ObterPorId(Guid id);
        UnidadeMedidaViewModel ObterPorNome(string nome);
        IEnumerable<UnidadeMedidaViewModel> ObterTodos();
        UnidadeMedidaViewModel Atualizar(UnidadeMedidaViewModel unidadeMedidaViewModel);
        void Remover(Guid id);
    }
}
