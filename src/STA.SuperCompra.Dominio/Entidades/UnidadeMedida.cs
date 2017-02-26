using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Entidades
{
    public class UnidadeMedida
    {
        public UnidadeMedida()
        {
            UnidadeMedidaId = Guid.NewGuid();
            Produtos = new List<Produto>();
        }
        public Guid UnidadeMedidaId { get; set; }
        public string Unidade { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}
