// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZodiacSign.Persistence.Configurations.DbContext;

#nullable disable

namespace ZodiacSign.Persistence.Migrations
{
    [DbContext(typeof(ZodiacSignDbContext))]
    [Migration("20220714092004_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SignHome", b =>
                {
                    b.Property<int>("signId")
                        .HasColumnType("int");

                    b.Property<int>("homeId")
                        .HasColumnType("int");

                    b.HasKey("signId", "homeId");

                    b.HasIndex("homeId");

                    b.ToTable("SignHome");

                    b.HasData(
                        new
                        {
                            signId = 1,
                            homeId = 3
                        },
                        new
                        {
                            signId = 1,
                            homeId = 7
                        },
                        new
                        {
                            signId = 2,
                            homeId = 2
                        },
                        new
                        {
                            signId = 2,
                            homeId = 11
                        },
                        new
                        {
                            signId = 3,
                            homeId = 3
                        },
                        new
                        {
                            signId = 4,
                            homeId = 5
                        },
                        new
                        {
                            signId = 5,
                            homeId = 9
                        },
                        new
                        {
                            signId = 6,
                            homeId = 3
                        },
                        new
                        {
                            signId = 7,
                            homeId = 11
                        },
                        new
                        {
                            signId = 8,
                            homeId = 7
                        },
                        new
                        {
                            signId = 8,
                            homeId = 3
                        },
                        new
                        {
                            signId = 9,
                            homeId = 1
                        },
                        new
                        {
                            signId = 10,
                            homeId = 8
                        },
                        new
                        {
                            signId = 11,
                            homeId = 10
                        },
                        new
                        {
                            signId = 11,
                            homeId = 8
                        },
                        new
                        {
                            signId = 12,
                            homeId = 6
                        },
                        new
                        {
                            signId = 12,
                            homeId = 1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Element", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

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
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8626),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Air (mutable)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8660),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8663),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Earth (fixed)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8664),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8666),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "fire (cardinal)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8668),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8670),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "water (cardinal)",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8671),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Gem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

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
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(433),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Amber",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(444),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(447),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Amethyst",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(448),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(450),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Aquamarine",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(452),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(453),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Diamond",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(455),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(457),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Emerald",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(458),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(460),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Garnet",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(461),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(463),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Opal",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(465),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(466),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Pearl",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(468),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(470),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Ruby",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(471),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(473),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Sapphire",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(474),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(476),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Topaz",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(477),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(479),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Turquoise",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(481),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Home", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

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
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1507),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Jupiter",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1516),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1518),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Land",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1520),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1522),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Mars",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1523),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1525),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Mercury",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1526),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1528),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Moon",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1529),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1531),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Neptune",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1533),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1534),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Pluto",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1536),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1537),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Saturn",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1539),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1541),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Sun",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1543),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1544),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Uranus",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1546),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1548),
                            CreatedBy = -1,
                            IsActive = true,
                            Name = "Venus",
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1549),
                            UpdatedBy = -1
                        });
                });

            modelBuilder.Entity("ZodiacSign.Domain.Entities.Sign", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8456),
                            CreatedBy = -1,
                            ElementId = 3,
                            FromDay = 21,
                            FromMonth = 3,
                            GemId = 9,
                            IsActive = true,
                            Name = "Aries",
                            UntilDay = 20,
                            UntilMonth = 4,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8471),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8475),
                            CreatedBy = -1,
                            ElementId = 2,
                            FromDay = 21,
                            FromMonth = 4,
                            GemId = 5,
                            IsActive = true,
                            Name = "Taurus",
                            UntilDay = 20,
                            UntilMonth = 5,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8477),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8479),
                            CreatedBy = -1,
                            ElementId = 1,
                            FromDay = 21,
                            FromMonth = 5,
                            GemId = 8,
                            IsActive = true,
                            Name = "Gemini",
                            UntilDay = 21,
                            UntilMonth = 6,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8481),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8483),
                            CreatedBy = -1,
                            ElementId = 4,
                            FromDay = 22,
                            FromMonth = 6,
                            GemId = 4,
                            IsActive = true,
                            Name = "Cancer",
                            UntilDay = 22,
                            UntilMonth = 7,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8484),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8486),
                            CreatedBy = -1,
                            ElementId = 3,
                            FromDay = 23,
                            FromMonth = 7,
                            GemId = 1,
                            IsActive = true,
                            Name = "Leo",
                            UntilDay = 23,
                            UntilMonth = 8,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8487),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8489),
                            CreatedBy = -1,
                            ElementId = 2,
                            FromDay = 24,
                            FromMonth = 8,
                            GemId = 10,
                            IsActive = true,
                            Name = "Virgo",
                            UntilDay = 23,
                            UntilMonth = 9,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8491),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8493),
                            CreatedBy = -1,
                            ElementId = 1,
                            FromDay = 24,
                            FromMonth = 9,
                            GemId = 7,
                            IsActive = true,
                            Name = "Libra",
                            UntilDay = 22,
                            UntilMonth = 10,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8496),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8498),
                            CreatedBy = -1,
                            ElementId = 1,
                            FromDay = 23,
                            FromMonth = 10,
                            GemId = 11,
                            IsActive = true,
                            Name = "Scorpio",
                            UntilDay = 22,
                            UntilMonth = 11,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8500),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8502),
                            CreatedBy = -1,
                            ElementId = 2,
                            FromDay = 23,
                            FromMonth = 11,
                            GemId = 11,
                            IsActive = true,
                            Name = "Sagittarius",
                            UntilDay = 21,
                            UntilMonth = 12,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8503),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8505),
                            CreatedBy = -1,
                            ElementId = 2,
                            FromDay = 22,
                            FromMonth = 12,
                            GemId = 6,
                            IsActive = true,
                            Name = "Capricorn",
                            UntilDay = 20,
                            UntilMonth = 1,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8506),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8508),
                            CreatedBy = -1,
                            ElementId = 1,
                            FromDay = 21,
                            FromMonth = 1,
                            GemId = 2,
                            IsActive = true,
                            Name = "Aquarium",
                            UntilDay = 20,
                            UntilMonth = 2,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8509),
                            UpdatedBy = -1
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8511),
                            CreatedBy = -1,
                            ElementId = 1,
                            FromDay = 21,
                            FromMonth = 2,
                            GemId = 3,
                            IsActive = true,
                            Name = "Pisces",
                            UntilDay = 20,
                            UntilMonth = 3,
                            UpdatedAt = new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8513),
                            UpdatedBy = -1
                        });
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
