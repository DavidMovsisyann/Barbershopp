using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Barbershopp.Service_Interfaces;

namespace Barbershopp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddUser(UserEntity user)
        {
            _unitOfWork.User.Insert(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUser(UserEntity user)
        {
            await _unitOfWork.User.Delete(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<UserEntity> GetUserById(int id)
        {
            var user = await _unitOfWork.User.Get(x => x.Id == id);
            return user;
        }

        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
            var users = await _unitOfWork.User.GetAll(x => x.Id > 0, 0, null);
            return users;
        }

        public async Task UpdateUser(UserEntity user)
        {
            await _unitOfWork.User.Update(user);
            await _unitOfWork.CompleteAsync();
        }
    }
}
