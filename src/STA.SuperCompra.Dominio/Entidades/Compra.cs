using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Entidades
{
    public class Compra
    {
        public Compra()
        {
            CompraId = Guid.NewGuid();
            Itens = new List<ItensCompra>();
        }

        public Guid CompraId { get; set; }
        public string NomeLista { get; set; }
        public string NomeEstabelecimento { get; set; }
        public Guid ListaProdutoId { get; set; }
        public virtual ICollection<ItensCompra> Itens { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Total { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }

    }
}
