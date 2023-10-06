using Barbershopp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbershopp.EntityConfigs
{
    public class BarberServicesEntityConfiguration : IEntityTypeConfiguration<BarberServicesEntity>
    {
        public void Configure(EntityTypeBuilder<BarberServicesEntity> builder)
        {
            builder.ToTable("BarberServicesEntity");

            builder.
              Property(x => x.Name)
             .HasColumnType("nvarchar")
             .HasMaxLength(50); 

            builder.HasKey(x => x.Id);
        }
    }
}
