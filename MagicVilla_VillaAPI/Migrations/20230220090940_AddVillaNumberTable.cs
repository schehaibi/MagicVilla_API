using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddVillaNumberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillasNumber",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillasNumber", x => x.VillaNo);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillasNumber");

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
