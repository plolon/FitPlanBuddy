using FitPlanBuddy.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FitPlanBuddy.Application.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private readonly DbContext _dbContext;
        public GenericRepository(DbContext dbContext)
        {
            if (dbContext is null)
            {
                throw new ArgumentNullException("dbContext is null");
            }
            _dbContext = dbContext;
        }
        public async Task<Entity> GetById(int id)
        {
            return await _dbContext.Set<Entity>().FindAsync(id);
        }
        public async Task<IEnumerable<Entity>> GetAll()
        {
            return await _dbContext.Set<Entity>().ToListAsync();
        }

        public async Task<Entity> Create(Entity entity)
        {
            await _dbContext.Set<Entity>().AddAsync(entity);
            return entity;
        }

        public async Task<Entity> Update(Entity entity)
        {
            _dbContext.Set<Entity>().Update(entity);
            return entity;
        }
        public async Task<bool> DeleteById(int id)
        {
            var entity = await _dbContext.Set<Entity>().FindAsync(id);
            if(entity is not null)
            {
                _dbContext.Set<Entity>().Remove(entity);
                return true;
            }
            return false;
        }
    }
}
