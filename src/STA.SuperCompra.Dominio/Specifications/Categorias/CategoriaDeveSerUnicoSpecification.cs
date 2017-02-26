using DomainValidation.Interfaces.Specification;
using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;

namespace STA.SuperCompra.Dominio.Specifications.Categorias
{
    public class CategoriaDeveSerUnicaSpecification: ISpecification<Categoria>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaDeveSerUnicaSpecification(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public bool IsSatisfiedBy(Categoria categoria)
        {
            
            return _categoriaRepository.Buscar(p => p.Descricao == categoria.Descricao) == null;
        }
    }
}
