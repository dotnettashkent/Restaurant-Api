using AutoMapper;
using Restaurant.Data.IRepositories;
using Restaurant.Domain.Entities;
using Restaurant.Service.DTOs.Eats;
using Restaurant.Service.Exceptions;
using Restaurant.Service.Interfaces;

namespace Restaurant.Service.Services
{
    public class EatService : IEatService
    {
        private readonly IMapper mapper;
        private readonly IEatRepository eatRepository;

        public EatService(IMapper mapper, IEatRepository eatRepository)
        {
            this.mapper = mapper;
            this.eatRepository = eatRepository;
        }

        public async ValueTask<EatDto> AddServiceAsync(EatCreationDto dto)
        {
            try
            {
                var eat = mapper.Map<Eat>(dto);
                await eatRepository.InsertAsync(eat);
                return mapper.Map<EatDto>(eat);
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to add eat");
            }
        }

        public async ValueTask<bool> DeleteServiceAsync(long id)
        {
            try
            {
                var eat = await eatRepository.GetAsync(id);
                if (eat == null) return false;
                await eatRepository.DeleteAsync(eat.Id);
                return true;
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to delete eat");
            }
        }

        public async ValueTask<IEnumerable<EatDto>> GetAllSericeAsync()
        {
            try
            {
                var eats = await eatRepository.GetAllAsync();
                return mapper.Map<IEnumerable<EatDto>>(eats);
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to retrieve eats");
            }
        }

        public async ValueTask<EatDto> GetServiceAsync(long id)
        {
            try
            {
                var eat = await eatRepository.GetAsync(id);
                return mapper.Map<EatDto>(eat);
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to retrieve eat");
            }
        }

        public async ValueTask<EatDto> UpdateServiceAsync(long id, EatUpdateDto dto)
        {
            try
            {
                var eat = await eatRepository.GetAsync(id);
                if (eat == null) return null;
                mapper.Map(dto, eat);
                await eatRepository.UpdateAsync(eat);
                return mapper.Map<EatDto>(eat);
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to update eat");
            }
        }
    }

}
