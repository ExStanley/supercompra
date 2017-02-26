using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Infra.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Infra.Dados.Repositorio
{
    public class CategoriaRepository: Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(SuperCompraContext context)
            : base(context)
        {

        }

        public override Categoria ObterPorId(Guid id)
        {
            //throw new Exception("THE BOMB HAS BEEN PLANTED");
            return base.ObterPorId(id);
        }
    }
}
