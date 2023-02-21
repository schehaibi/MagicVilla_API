using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class MyVillaNumberMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

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
    }
}
