using STA.SuperCompra.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace STA.SuperCompra.Infra.Dados.EntityConfig
{
    public class UnidadeMedidaConfig: EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaConfig()
        {
            ToTable("UnidadeMedida");

            HasKey(u => u.UnidadeMedidaId);

            Property(u => u.Unidade)
                .IsRequired()
                .HasMaxLength(3);

            Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(20);

            Ignore(c => c.ValidationResult);
        }
    }
}
