using Microsoft.VisualStudio.TestTools.UnitTesting;
using STA.SuperCompra.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCompra.Dominio.Test.Entity
{
    [TestClass]
    public class CategoriaTest
    {
        public Categoria Categoria { get; set; }

        [TestMethod]
        public void Categoria_Valida_Test()
        {
            Categoria = new Categoria()
            {
                CategoriaId = Guid.NewGuid(),
                Descricao = "Nova Categoria"
            };
            Assert.IsTrue(Categoria.IsValid());
        }

    }
}
