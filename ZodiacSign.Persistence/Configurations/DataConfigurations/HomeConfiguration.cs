using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZodiacSign.Domain.Entities;
using ZodiacSign.Domain.Entities.EntitiesBase;

namespace ZodiacSign.Persistence.Configurations.DataConfigurations
{
    public class HomeConfiguration : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("Home");
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
                new Home
                {
                    Id = 1,
                    Name = "Jupiter",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 2,
                    Name = "Land",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 3,
                    Name = "Mars",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 4,
                    Name = "Mercury",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 5, 
                    Name = "Moon",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 6,
                    Name = "Neptune",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 7,
                    Name = "Pluto",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 8,
                    Name = "Saturn",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 9,
                    Name = "Sun",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 10,
                    Name = "Uranus",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Home
                {
                    Id = 11,
                    Name = "Venus",
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                });
        }
    }
}






 





