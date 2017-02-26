using SimpleInjector;
using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.Services;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Interfaces.Service;
using STA.SuperCompra.Dominio.Services;
using STA.SuperCompra.Infra.Dados.Contexto;
using STA.SuperCompra.Infra.Dados.Interfaces;
using STA.SuperCompra.Infra.Dados.Repositorio;
using STA.SuperCompra.Infra.Dados.UoW;

namespace STA.SuperCompra.Infra.CrossCutting.IoC
{
    public  class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            //App
            container.RegisterPerWebRequest<IProdutoAppService, ProdutoAppService>();
            container.RegisterPerWebRequest<ICategoriaAppService, CategoriaAppService>();
            container.RegisterPerWebRequest<ICompraAppService, CompraAppService>();
            container.RegisterPerWebRequest<IUnidadeMedidaAppService, UnidadeMedidaAppService>();
            container.RegisterPerWebRequest<IItensCompraAppService, ItensCompraAppService>();
            //Domain
            container.RegisterPerWebRequest<IProdutoService, ProdutoService>();
            container.RegisterPerWebRequest<ICategoriaService, CategoriaService>();
            container.RegisterPerWebRequest<ICompraService, CompraService>();
            container.RegisterPerWebRequest<IUnidadeMedidaService, UnidadeMedidaService>();
            container.RegisterPerWebRequest<IItensCompraService, ItensCompraService>();
            //Infra Dados
            container.RegisterPerWebRequest<IProdutoRepository, ProdutoRepository>();
            container.RegisterPerWebRequest<ICategoriaRepository, CategoriaRepository>();
            container.RegisterPerWebRequest<ICompraRepository, CompraRepository>();
            container.RegisterPerWebRequest<IUnidadeMedidaRepository, UnidadeMedidaRepository>();
            container.RegisterPerWebRequest<IitensCompraRepository, ItensCompraRepository>();
            //Infra Dados Outras configurações
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<SuperCompraContext>();
        }
    }
}
