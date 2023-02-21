using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaNumberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1942), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1952), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.InsertData(
                table: "VillasNumber",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2061), "hello", new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2062) },
                    { 2, new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2062), "bye", new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2063) },
                    { 3, new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2064), "hi", new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2064) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 2, 20, 10, 9, 39, 775, DateTimeKind.Local).AddTicks(4219) });
        }
    }
}
