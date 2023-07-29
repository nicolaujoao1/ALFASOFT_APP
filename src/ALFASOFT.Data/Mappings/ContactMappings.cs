using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ALFASOFT.Domain.Entities;

namespace SistemaInscricao.Data.Mappings
{
    public class UnidadeMappings : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar(250)");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar(250)");

            builder.Property(c => c.ContactNumber)
             .IsRequired()
             .HasColumnType("nvarchar(9)");

            builder.Property(c => c.EmailAddress)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.ToTable("tbContact");
        }
    }
}
