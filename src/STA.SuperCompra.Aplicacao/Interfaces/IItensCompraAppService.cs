using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Aplicacao.Interfaces
{
    public interface IItensCompraAppService: IDisposable
    {
        ItensCompraViewModel Adicionar(ItensCompraViewModel itensCompraViewModel);
        ItensCompraViewModel ObterPorId(Guid id);
        ItensCompraViewModel ObterPorNome(string nome);
        IEnumerable<ItensCompraViewModel> ObterTodos();
        ItensCompraViewModel Atualizar(ItensCompraViewModel itensCompraViewModel);
        void Remover(Guid id);
    }
}
