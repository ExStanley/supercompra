using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STA.SuperCompra.Aplicacao.ViewModels
{
    public class CompraViewModel
    {
        public CompraViewModel()
        {
            CompraId = Guid.NewGuid();
            Itens = new List<ItensCompraViewModel>();
        }

        [Key]
        public Guid CompraId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome da lista")]
        [MaxLength(20, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo {0} caracteres")]
        [Display(Name = "Nome da lista")]
        public string NomeLista { get; set; }

        [Required(ErrorMessage ="Preencha o campo Estabelecimento")]
        [MaxLength(60, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo {0} caracteres")]
        [Display(Name = "Estabelecimento")]
        public string NomeEstabelecimento { get; set; }

        [ScaffoldColumn(false)]
        public Guid ListaProdutoId { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<ItensCompraViewModel> Itens { get; set; }

        [MaxLength(30,ErrorMessage ="Máximo {0} caracteres")]
        [Display(Name ="Forma de pagamento")]
        public string FormaPagamento { get; set; }

        [Display(Name = "Data da compra")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataCompra { get; set; }

        [Display(Name = "Total da compra")]
        //[DataType(DataType.Currency)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
