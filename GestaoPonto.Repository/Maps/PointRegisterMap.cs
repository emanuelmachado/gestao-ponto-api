using GestaoPonto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoPonto.Repository.Maps
{
    public class PointRegisterMap : IEntityTypeConfiguration<PointRegister>
    {
        public void Configure(EntityTypeBuilder<PointRegister> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.EventIdentifier)
                        .IsRequired()
                        .HasMaxLength(1);

            builder.Property(e => e.Register)
                        .IsRequired();

            builder.ToTable("PointRegisters");
        }
    }
}
