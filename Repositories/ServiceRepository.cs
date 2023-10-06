using Barbershopp.Entities;
using BarberShopp.Entities;
using BarberShopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberShopp.Repositories
{
    public class ServiceRepository : GenericRepository<BarberServicesEntity>, IServiceRepository
    {
        public ServiceRepository(DbContext context) : base(context) { }
    }
}
