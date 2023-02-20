using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaTable23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Villas",
                newName: "UpdateDate");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 2, 19, 1, 13, 1, 705, DateTimeKind.Local).AddTicks(5207) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Villas",
                newName: "UpdatedDate");

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
    }
}
