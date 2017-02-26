using STA.SuperCompra.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace STA.SuperCompra.Infra.Dados.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produto");

            HasKey(p => p.ProdutoId);

            Property(p => p.NomeProduto)
                .IsRequired()
                .HasMaxLength(60);

            Property(p => p.Imagem)
                .IsOptional();

            Property(p => p.Observacao)
                .IsOptional()
                .HasMaxLength(250);

            Ignore(c => c.ValidationResult);

            HasRequired(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            HasRequired(p => p.Unidade)
                .WithMany(u => u.Produtos)
                .HasForeignKey(p => p.UnidadeMedidaId);



        }
    }
}
