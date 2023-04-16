using Restaurant.Service.DTOs.Eats;
using Restaurant.Service.Interfaces;

namespace Restaurant.Service.Services
{
    public class EatService : IEatService
    {
        public ValueTask<EatDto> AddServiceAsync(EatCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteServiceAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<EatDto>> GetAllSericeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<EatDto> GetServiceAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<EatDto> UpdateServiceAsync(long id, EatUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
