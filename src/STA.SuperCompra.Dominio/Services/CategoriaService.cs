using STA.SuperCompra.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Validations.Categorias;

namespace STA.SuperCompra.Dominio.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Categoria Adicionar(Categoria categoria)
        {
            categoria.ValidationResult = new CategoriaAptoParaCadastroValidation(_categoriaRepository).Validate(categoria);
            if (!categoria.ValidationResult.IsValid)
            {
                return categoria;
            }
            return _categoriaRepository.Adicionar(categoria);
        }

        public Categoria Atualizar(Categoria categoria)
        {
            return _categoriaRepository.Atualizar(categoria);
        }

        public void Dispose()
        {
            _categoriaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Categoria ObterPorId(Guid id)
        {
            return _categoriaRepository.ObterPorId(id);
        }

        public Categoria ObterPorNome(string nome)
        {
            return _categoriaRepository.Buscar(c => c.Descricao == nome).FirstOrDefault();
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _categoriaRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _categoriaRepository.Remover(id);
        }
    }
}
