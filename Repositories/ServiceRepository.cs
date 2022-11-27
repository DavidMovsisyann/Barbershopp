using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.Repositories
{
    public class ServiceRepository : GenericRepository<ServiceEntity>, IServiceRepository
    {
        public ServiceRepository(DbContext context) : base(context) { }
    }
}
