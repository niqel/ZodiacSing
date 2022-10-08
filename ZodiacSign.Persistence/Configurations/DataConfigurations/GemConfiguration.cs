using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZodiacSign.Domain.Entities;

namespace ZodiacSign.Persistence.Configurations.DataConfigurations
{
    public class GemConfiguration : IEntityTypeConfiguration<Gem>
    {
        public void Configure(EntityTypeBuilder<Gem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Gem");
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
                new Gem
                {
                    Id = 1,
                    Name = "Amber",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id= 2,
                    Name = "Amethyst",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 3,
                    Name = "Aquamarine",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 4,
                    Name = "Diamond",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 5,
                    Name = "Emerald",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 6,
                    Name = "Garnet",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 7,
                    Name = "Opal",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id= 8,
                    Name = "Pearl",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 9,
                    Name = "Ruby",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 10,
                    Name = "Sapphire",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 11,
                    Name = "Topaz",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Gem
                {
                    Id = 12,
                    Name = "Turquoise",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                });
        }
    }
}
