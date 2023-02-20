using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1286), new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1302), new DateTime(2023, 2, 19, 1, 8, 15, 253, DateTimeKind.Local).AddTicks(1303) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4788), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 8, 50, 915, DateTimeKind.Local).AddTicks(4802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
