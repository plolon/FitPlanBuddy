using FitPlanBuddy.Domain.Models;
using FitPlanBuddy.Domain.Repositories;

namespace FitPlanBuddy.Database.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FPBDbContext _dbContext;
        public UnitOfWork(FPBDbContext dbContext, IExerciseRepository exerciseRepository)
        {
            _dbContext = dbContext;
            ExerciseRepository = exerciseRepository;
        }

        public IExerciseRepository ExerciseRepository { get; }

        public async Task Complete()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<IGenericRepository<T>> GetGenericRepositoryAsync<T>() where T : DomainEntity
        {
            return new GenericRepository<T>(_dbContext);
        }
    }
}
