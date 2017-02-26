using STA.SuperCompra.Infra.Dados.Contexto;
using STA.SuperCompra.Infra.Dados.Interfaces;
using System;

namespace STA.SuperCompra.Infra.Dados.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SuperCompraContext _context;
        private bool _disposed;

        public UnitOfWork(SuperCompraContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
