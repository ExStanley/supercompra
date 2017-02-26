using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Specifications.Produtos;

namespace STA.SuperCompra.Dominio.Validations.Produtos
{
    public class ProdutoAptoParaCadastroValidation: Validator<Produto>
    {
        public ProdutoAptoParaCadastroValidation(IProdutoRepository produtoRepository)
        {
            //var NomeUnico = new ProdutoDeveSerUnicoSpecification(produtoRepository);

            //base.Add("NomeUnico", new Rule<Produto>(NomeUnico, "Nome do produto já cadastrado! "));

        }

    }
}
