using Microsoft.EntityFrameworkCore;
using Restaurant.Data.Contexts;
using Restaurant.Data.IRepositories;
using Restaurant.Domain.Entities;

namespace Restaurant.Data.Repositories
{
    public class EatRepository : IEatRepository
    {
        protected readonly AppDbContext appDbContext;
        protected readonly DbSet<Eat> dbSet;

        public EatRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<Eat>();
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var first = dbSet.FindAsync(id);
            if (first == null)
                return false;
            dbSet.Remove(await first);
            return true;
        }

        public async Task<IEnumerable<Eat>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Eat> GetAsync(long id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<Eat> InsertAsync(Eat eat)
        {
            await dbSet.AddAsync(eat);
            return eat;
        }

        public async Task SaveChangesAsync()
            => await appDbContext.SaveChangesAsync();

        public async Task<Eat> UpdateAsync(Eat eat)
        {
            var update = appDbContext.Update(eat);
            return update.Entity;
        }
    }
}
