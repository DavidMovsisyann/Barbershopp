using Barbershopp.Entities;

namespace Barbershopp.Service_Interfaces
{
    public interface IUserService
    {
        Task AddUser(UserEntity user);
        Task UpdateUser(UserEntity user);
        Task DeleteUser(UserEntity user);
        Task<UserEntity> GetUserById(int id);
        Task<IEnumerable<UserEntity>> GetUsers();
    }
}
