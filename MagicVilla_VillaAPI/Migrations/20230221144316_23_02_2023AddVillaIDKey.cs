using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class _23_02_2023AddVillaIDKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7312), new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7535), new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7537), new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 2, 21, 15, 43, 16, 333, DateTimeKind.Local).AddTicks(7539) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1469), new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 2, 20, 17, 55, 38, 236, DateTimeKind.Local).AddTicks(1474) });
        }
    }
}
