using Restaurant.Service.DTOs.Users;

namespace Restaurant.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserDto> GetServiceAsync(long id);
        ValueTask<IEnumerable<UserDto>> GetAllSericeAsync();
        ValueTask<UserDto> AddServiceAsync(UserCreationDto dto);
        ValueTask<UserDto> UpdateServiceAsync(long id, UserUpdateDto dto);
        ValueTask<bool> DeleteServiceAsync(long id);
    }
}
