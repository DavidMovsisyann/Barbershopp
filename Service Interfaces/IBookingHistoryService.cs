using BarberShopp.Entities;

namespace BarberShopp.Service_Interfaces
{
    public interface IBookingHistoryService
    {
        Task AddBookingHistory(BookingHistoryEntity BookingHistory);
        Task UpdateBookingHistory(BookingHistoryEntity BookingHistory);
        Task DeleteBookingHistory(BookingHistoryEntity BookingHistory);
        Task<BookingHistoryEntity> GetBookingHistoryById(int id);
        Task<IEnumerable<BookingHistoryEntity>> GetBookingHistorys();
    }
}
