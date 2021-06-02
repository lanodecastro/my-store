namespace MyStore.Core.Domain
{
    public interface IRepository<TEntity>
    {
        public void Save(TEntity obj);
        public TEntity Get(object id);
        public void Update(TEntity obj);
    }
}
