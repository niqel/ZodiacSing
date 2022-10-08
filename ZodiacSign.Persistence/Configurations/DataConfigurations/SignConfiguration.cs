using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZodiacSign.Domain.Entities;

namespace ZodiacSign.Persistence.Configurations.DataConfigurations
{
    public class SignConfiguration : IEntityTypeConfiguration<Sign>
    {
        public void Configure(EntityTypeBuilder<Sign> builder)
        {
            builder.ToTable("Sign");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Element)
                .WithMany(x => x.Signs)
                .HasForeignKey(x => x.ElementId);
            builder.HasOne(x => x.Gem)
                .WithMany(x => x.Signs)
                .HasForeignKey(x => x.GemId);
            builder.HasMany(x => x.Homes).WithMany(x => x.Signs)
                .UsingEntity<Dictionary<string, object>>(
                "SignHome",
                r => r.HasOne<Home>().WithMany().HasForeignKey("homeId"),
                l => l.HasOne<Sign>().WithMany().HasForeignKey("signId"));
                //je => 
                //{
                //    je.HasKey("signId", "homeId");
                //    je.HasData(
                //        new { signId = 1, homeId = 3 },
                //        new { signId = 1, homeId = 7 },
                //        new { signId = 2, homeId = 2 },
                //        new { signId = 2, homeId = 11 },
                //        new { signId = 3, homeId = 3 },
                //        new { signId = 4, homeId = 5 },
                //        new { signId = 5, homeId = 9 },
                //        new { signId = 6, homeId = 3 },
                //        new { signId = 7, homeId = 11 },
                //        new { signId = 8, homeId = 7 },
                //        new { signId = 8, homeId = 3 },
                //        new { signId = 9, homeId = 1 },
                //        new { signId = 10, homeId = 8 },
                //        new { signId = 11, homeId = 10 },
                //        new { signId = 11, homeId = 8 },
                //        new { signId = 12, homeId = 6 },
                //        new { signId = 12, homeId = 1 });
                //});
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnOrder(0);
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnOrder(1);
            builder.Property(x => x.FromMonth)
                .HasColumnName("fromMonth")
                .IsRequired()
                .HasColumnOrder(2);
            builder.Property(x => x.FromDay)
                .HasColumnName("fromDay")
                .IsRequired()
                .HasColumnOrder(3);
            builder.Property(x => x.UntilMonth)
                .HasColumnName("untilMonth")
                .IsRequired()
                .HasColumnOrder(4);
            builder.Property(x => x.UntilDay)
                .HasColumnName("untilDay")
                .IsRequired()
                .HasColumnOrder(5);
            builder.Property(x => x.ElementId)
                .IsRequired()
                .HasColumnName("elementId")
                .HasColumnOrder(6);
            builder.Property(x => x.GemId)
                .HasColumnName("gemId")
                .IsRequired()
                .HasColumnOrder(7);
            builder.Property(x => x.IsActive)
                .HasColumnName("isActive")
                .IsRequired()
                .HasColumnOrder(8);
            builder.Property(x => x.CreatedBy)
                .HasColumnName("createdBy")
                .IsRequired()
                .HasColumnOrder(9);
            builder.Property(x => x.CreatedAt)
                .HasColumnName("createdAt")
                .IsRequired()
                .HasColumnOrder(10);
            builder.Property(x => x.UpdatedBy)
                .HasColumnName("updatedBy")
                .IsRequired();
            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updatedAt")
                .IsRequired()
                .HasColumnOrder(11);

            builder.HasData(
                new Sign
                {
                    Id = 1,
                    Name = "Aries",
                    FromMonth = 3,
                    FromDay = 21,
                    UntilMonth = 4,
                    UntilDay = 20,
                    ElementId = 3,
                    GemId = 9,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 2,
                    Name = "Taurus",
                    FromMonth = 4,
                    FromDay = 21,
                    UntilMonth = 5,
                    UntilDay = 20,
                    ElementId = 2,
                    GemId = 5,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 3,
                    Name = "Gemini",
                    FromMonth = 5,
                    FromDay = 21,
                    UntilMonth = 6,
                    UntilDay = 21,
                    ElementId = 1,
                    GemId = 8,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 4,
                    Name = "Cancer",
                    FromMonth = 6,
                    FromDay = 22,
                    UntilMonth = 7,
                    UntilDay = 22,
                    ElementId = 4,
                    GemId = 4,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 5,
                    Name = "Leo",
                    FromMonth = 7,
                    FromDay = 23,
                    UntilMonth = 8,
                    UntilDay = 23,
                    ElementId = 3,
                    GemId = 1,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 6,
                    Name = "Virgo",
                    FromMonth = 8,
                    FromDay = 24,
                    UntilMonth = 9,
                    UntilDay = 23,
                    ElementId = 2,
                    GemId = 10,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 7,
                    Name = "Libra",
                    FromMonth = 9,
                    FromDay = 24,
                    UntilMonth = 10,
                    UntilDay = 22,
                    ElementId = 1,
                    GemId = 7,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 8,
                    Name = "Scorpio",
                    FromMonth = 10,
                    FromDay = 23,
                    UntilMonth = 11,
                    UntilDay = 22,
                    ElementId = 1,
                    GemId = 11,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 9,
                    Name = "Sagittarius",
                    FromMonth = 11,
                    FromDay = 23,
                    UntilMonth = 12,
                    UntilDay = 21,
                    ElementId = 2,
                    GemId = 11,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 10,
                    Name = "Capricorn",
                    FromMonth = 12,
                    FromDay = 22,
                    UntilMonth = 1,
                    UntilDay = 20,
                    ElementId = 2,
                    GemId = 6,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 11,
                    Name = "Aquarium",
                    FromMonth = 1,
                    FromDay = 21,
                    UntilMonth = 2,
                    UntilDay = 20,
                    ElementId = 1,
                    GemId = 2,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                },
                new Sign
                {
                    Id = 12,
                    Name = "Pisces",
                    FromMonth = 2,
                    FromDay = 21,
                    UntilMonth = 3,
                    UntilDay = 20,
                    ElementId = 1,
                    GemId = 3,
                    CreatedBy = -1,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = -1,
                });
        }
    }
}
