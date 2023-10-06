using BarberShopp.Entities;
using BarberShopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberShopp.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context) { }
    }
}
