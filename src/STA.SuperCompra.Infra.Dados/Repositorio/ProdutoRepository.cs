using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Infra.Dados.Contexto;

namespace STA.SuperCompra.Infra.Dados.Repositorio
{
    public class ProdutoRepository: Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(SuperCompraContext context)
            : base(context)
        {

        }
    }
}
