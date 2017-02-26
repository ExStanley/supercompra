using DomainValidation.Interfaces.Specification;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;

namespace STA.SuperCompra.Dominio.Specifications.Produtos
{
    public class ProdutoDeveSerUnicoSpecification : ISpecification<Produto>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoDeveSerUnicoSpecification(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public bool IsSatisfiedBy(Produto produto)
        {
            return _produtoRepository.Buscar(p=>p.NomeProduto == produto.NomeProduto) == null;
        }
    }
}
