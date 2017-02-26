using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Validations.Produtos;
using System;

namespace STA.SuperCompra.Dominio.Entidades
{
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }
        
        public Guid ProdutoId { get; set; } 
        public string NomeProduto { get; set; }
        public byte[] Imagem { get; set; }
        public string Observacao { get; set; }
        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public Guid UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida Unidade { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ProdutoEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
