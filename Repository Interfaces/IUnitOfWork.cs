using Microsoft.EntityFrameworkCore.Storage;

namespace BarberShopp.Repository_Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IEmployeeRepository Employee { get; }
        IServiceRepository Service { get; }
        IBookingHistoryRepository BookingHistory { get; }

        Task CompleteAsync();
        Task<IDbContextTransaction> GetTransaction();
    }
}
