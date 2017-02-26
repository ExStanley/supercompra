using STA.SuperCompra.Dominio.Interfaces.Service;
using STA.SuperCompra.Infra.Dados.Interfaces;
using STA.SuperCompra.Aplicacao.Interfaces;
using STA.SuperCompra.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using AutoMapper;
using STA.SuperCompra.Dominio.Entidades;

namespace STA.SuperCompra.Aplicacao.Services
{
    public class UnidadeMedidaAppService : ApplicationService, IUnidadeMedidaAppService
    {
        private readonly IUnidadeMedidaService _unidadeMedidaService;

        public UnidadeMedidaAppService(IUnidadeMedidaService unidadeMedidaService, IUnitOfWork uow) : base(uow)
        {
            _unidadeMedidaService = unidadeMedidaService;
        }

        public UnidadeMedidaViewModel Adicionar(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            var unidadeMedida = Mapper.Map<UnidadeMedidaViewModel, UnidadeMedida>(unidadeMedidaViewModel);
            BeginTransaction();
            _unidadeMedidaService.Adicionar(unidadeMedida);
            Commit();
            return unidadeMedidaViewModel;
        }

        public UnidadeMedidaViewModel Atualizar(UnidadeMedidaViewModel unidadeMedidaViewModel)
        {
            var unidadeMedida = Mapper.Map<UnidadeMedidaViewModel, UnidadeMedida>(unidadeMedidaViewModel);
            BeginTransaction();
            _unidadeMedidaService.Atualizar(unidadeMedida);
            Commit();
            return unidadeMedidaViewModel;
        }

        public void Dispose()
        {
            _unidadeMedidaService.Dispose();
            GC.ReRegisterForFinalize(this);
        }

        public UnidadeMedidaViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<UnidadeMedida, UnidadeMedidaViewModel>(_unidadeMedidaService.ObterPorId(id));
        }

        public UnidadeMedidaViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<UnidadeMedida, UnidadeMedidaViewModel>(_unidadeMedidaService.ObterPorNome(nome));
        }

        public IEnumerable<UnidadeMedidaViewModel> ObterTodos()
        {
            return Mapper.Map< IEnumerable<UnidadeMedida>, IEnumerable<UnidadeMedidaViewModel>>(_unidadeMedidaService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _unidadeMedidaService.Remover(id);
        }
    }
}
