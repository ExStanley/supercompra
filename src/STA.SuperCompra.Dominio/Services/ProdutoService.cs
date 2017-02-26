using STA.SuperCompra.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Validations.Produtos;

namespace STA.SuperCompra.Dominio.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRespository)
        {
            _produtoRepository = produtoRespository;
        }

        public Produto Adicionar(Produto produto)
        {
            if (!produto.IsValid())
            {
                return produto;
            }

            produto.ValidationResult = new ProdutoAptoParaCadastroValidation(_produtoRepository).Validate(produto);
            if (!produto.ValidationResult.IsValid)
            {
                return produto;
            }

            produto.ValidationResult.Message = "Produto cadastrado com sucesso :";
            return _produtoRepository.Adicionar(produto);

        }

        public Produto Atualizar(Produto produto)
        {
            return _produtoRepository.Atualizar(produto);
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Produto ObterPorId(Guid id)
        {
            return _produtoRepository.ObterPorId(id);
        }

        public Produto ObterPorNome(string nome)
        {
            return _produtoRepository.Buscar(p => p.NomeProduto == nome).FirstOrDefault();
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _produtoRepository.Remover(id);
        }
    }
}
