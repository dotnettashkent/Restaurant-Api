using Restaurant.Service.DTOs.Eats;
using Restaurant.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
