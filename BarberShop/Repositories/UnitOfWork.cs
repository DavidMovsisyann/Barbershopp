using Barbershopp.DataBase;
using Barbershopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Barbershopp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IUserRepository User { get; }
        public IEmployeeRepository Employee { get; }
        public IServiceRepository Service { get; }
        public IBookingHistoryRepository BookingHistory { get; }

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            Employee = new EmployeeRepository(_context);
            Service = new ServiceRepository(_context);
            BookingHistory = new BookingHistoryRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> GetTransaction()
        {
            return await _context.Database.BeginTransactionAsync();
        }
    }
}
