using DomainValidation.Validation;
using System;

namespace STA.SuperCompra.Dominio.Entidades
{
    public class ItensCompra
    {
        public ItensCompra()
        {
            ItensCompraId = Guid.NewGuid();
        }
        public Guid ItensCompraId { get; set; }
        public Guid CompraId { get; set; }
        public virtual Compra Compra { get; set; }
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }

    }
}
