using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Infra.Dados.Contexto;

namespace STA.SuperCompra.Infra.Dados.Repositorio
{
    public class UnidadeMedidaRepository : Repository<UnidadeMedida>, IUnidadeMedidaRepository
    {
        public UnidadeMedidaRepository(SuperCompraContext context)
            : base(context)
        {

        }
    }
}
