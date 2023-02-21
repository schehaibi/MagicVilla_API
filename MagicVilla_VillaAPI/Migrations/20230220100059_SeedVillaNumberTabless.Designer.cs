﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230220100059_SeedVillaNumberTabless")]
    partial class SeedVillaNumberTabless
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2726),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2734)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa2",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2737),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa3",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2738)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa4",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa5",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VillaNo");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            VillaNo = 1,
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2824),
                            SpecialDetails = "hello",
                            UpdatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2825)
                        },
                        new
                        {
                            VillaNo = 2,
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2826),
                            SpecialDetails = "bye",
                            UpdatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827)
                        },
                        new
                        {
                            VillaNo = 3,
                            CreatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827),
                            SpecialDetails = "hi",
                            UpdatedDate = new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2828)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
