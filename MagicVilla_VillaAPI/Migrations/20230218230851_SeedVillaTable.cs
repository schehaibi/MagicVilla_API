using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4788), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4799), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa2", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4800), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa3", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4801), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa4", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4802), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa5", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
