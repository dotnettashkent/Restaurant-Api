using Restaurant.Domain.Entities;

namespace Restaurant.Data.IRepositories
{
    public interface IEatRepository
    {
        Task<Eat> InsertAsync(Eat eat);
        Task<Eat> UpdateAsync(Eat eat);
        Task<bool> DeleteAsync(long id);
        Task<Eat> GetAsync(long id);
        Task<IEnumerable<Eat>> GetAllAsync();
        Task SaveChangesAsync();
    }
}
