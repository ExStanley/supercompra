using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Specifications.Categorias;

namespace STA.SuperCompra.Dominio.Validations.Categorias
{
    public class CategoriaEstaConsistenteValidation: Validator<Categoria>
    {
        public CategoriaEstaConsistenteValidation()
        {
            //var descricaoCategoria = new CategoriaDeveSerUnicaSpecification(categoriaRepository);
            //base.Add("descricaoCategoria", new Rule<Categoria>(descricaoCategoria, "Categoria existente, verifique!"));
        }

        
    }
}
