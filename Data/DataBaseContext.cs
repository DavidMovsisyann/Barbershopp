using Barbershopp.Entities;
using Barbershopp.EntityConfigs;
using BarberShopp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberShopp.DataBase
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BarberServicesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BookingEntityConfiguration());
        }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookingHistoryEntity> BookingHistories { get; set; }
        public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public DbSet<BarberServicesEntity> Services { get; set; }
    }
}

