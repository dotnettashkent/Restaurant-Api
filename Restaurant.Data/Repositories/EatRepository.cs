﻿using Restaurant.Data.IRepositories;
using Restaurant.Domain.Entities;

namespace Restaurant.Data.Repositories
{
    public class EatRepository : IEatRepository
    {
        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Eat>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Eat> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Eat> InsertAsync(Eat eat)
        {
            throw new NotImplementedException();
        }

        public Task<Eat> UpdateAsync(Eat eat)
        {
            throw new NotImplementedException();
        }
    }
}
