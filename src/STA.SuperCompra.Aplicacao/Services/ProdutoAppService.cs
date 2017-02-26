using STA.SuperCompra.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Infra.Dados.Interfaces;
using AutoMapper;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Service;
using AutoMapper.Configuration;

namespace STA.SuperCompra.Aplicacao.Services
{
    public class ProdutoAppService : ApplicationService, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService, IUnitOfWork uow)
            : base(uow)
        {
            _produtoService = produtoService;
        }

        public ProdutoViewModel Adicionar(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
            BeginTransaction();
            _produtoService.Adicionar(produto);
            Commit();
            return produtoViewModel;
        }

        public ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel)
        {
            BeginTransaction();
            _produtoService.Atualizar(Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel));
            Commit();
            return produtoViewModel;
        }

        public void Dispose()
        {
            _produtoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ProdutoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(_produtoService.ObterPorId(id));
        }

        public ProdutoViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(_produtoService.ObterPorNome(nome));
        }

        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _produtoService.Remover(id);
        }
    }
}
