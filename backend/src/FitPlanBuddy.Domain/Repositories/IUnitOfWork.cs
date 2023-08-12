using FitPlanBuddy.Domain.Models;

namespace FitPlanBuddy.Domain.Repositories
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task Complete();
        Task<IGenericRepository<T>> GetGenericRepositoryAsync<T>() where T : DomainEntity; 
    }
}
