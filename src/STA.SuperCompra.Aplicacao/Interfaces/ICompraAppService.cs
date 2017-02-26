using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Aplicacao.Interfaces
{
    public interface ICompraAppService: IDisposable
    {
        CompraViewModel Adicionar(CompraViewModel compraViewModel);
        CompraViewModel ObterPorId(Guid id);
        CompraViewModel ObterPorNome(string nome);
        IEnumerable<CompraViewModel> ObterTodos();
        CompraViewModel Atualizar(CompraViewModel compraViewModel);
        void Remover(Guid id);
    }
}
