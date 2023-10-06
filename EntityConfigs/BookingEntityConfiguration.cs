using BarberShopp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbershopp.EntityConfigs
{
    public class BookingEntityConfiguration : IEntityTypeConfiguration<BookingHistoryEntity>
    {
        public void Configure(EntityTypeBuilder<BookingHistoryEntity> builder)
        {
            builder.ToTable("BookingHistory");

            builder.HasKey(x => x.Id);

            builder.
                Property(x => x.BookedDate)
                .HasColumnType("DateTime");
        }
    }
}
