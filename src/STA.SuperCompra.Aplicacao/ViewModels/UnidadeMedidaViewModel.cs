using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace STA.SuperCompra.Aplicacao.ViewModels
{
    public class UnidadeMedidaViewModel
    {
        public UnidadeMedidaViewModel()
        {
            UnidadeMedidaId = Guid.NewGuid();
        }
        [Key]
        public Guid UnidadeMedidaId { get; set; }

        [Required(ErrorMessage = "Preecha o campo Unidade")]
        [MaxLength(3, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo {0} caracteres")]
        [DisplayName("Unidade")]
        public string Unidade { get; set; }

        [MaxLength(20, ErrorMessage ="Máximo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public ICollection<ProdutoViewModel> Produtos { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}