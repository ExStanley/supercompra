using STA.SuperCompra.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace STA.SuperCompra.Infra.Dados.EntityConfig
{
    public class ItensCompraConfig : EntityTypeConfiguration<ItensCompra>
    {
        public ItensCompraConfig()
        {
            ToTable("ItensCompra");

            HasKey(c => c.ItensCompraId);

            Property(c => c.ProdutoId).IsRequired();
            Property(c => c.Quantidade).IsRequired().HasPrecision(10, 2);
            Property(c => c.ValorUnitario).IsRequired().HasPrecision(10, 2);

            HasRequired(i => i.Compra)
                .WithMany(i => i.Itens)
                .HasForeignKey(c => c.CompraId);

            Ignore(c => c.ValidationResult);
        }
    }
}
