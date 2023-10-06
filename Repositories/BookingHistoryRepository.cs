using BarberShopp.Entities;
using BarberShopp.Repository_Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberShopp.Repositories
{
    public class BookingHistoryRepository : GenericRepository<BookingHistoryEntity>,IBookingHistoryRepository
    {
        public BookingHistoryRepository(DbContext context) : base(context) { }
    }
}
