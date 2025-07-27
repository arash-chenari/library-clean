namespace Library.Entities.Abstraction
{
    public interface IUnitOfWork
    {
        void Commit();
        void Save();
        void Rollback();
        void Begin();
    }
}
