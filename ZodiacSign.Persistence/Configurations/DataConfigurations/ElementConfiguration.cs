using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZodiacSign.Domain.Entities;

namespace ZodiacSign.Persistence.Configurations.DataConfigurations
{
    public class ElementConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("Element");
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnOrder(0);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(20)
                .HasColumnOrder(1);
            builder.Property(x => x.IsActive)
                .HasColumnName("isActive")
                .IsRequired()
                .HasColumnOrder(2);
            builder.Property(x => x.CreatedBy)
                .IsRequired()
                .HasColumnName("createdBy")
                .HasColumnOrder(3);
            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasColumnName("createdAt");
            builder.Property(x => x.UpdatedBy)
                .IsRequired()
                .HasColumnName("updatedBy")
                .HasColumnOrder(4);
            builder.Property(x => x.UpdatedAt)
                .IsRequired()
                .HasColumnName("updatedAt")
                .HasColumnOrder(5);

            builder.HasData(
                new Element
                {
                    Id = 1,
                    Name = "Air (mutable)",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Element 
                {
                    Id=2,
                    Name = "Earth (fixed)",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Element
                {
                    Id = 3,
                    Name = "fire (cardinal)",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Element
                {
                    Id = 4,
                    Name = "water (cardinal)",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                });
        }
    }
}
