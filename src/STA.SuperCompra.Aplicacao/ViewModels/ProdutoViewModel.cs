using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Aplicacao.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            ProdutoId = Guid.NewGuid();
        }
        [Key]
        public Guid ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o nome do produto")]
        [MaxLength(60, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo {0} caracteres")]
        [DisplayName("Nome do produto")]
        public string NomeProduto { get; set; }

        [DisplayName("Unidade")]
        [Required(ErrorMessage = "Selecione a unidade de medida do produto")]
        public Guid UnidadeMedidaId { get; set; }

        [DisplayName("Imagem do produto")]
        public byte[] Imagem { get; set; }

        [MaxLength(250, ErrorMessage ="Máximo {0} caracteres")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Selecione a categoria do produto")]
        public Guid CategoriaId { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
