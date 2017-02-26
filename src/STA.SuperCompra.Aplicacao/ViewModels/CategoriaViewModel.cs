using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STA.SuperCompra.Aplicacao.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            CategoriaId = Guid.NewGuid();
        }
        [Key]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Descrição")]
        [MaxLength(60, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage ="Mínimo {0} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<ProdutoViewModel> Produtos { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }

    }
}