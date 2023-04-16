using AutoMapper;
using Restaurant.Data.IRepositories;
using Restaurant.Domain.Entities;
using Restaurant.Service.DTOs.Users;
using Restaurant.Service.Exceptions;
using Restaurant.Service.Interfaces;

namespace Restaurant.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async ValueTask<UserDto> AddServiceAsync(UserCreationDto dto)
        {
            try
            {
                var user = mapper.Map<User>(dto);
                await userRepository.InsertAsync(user);
                return mapper.Map<UserDto>(user);
            }
            catch (Exception)
            {
                throw new RestaurantException(403, "User already exist with this username");
            }
        }

        public async ValueTask<bool> DeleteServiceAsync(long id)
        {
            try
            {
                var user = await userRepository.GetByIdAsync(id);
                if (user == null)
                    return false;
                await userRepository.DeleteAsync(user.Id);
                return true;
            }
            catch (Exception)
            {
                throw new RestaurantException(404, "User not found");
            }
        }

        public async ValueTask<IEnumerable<UserDto>> GetAllSericeAsync()
        {
            try
            {
                var users = await userRepository.GetAllAsync();
                return mapper.Map<IEnumerable<UserDto>>(users);
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Something went wromg");
            }
        }

        public async ValueTask<UserDto> GetServiceAsync(long id)
        {
            try
            {
                var user = await userRepository.GetByIdAsync(id);
                if (user == null)
                {
                    throw new RestaurantException(404, $"User with id {id} not found.");
                }
                return mapper.Map<UserDto>(user);
            }
            catch (RestaurantException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to get user");
            }
        }

        public async ValueTask<UserDto> UpdateServiceAsync(long id, UserUpdateDto dto)
        {
            try
            {
                var user = await userRepository.GetByIdAsync(id);
                if (user == null)
                {
                    throw new RestaurantException(404, $"User with id {id} not found.");
                }
                mapper.Map(dto, user);
                await userRepository.UpdateAsync(user);
                return mapper.Map<UserDto>(user);
            }
            catch (RestaurantException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new RestaurantException(500, "Failed to update user");
            }
        }
    }


}
