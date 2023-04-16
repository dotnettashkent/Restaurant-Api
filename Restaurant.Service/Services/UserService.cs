using Restaurant.Service.DTOs.Users;
using Restaurant.Service.Interfaces;

namespace Restaurant.Service.Services
{
    public class UserService : IUserService
    {
        public ValueTask<UserDto> AddServiceAsync(UserCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteServiceAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<UserDto>> GetAllSericeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserDto> GetServiceAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserDto> UpdateServiceAsync(long id, UserUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
