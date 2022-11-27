using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.Repositories
{
    public class BookingHistoryRepository : GenericRepository<BookingHistoryEntity>,IBookingHistoryRepository
    {
        public BookingHistoryRepository(DbContext context) : base(context) { }
    }
}
