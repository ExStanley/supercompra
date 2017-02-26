namespace STA.SuperCompra.Infra.Dados.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<STA.SuperCompra.Infra.Dados.Contexto.SuperCompraContext>
    {
        public Configuration()
        {
            /*True - Permite alterações na base de dados
             False - Não permite alterações na base de dados*/
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(STA.SuperCompra.Infra.Dados.Contexto.SuperCompraContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
