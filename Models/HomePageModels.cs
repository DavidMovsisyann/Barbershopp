using Barbershopp.Entities;
using BarberShopp.Entities;

namespace Barbershopp.Models
{
    public class HomePageModels
    {
        public IEnumerable<BarberServicesEntity> Services { get; set; }
        public BookingHistoryEntity Booking { get; set; }
        public IEnumerable<EmployeeEntity> Employees { get; set; }
        public IEnumerable<BookingHistoryEntity> Bookings { get; set; }
    }
}
