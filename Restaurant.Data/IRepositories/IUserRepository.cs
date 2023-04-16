using Restaurant.Domain.Entities;

namespace Restaurant.Data.IRepositories
{
    public interface IUserRepository
    {
        Task<User> InsertAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(long id);
        Task<User> GetByIdAsync(long id);
        Task<IEnumerable<User>> GetAllAsync();
        Task SaveChangesAsync();
    }
}
