using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Infra.Dados.Contexto;

namespace STA.SuperCompra.Infra.Dados.Repositorio
{
    public class CompraRepository: Repository<Compra>, ICompraRepository
    {
        public CompraRepository(SuperCompraContext context)
            :base(context)
        {

        }
    }
}
