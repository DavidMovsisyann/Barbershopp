using Barbershopp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.DataBase
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookingHistoryEntity> BookingHistories { get; set; }
        public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
    }
}
