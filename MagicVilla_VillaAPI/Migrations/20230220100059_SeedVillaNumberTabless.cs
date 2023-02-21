using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaNumberTabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VillasNumber",
                table: "VillasNumber");

            migrationBuilder.RenameTable(
                name: "VillasNumber",
                newName: "VillaNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers");

            migrationBuilder.RenameTable(
                name: "VillaNumbers",
                newName: "VillasNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VillasNumber",
                table: "VillasNumber",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5309), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5555) });
        }
    }
}
