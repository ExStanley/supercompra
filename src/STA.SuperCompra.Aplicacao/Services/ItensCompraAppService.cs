using STA.SuperCompra.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using STA.SuperCompra.Infra.Dados.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Dominio.Interfaces.Service;
using AutoMapper;
using STA.SuperCompra.Dominio.Entidades;
using System.Linq;

namespace STA.SuperCompra.Aplicacao.Services
{
    public class ItensCompraAppService : ApplicationService, IItensCompraAppService
    {
        private readonly IItensCompraService _itensCompraService;
        private readonly ICompraService _compraService;

        public ItensCompraAppService(IItensCompraService itensCompraService, ICompraService compraService, IUnitOfWork uow) : base(uow)
        {
            _itensCompraService = itensCompraService;
            _compraService = compraService;
        }

        public ItensCompraViewModel Adicionar(ItensCompraViewModel itensCompraViewModel)
        {
            var compra = _compraService.ObterPorId(itensCompraViewModel.CompraId);

            var itensCompra = Mapper.Map<ItensCompraViewModel, ItensCompra>(itensCompraViewModel);
            BeginTransaction();
            _itensCompraService.Adicionar(itensCompra);
            compra.Total = _compraService.ObterPorId(itensCompraViewModel.CompraId).Itens.Select(t => t.Quantidade * t.ValorUnitario).Sum();
            _compraService.Atualizar(compra);
            Commit();
            return itensCompraViewModel;
        }

        public ItensCompraViewModel Atualizar(ItensCompraViewModel itensCompraViewModel)
        {
            var compra = _compraService.ObterPorId(itensCompraViewModel.CompraId);
            var itensCompra = Mapper.Map<ItensCompraViewModel, ItensCompra>(itensCompraViewModel);

            BeginTransaction();
            _itensCompraService.Atualizar(itensCompra);
            compra.Total = _compraService.ObterPorId(itensCompraViewModel.CompraId).Itens.Select(t => t.Quantidade * t.ValorUnitario).Sum();
            _compraService.Atualizar(compra);
            Commit();

            return itensCompraViewModel;

        }

        public void Dispose()
        {
            _itensCompraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ItensCompraViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ItensCompra, ItensCompraViewModel>(_itensCompraService.ObterPorId(id));
        }

        public ItensCompraViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<ItensCompra, ItensCompraViewModel>(_itensCompraService.ObterPorNome(nome));
        }

        public IEnumerable<ItensCompraViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ItensCompra>, IEnumerable<ItensCompraViewModel>>(_itensCompraService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _itensCompraService.Remover(id);
        }
    }
}
