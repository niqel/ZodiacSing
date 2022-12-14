// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZodiacSign.Persistence.Configurations.DbContext;

#nullable disable

namespace ZodiacSign.Persistence.Migrations
{
    [DbContext(typeof(ZodiacSignDbContext))]
    partial class ZodiacSignDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SignHome", b =>
                {
                    b.Property<int>("homeId")
                        .HasColumnType("int");

                    b.Property<int>("signId")
                        .HasColumnType("int");

                    b.HasKey("homeId", "signId");

                    b.HasIndex("signId");

                    b.ToTable("SignHome");
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("createdBy")
                        .HasColumnOrder(3);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt")
                        .HasColumnOrder(5);

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("updatedBy")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Element", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6606),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Air (mutable)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6636),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6639),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Earth (fixed)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6641),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6643),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "fire (cardinal)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6644),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6646),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "water (cardinal)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6648),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Gem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("createdBy")
                        .HasColumnOrder(3);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt")
                        .HasColumnOrder(5);

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("updatedBy")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Gem", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7626),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Amber",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7634),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7637),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Amethyst",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7639),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7641),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Aquamarine",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7642),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7644),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Diamond",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7646),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7648),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Emerald",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7650),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7652),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Garnet",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7653),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7655),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Opal",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7657),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7659),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Pearl",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7660),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7662),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Ruby",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7664),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7666),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Sapphire",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7667),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7669),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Topaz",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7671),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7673),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Turquoise",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7674),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("createdBy")
                        .HasColumnOrder(3);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt")
                        .HasColumnOrder(5);

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("updatedBy")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Home", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8557),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Jupiter",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8564),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8607),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Land",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8609),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8612),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Mars",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8613),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8615),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Mercury",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8617),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8619),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Moon",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8620),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8622),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Neptune",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8624),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8626),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Pluto",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8627),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8629),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Saturn",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8631),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8633),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Sun",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8635),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8636),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Uranus",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8638),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8640),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Venus",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8641),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Sign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt")
                        .HasColumnOrder(10);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("createdBy")
                        .HasColumnOrder(9);

                    b.Property<int>("ElementId")
                        .HasColumnType("int")
                        .HasColumnName("elementId")
                        .HasColumnOrder(6);

                    b.Property<int>("FromDay")
                        .HasColumnType("int")
                        .HasColumnName("fromDay")
                        .HasColumnOrder(3);

                    b.Property<int>("FromMonth")
                        .HasColumnType("int")
                        .HasColumnName("fromMonth")
                        .HasColumnOrder(2);

                    b.Property<int>("GemId")
                        .HasColumnType("int")
                        .HasColumnName("gemId")
                        .HasColumnOrder(7);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive")
                        .HasColumnOrder(8);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name")
                        .HasColumnOrder(1);

                    b.Property<int>("UntilDay")
                        .HasColumnType("int")
                        .HasColumnName("untilDay")
                        .HasColumnOrder(5);

                    b.Property<int>("UntilMonth")
                        .HasColumnType("int")
                        .HasColumnName("untilMonth")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updatedAt")
                        .HasColumnOrder(11);

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int")
                        .HasColumnName("updatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.HasIndex("GemId");

                    b.ToTable("Sign", (string)null);
                });

            modelBuilder.Entity("SignHome", b =>
                {
                    b.HasOne("ZodiacSign.Domain.Entities.Home", null)
                        .WithMany()
                        .HasForeignKey("homeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZodiacSign.Domain.Entities.Sign", null)
                        .WithMany()
                        .HasForeignKey("signId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Sign", b =>
                {
                    b.HasOne("ZodiacSign.Domain.Entities.Element", "Element")
                        .WithMany("Signs")
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZodiacSign.Domain.Entities.Gem", "Gem")
                        .WithMany("Signs")
                        .HasForeignKey("GemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");

                    b.Navigation("Gem");
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Element", b =>
                {
                    b.Navigation("Signs");
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Gem", b =>
                {
                    b.Navigation("Signs");
                });
#pragma warning restore 612, 618
        }
    }
}
