using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.IRepositories
{
    public interface IUserRepository
    {
        Task<User> InsertAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(long id);
        Task<User> GetByIdAsync(long id);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
