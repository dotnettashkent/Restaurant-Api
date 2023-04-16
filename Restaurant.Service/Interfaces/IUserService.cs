using Restaurant.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserDto> GetServiceAsync(long id);
        ValueTask<IEnumerable<UserDto>> GetAllSericeAsync();
        ValueTask<UserDto> AddServiceAsync(UserCreationDto dto);
        ValueTask<UserDto> UpdateServiceAsync(long id,UserUpdateDto dto);
        ValueTask<bool> DeleteServiceAsync(long id);
    }
}
