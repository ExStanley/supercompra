using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Validations.Categorias;
using System;
using System.Collections.Generic;

namespace STA.SuperCompra.Dominio.Entidades
{
    public class Categoria
    {
        public Categoria()
        {
            CategoriaId = Guid.NewGuid();
            Produtos = new List<Produto>();
        }

        public Guid CategoriaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new CategoriaEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
