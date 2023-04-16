using Restaurant.Service.DTOs.Eats;

namespace Restaurant.Service.Interfaces
{
    public interface IEatService
    {
        ValueTask<EatDto> GetServiceAsync(long id);
        ValueTask<IEnumerable<EatDto>> GetAllSericeAsync();
        ValueTask<EatDto> AddServiceAsync(EatCreationDto dto);
        ValueTask<EatDto> UpdateServiceAsync(long id, EatUpdateDto dto);
        ValueTask<bool> DeleteServiceAsync(long id);
    }
}
