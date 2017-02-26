namespace STA.SuperCompra.Infra.Dados.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
