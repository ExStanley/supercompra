using STA.SuperCompra.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace STA.SuperCompra.Infra.Dados.EntityConfig
{
    public class CompraConfig : EntityTypeConfiguration<Compra>
    {
        public CompraConfig()
        {
            ToTable("Compra");

            HasKey(l => l.CompraId);

            Property(l => l.NomeLista).IsRequired().HasMaxLength(20);
            Property(l => l.NomeEstabelecimento).IsOptional().HasMaxLength(60);
            Property(l => l.FormaPagamento).IsOptional().HasMaxLength(30);
            Property(l => l.DataCompra).IsOptional();
            Property(l => l.Total).IsOptional().HasPrecision(10, 2);

            Ignore(c => c.ValidationResult);

        }
    }
}
