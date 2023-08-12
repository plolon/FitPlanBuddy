namespace FitPlanBuddy.Domain.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task<Entity> GetById(int id);
        Task<IEnumerable<Entity>> GetAll();
        Task<Entity> Create(Entity entity);
        Task<Entity> Update(Entity entity);
        Task<bool> DeleteById(int id);
    }
}
