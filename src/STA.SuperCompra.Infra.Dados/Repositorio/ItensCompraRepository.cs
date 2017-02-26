using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Infra.Dados.Contexto;

namespace STA.SuperCompra.Infra.Dados.Repositorio
{
    public  class ItensCompraRepository: Repository<ItensCompra>, IitensCompraRepository
    {
        public ItensCompraRepository(SuperCompraContext context)
            :base(context)
        {

        }
    }
}
