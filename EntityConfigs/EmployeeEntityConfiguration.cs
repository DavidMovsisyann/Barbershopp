using BarberShopp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Barbershopp.EntityConfigs
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.ToTable("Employee");

            builder
                 .Property(p => p.Name)
                 .HasColumnType("nvarchar")
                 .HasMaxLength(30);
            builder
                .Property(p => p.BusyTime)
                .HasColumnType("Date");
            builder.Property(p => p.Info)
                .HasColumnType("nvarchar(70)");
            builder.
                Property(p => p.Image)
                .HasColumnType("nvarchar(max)");
            builder.HasKey(p => p.Id);

            builder.HasKey(e=>e.Id);


        }
    }
}
