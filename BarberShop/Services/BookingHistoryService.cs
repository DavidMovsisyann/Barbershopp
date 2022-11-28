using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Barbershopp.Service_Interfaces;

namespace Barbershopp.Services
{
    public class BookingHistoryService : IBookingHistoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingHistoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookingHistory(BookingHistoryEntity bookingHistory)
        {
             _unitOfWork.BookingHistory.Insert(bookingHistory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookingHistory(BookingHistoryEntity bookingHistory)
        {
            await _unitOfWork.BookingHistory.Delete(bookingHistory);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<BookingHistoryEntity> GetBookingHistoryById(int id)
        {
            var bookingHistory = await _unitOfWork.BookingHistory.Get(x => x.Id == id);
            return bookingHistory;
        }

        public async Task<IEnumerable<BookingHistoryEntity>> GetBookingHistorys()
        {
            var bookingHistories = await _unitOfWork.BookingHistory.GetAll(x => x.Id > 0, 0, null);
            return bookingHistories;
        }

        public async Task UpdateBookingHistory(BookingHistoryEntity bookingHistory)
        {
            await _unitOfWork.BookingHistory.Update(bookingHistory);
            await _unitOfWork.CompleteAsync();
        }
    }
}
