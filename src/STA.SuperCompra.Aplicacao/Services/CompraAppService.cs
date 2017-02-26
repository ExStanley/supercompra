using STA.SuperCompra.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STA.SuperCompra.Infra.Dados.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Dominio.Interfaces.Service;
using AutoMapper;
using STA.SuperCompra.Dominio.Entidades;

namespace STA.SuperCompra.Aplicacao.Services
{
    public class CompraAppService : ApplicationService, ICompraAppService
    {
        private readonly ICompraService _compraService;

        public CompraAppService(ICompraService compraService, IUnitOfWork uow) : base(uow)
        {
            _compraService = compraService;
        }

        public CompraViewModel Adicionar(CompraViewModel compraViewModel)
        {
            var compra = Mapper.Map<CompraViewModel, Compra>(compraViewModel);
            BeginTransaction();
            _compraService.Adicionar(compra);
            Commit();
            return compraViewModel;
        }

        public CompraViewModel Atualizar(CompraViewModel compraViewModel)
        {
            var compra = Mapper.Map<CompraViewModel, Compra>(compraViewModel);
            BeginTransaction();
            _compraService.Atualizar(compra);
            Commit();
            return compraViewModel;
        }

        public void Dispose()
        {
            _compraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public CompraViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Compra, CompraViewModel>(_compraService.ObterPorId(id));
        }

        public CompraViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Compra, CompraViewModel>(_compraService.ObterPorNome(nome));
        }

        public IEnumerable<CompraViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Compra>, IEnumerable<CompraViewModel>>(_compraService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _compraService.Remover(id);
        }
    }
}
