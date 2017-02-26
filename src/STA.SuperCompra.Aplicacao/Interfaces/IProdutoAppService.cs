using System;
using System.Collections.Generic;
using STA.SuperCompra.Aplicacao.ViewModels;

namespace STA.SuperCompra.Aplicacao.Interfaces
{
    public interface IProdutoAppService: IDisposable
    {
        ProdutoViewModel Adicionar(ProdutoViewModel produtoViewModel);
        ProdutoViewModel ObterPorId(Guid id);
        ProdutoViewModel ObterPorNome(string nome);
        IEnumerable<ProdutoViewModel> ObterTodos();
        ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel);
        void Remover(Guid id);

    }
}
