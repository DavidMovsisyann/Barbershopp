using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.Repositories
{
    public class UserRepository:GenericRepository<UserEntity>,IUserRepository
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
