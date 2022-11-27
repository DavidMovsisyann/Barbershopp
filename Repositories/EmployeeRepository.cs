using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context) { }
    }
}
