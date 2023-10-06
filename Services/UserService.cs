using BarberShopp.Entities;
using BarberShopp.Repository_Interfaces;
using BarberShopp.Service_Interfaces;

namespace BarberShopp.Services
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
        public bool CheckUser(string name, string pass)
        {
            var user = _unitOfWork.User.Get(x => x.UserName == name && x.Password == pass);
            if (user!=null)
            {
                return true;
            }
            return false;
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
