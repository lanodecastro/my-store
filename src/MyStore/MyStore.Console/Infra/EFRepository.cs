using MyStore.Core.Domain;

namespace MyStore.Core.Infra
{
    public class EFRepository<TEntity> : IRepository<TEntity>
    {
        private readonly DefaultDbContext _dbContext;

        public EFRepository(DefaultDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Get(object id)
        {
            return (TEntity) _dbContext.Find(typeof(TEntity), id);
        }

        public void Save(TEntity obj)
        {
            _dbContext.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _dbContext.Update(obj);
        }
    }
}
