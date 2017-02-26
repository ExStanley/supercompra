using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STA.SuperCompra.Aplicacao.ViewModels
{
    public class ItensCompraViewModel
    {
        public ItensCompraViewModel()
        {
            ItensCompraId = Guid.NewGuid();
        }

        [Key]
        public Guid ItensCompraId { get; set; }

        [ScaffoldColumn(false)]
        public Guid CompraId { get; set; }

        [ScaffoldColumn(false)]
        public CompraViewModel Compra { get; set; }

        [ScaffoldColumn(false)]
        public Guid ProdutoId { get; set; }

        public ProdutoViewModel Produto { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade")]
        [Range(1,999,ErrorMessage ="Informe o valor entre {0}..{1}")]
        [Display(Name = "Quantidade")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage ="Preencha o campo Valor unitário")]
        [Display(Name = "Valor unitário")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ValorUnitario { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}