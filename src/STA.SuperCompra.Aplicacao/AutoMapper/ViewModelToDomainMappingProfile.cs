using AutoMapper;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Dominio.Entidades;

namespace STA.SuperCompra.Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<CompraViewModel, Compra>();
            Mapper.CreateMap<ItensCompraViewModel, ItensCompra >();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<UnidadeMedidaViewModel, UnidadeMedida>();
        }
    }
}