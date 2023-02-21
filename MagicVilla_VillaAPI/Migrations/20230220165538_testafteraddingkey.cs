using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class testafteraddingkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8595) });
        }
    }
}
