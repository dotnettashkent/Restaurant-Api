using Microsoft.EntityFrameworkCore;
using Restaurant.Data.Contexts;
using Restaurant.Data.IRepositories;
using Restaurant.Domain.Entities;

namespace Restaurant.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly AppDbContext appDbContext;
        protected readonly DbSet<User> dbSet;

        public UserRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<User>();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var user = dbSet.FindAsync(id);
            if (user == null)
                return false;
            dbSet.Remove(await user);
            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<User> GetByIdAsync(long id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<User> InsertAsync(User user)
        {
            var entry = await dbSet.AddAsync(user);
            return entry.Entity;
        }

        public async Task SaveChangesAsync()
            => await appDbContext.SaveChangesAsync();

        public async Task<User> UpdateAsync(User user)
        {
            var first = dbSet.Update(user);
            await appDbContext.SaveChangesAsync();
            return first.Entity;
        }
    }
}
