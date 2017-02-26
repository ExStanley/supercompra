using DomainValidation.Validation;
using STA.SuperCompra.Dominio.Entidades;
using STA.SuperCompra.Dominio.Interfaces.Repository;
using STA.SuperCompra.Dominio.Specifications.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA.SuperCompra.Dominio.Validations.Categorias
{
    public  class CategoriaAptoParaCadastroValidation: Validator<Categoria>
    {
        public CategoriaAptoParaCadastroValidation(ICategoriaRepository categoriaRepository)
        {
            var categoriaUnica = new CategoriaDeveSerUnicaSpecification(categoriaRepository);

            base.Add("categoriaUnica", new Rule<Categoria>(categoriaUnica, "Categoria já cadastrada. Verifique!"));

        }

    }
}
