using BarberShopp.Repository_Interfaces;
using BarberShopp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberShopp.Repositories
{
    public class UserRepository:GenericRepository<UserEntity>,IUserRepository
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
