using GestaoPonto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoPonto.Repository.Maps
{
    public class CollaboratorMap : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(255);

            builder.Property(e => e.Username)
                        .IsRequired()
                        .HasMaxLength(255);

            builder.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(255);

            builder.Property(e => e.Role)
                        .IsRequired()
                        .HasMaxLength(255);
            
            builder.ToTable("Collaborators");
        }
    }
}
