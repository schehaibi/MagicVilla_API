using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class MyVillaNumberMigrationss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9488), new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 2, 20, 13, 26, 37, 825, DateTimeKind.Local).AddTicks(9491) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 2, 20, 13, 17, 6, 307, DateTimeKind.Local).AddTicks(7964) });
        }
    }
}
