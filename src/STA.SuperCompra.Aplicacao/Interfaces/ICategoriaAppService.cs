using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Aplicacao.Interfaces
{
    public interface ICategoriaAppService: IDisposable
    {
        CategoriaViewModel Adicionar(CategoriaViewModel categoriaViewModel);
        CategoriaViewModel ObterPorId(Guid id);
        CategoriaViewModel ObterPorNome(string nome);
        IEnumerable<CategoriaViewModel> ObterTodos();
        CategoriaViewModel Atualizar(CategoriaViewModel categoriaViewModel);
        void Remover(Guid id);
    }
}
