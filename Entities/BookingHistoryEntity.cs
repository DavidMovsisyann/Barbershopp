namespace Barbershopp.Entities
{
    public class BookingHistoryEntity
    {
        public int Id { get; set; }
        public string EmoloyeeId { get; set; }
        public string UserId { get; set; }
        public DateTime BookedDate { get; set; }
        public DateTime BusyTime { get; set; }
    }
}
