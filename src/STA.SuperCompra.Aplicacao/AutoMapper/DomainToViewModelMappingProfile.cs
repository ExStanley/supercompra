using AutoMapper;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Dominio.Entidades;

namespace STA.SuperCompra.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Compra, CompraViewModel>();
            Mapper.CreateMap<ItensCompra, ItensCompraViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<UnidadeMedida, UnidadeMedidaViewModel>();

        }
    }
}