using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.IRepositories
{
    public interface IEatRepository
    {
        Task<Eat> InsertAsync(Eat eat);
        Task<Eat> UpdateAsync(Eat eat);
        Task<bool> DeleteAsync(long id);
        Task<Eat> GetAsync (long id);
        Task<IEnumerable<Eat>> GetAllAsync ();
    }
}
