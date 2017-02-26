using STA.SuperCompra.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using STA.SuperCompra.Aplicacao.ViewModels;
using STA.SuperCompra.Dominio.Interfaces.Service;
using STA.SuperCompra.Infra.Dados.Interfaces;
using AutoMapper;
using STA.SuperCompra.Dominio.Entidades;

namespace STA.SuperCompra.Aplicacao.Services
{
    public class CategoriaAppService : ApplicationService, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService, IUnitOfWork uow)
            :base(uow)
        {
            _categoriaService = categoriaService;
        }

        public CategoriaViewModel Adicionar(CategoriaViewModel categoriaViewModel)
        {
            var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
            BeginTransaction();
            _categoriaService.Adicionar(categoria);
            Commit();
            return categoriaViewModel;
        }

        public CategoriaViewModel Atualizar(CategoriaViewModel categoriaViewModel)
        {
            var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);
            BeginTransaction();
            _categoriaService.Atualizar(categoria);
            Commit();
            return categoriaViewModel;
        }

        public void Dispose()
        {
            _categoriaService.Dispose();
            GC.SuppressFinalize(this);
        }

        public CategoriaViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Categoria, CategoriaViewModel>(_categoriaService.ObterPorId(id));
        }

        public CategoriaViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<Categoria, CategoriaViewModel>(_categoriaService.ObterPorNome(nome));
        }

        public IEnumerable<CategoriaViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _categoriaService.Remover(id);
        }
    }
}
