using STA.SuperCompra.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace STA.SuperCompra.Infra.Dados.EntityConfig
{
    public class CategoriaConfig: EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            ToTable("Categoria");

            HasKey(c => c.CategoriaId);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(60);

            Ignore(c => c.ValidationResult);
        }
    }
}
