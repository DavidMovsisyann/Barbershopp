using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShopp.Entities
{
    public class BookingHistoryEntity
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int UserId { get; set; }
        public DateTime BookedDate { get; set; }

    }
}
