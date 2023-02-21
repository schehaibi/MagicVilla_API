﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Usermod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usermod");
                });

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
                            CreatedDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2859),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2871)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2874),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa2",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2875)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2876),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa3",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2877)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2944),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa4",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2945)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2947),
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Name = "Royal Villa5",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2948)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
